using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace Bodyweight_Students
{

    //klasa za sve operacije u bazi podataka
    static class KorisnikDMS
    {
        static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        static public void DodajKorisnika(Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DodajKorisnika", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ime", k.Ime));
                    cmd.Parameters.Add(new SqlParameter("@prezime", k.Prezime));
                    cmd.Parameters.Add(new SqlParameter("@godine", k.Godine));
                    cmd.Parameters.Add(new SqlParameter("@nivoSpreme", k.Nivo_Spreme.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@visina", k.Visina));
                    cmd.Parameters.Add(new SqlParameter("@pol", (k.Gender == Korisnik.Pol.Muski) ? 1 : 0));
                    cmd.Parameters.Add(new SqlParameter("@datumPrijave", k.Datum_prijave));
                    SqlParameter id = new SqlParameter { ParameterName = "@id", Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int };
                    cmd.Parameters.Add(id);
                    cmd.ExecuteNonQuery();
                    k.ID = (int)cmd.Parameters["@id"].Value;
                }
            }
            DodajVaganje(k.ListaVaganje[0], k);

        }

        static public void BrisiKorisnika(Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("BrisiKorisnika", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id",k.ID));
                    cmd.ExecuteNonQuery();
                }
            }
            BrisiVaganja(k.ID);
            BrisiSlike(k.ID);
            BrisiAktivnosti(k.ID);
            BrisiLogin(KorisnikDMS.VratiLogin(k.ID));
            VjezbaDMS.BrisiVjezbeTrening(k.ID);
            
        }

        static public void AzurirajNivoSpreme(Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("PromijeniNivoSpreme", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", k.ID);
                    cmd.Parameters.Add("@nivospreme", k.Nivo_Spreme.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public Korisnik VratiKorisnika(int id)
        {
            string ime="", prezime="",nivo="";
            int Kid=0, godine=0, visina=0, pol=-1, tezina=0;
            DateTime? datum_prijave=null;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("VratiKorisnika", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", id);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        Kid =     (int)read["Korisnik_id"];
                        ime =     (string)read["Ime"];
                        prezime = (string)read["Prezime"];
                        godine =  (int)read["Godine"];
                        nivo =    (string)read["Nivo_spreme"];
                        visina =  (int)read["Visina"];
                        pol = Convert.ToInt32(read["Pol"]);
                        datum_prijave = (DateTime)read["DatumPrijave"];
                    }
                }
               
            }
            Korisnik.Spremnost sprema = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), nivo);
            Korisnik.Pol gender = (Korisnik.Pol)pol;
            Korisnik novi = new Korisnik(Kid, ime, prezime, godine, sprema, gender, visina, datum_prijave);
            UcitajVaganje(novi);
            return novi;
        }

        static public void DodajLogin(Loginkorisnika l)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DodajLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email", l.Email);
                    cmd.Parameters.Add("@password", l.Password);
                    cmd.Parameters.Add("@verified", l.IsVerified);
                    cmd.Parameters.Add("@korisnikId", l.Korisnik_id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public void PromjeniSifruLogin(Loginkorisnika l)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("PromjeniLozinku", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", l.Korisnik_id);
                    cmd.Parameters.Add("@password", l.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public void BrisiLogin(Loginkorisnika l)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("BrisiLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", l.Korisnik_id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public bool EmailPostoji(string email)
        {
            bool status = true;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("EmailPostoji", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email", email);
                    status = (bool)cmd.ExecuteScalar();
                }
            }
            return status;
        }

        static public Loginkorisnika VratiLogin(int korisnikId)
        {
            string email = "", password = "";
            bool verified = false;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("VratiLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", korisnikId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            email = (string)reader["Email"];
                            password = (string)reader["Password"];
                            verified = (bool)reader["IsVerified"];
                        }
                    }
                }
            }
            return new Loginkorisnika(email, password, verified, korisnikId);
        }

        static public int EmailPasswordLogin(string email,string password)
        {
            int idK = -1;
            int br = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("EmailPasswordLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email", email);
                    cmd.Parameters.Add("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //ako nema nista nece se ni pokrenuti i id ce ostati -1
                        while(reader.Read())
                            idK = (int)reader["Korisnik_ID$"];
                    }
                    
                }
            }
            return idK;
        }

        static public void UpdateKorisnik(Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateKorisnik", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", k.ID);
                    cmd.Parameters.Add("@godine", k.Godine);
                    cmd.Parameters.Add("@nivoSpreme", k.Nivo_Spreme.ToString());
                    cmd.Parameters.Add("@visina", k.Visina);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public void ResetujLozinku(Loginkorisnika l)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ResetujLozinku", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email", l.Email);
                    cmd.Parameters.Add("@password", l.Password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public void AzurirajVerifikaciju(Loginkorisnika l)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateVerified", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", l.Korisnik_id);
                    cmd.Parameters.Add("@verified", l.IsVerified);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static public void DodajVaganje(Korisnik.Vaga kilaza,Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DodajVaganje", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tezina", kilaza.tezina);
                    cmd.Parameters.Add("@datumVaganje", kilaza.datum_vaganja);
                    cmd.Parameters.Add("korisnikId", k.ID);
                    cmd.ExecuteNonQuery();
                }
            }
            k.DodajVaganje(kilaza);
        }

        static private void UcitajVaganje(Korisnik k)
        {
            Korisnik.Vaga v = new Korisnik.Vaga();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("VratiVaganja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("korisnikId", k.ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            v.tezina = (int)reader["tezine"];
                            v.datum_vaganja = (DateTime)reader["datumVaganja"];
                            k.DodajVaganje(v);
                        }
                    }
                }
            }
            k.ListaVaganje.Sort((x, y) => DateTime.Compare(x.datum_vaganja, y.datum_vaganja));

        }

        static private void BrisiVaganja(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("BrisiVaganja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //funkcija pretvara sliku u niz bitova
        public static byte[] ImageToByte2(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }

        static public void DodajSliku(Korisnik.Slike s,Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DodajSliku",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@slika", ImageToByte2(s.slika));
                    cmd.Parameters.Add("@datum", s.datum);
                    cmd.Parameters.Add("@korisnikId", k.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static private void BrisiSlike(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("BrisiSlike", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        //funkcija vraca sliku od niza bitova
        public static Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        static public List<Korisnik.Slike> UcitajSlike(int id)
        {
            List<Korisnik.Slike> nova = new List<Korisnik.Slike>();

            Korisnik.Slike slika = new Korisnik.Slike();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UcitajSlike", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@korisnikId", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            slika.slika = byteArrayToImage((byte[])reader["Slika"]);
                            slika.datum = (DateTime)reader["DatumSlikanja"];
                            nova.Add(slika);
                        }
                    }
                }
            }
            return nova;
        }

        static public void DodajAktivnost(Korisnik.Aktivnost a, Korisnik k)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DodajAktivnost", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("aktivnostH", a.aktivnost);
                        cmd.Parameters.Add("aktivnostDatum", a.VrijemeAktivnosti);
                        cmd.Parameters.Add("korisnikId$", k.ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { }
        }

        static private void BrisiAktivnosti(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("BrisiAktivnosti", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@korisnikId", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { }
        }

        static public List<Korisnik.Aktivnost> UcitajAktivnost(int id)
        {
            List<Korisnik.Aktivnost> nova = new List<Korisnik.Aktivnost>();

            Korisnik.Aktivnost aktivnost = new Korisnik.Aktivnost();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("VratiAktivnosti", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@korisnikId", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                aktivnost.aktivnost = (int)reader["AktivnostH"];
                                aktivnost.VrijemeAktivnosti = (DateTime)reader["DatumAktivnosti"];
                                nova.Add(aktivnost);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
            return nova;
        }


        static public void PovecajAktivnost(Korisnik.Aktivnost a, Korisnik K)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DodajAktivnost", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@korisnikId", K.ID);
                        cmd.Parameters.Add("@datumAktivnosti ", a.VrijemeAktivnosti);
                        cmd.Parameters.Add("@vrijednost", a.aktivnost);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { }
        }

        static public List<Korisnik.Aktivnost> UcitajSveAktivnosti()
        {
            List<Korisnik.Aktivnost> nova = new List<Korisnik.Aktivnost>();
            Korisnik.Aktivnost aa;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("VratiSveAktivnosti", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                aa.aktivnost = (int)reader["AktivnostH"];
                                aa.VrijemeAktivnosti = (DateTime)reader["DatumAktivnosti"];
                                nova.Add(aa);

                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
            return nova;
        }





    }
}
