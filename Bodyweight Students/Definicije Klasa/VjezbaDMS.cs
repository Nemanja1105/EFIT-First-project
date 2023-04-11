using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Bodyweight_Students
{
    class VjezbaDMS
    {

        static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public static void DodajVjezbu(Vjezba v)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DodajVjezbu", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@naziv", v.Naziv);
                    cmd.Parameters.Add("@ytCode", v.YtCode);
                    cmd.Parameters.Add("@tezina", v.TezinaVjezbe);
                    cmd.Parameters.Add("@opis", v.Opis);
                    cmd.Parameters.Add("@tipVjezbe", v.Tip_Vjezbe.ToString());
                    cmd.Parameters.Add("@dioTijela", v.Dio_Tijela.ToString());
                    SqlParameter id = new SqlParameter { ParameterName = "@id", Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int };
                    cmd.Parameters.Add(id);
                    cmd.ExecuteNonQuery();
                    v.Id = (int)cmd.Parameters["@id"].Value;
                }
            }
        }


        public static List<Vjezba> VratiVjezbe()
        {
            int id;
            string naziv, ytCode, opis, tezina, tip, dio;
            Korisnik.Spremnost tezinaVjezbe;
            Vjezba.TipVjezbe tipVjezbe;
            Vjezba.DioTijela dioTijela;
            List<Vjezba> lista = new List<Vjezba>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("VratiVjezbu", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = (int)reader["vjezbaId"];
                        naziv = (string)reader["naziv"];
                        ytCode = (string)reader["ytCode"];
                        tezina = (string)reader["tezinaVjezbe"];
                        opis = (string)reader["opis"];
                        tip = (string)reader["tipVjezbe"];
                        dio = (string)reader["dioTijela"];
                        tezinaVjezbe = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), tezina);
                        tipVjezbe = (Vjezba.TipVjezbe)Enum.Parse(typeof(Vjezba.TipVjezbe), tip);
                        dioTijela = (Vjezba.DioTijela)Enum.Parse(typeof(Vjezba.DioTijela), dio);
                        lista.Add(new Vjezba(id, naziv, ytCode, tezinaVjezbe, opis, tipVjezbe, dioTijela));
                    }
                }
            }
            return lista;
        }

        public static Vjezba VratiVjezbuPoId(int id)
        {
            int Id=-1;
            string naziv="", ytCode="", opis="", tezina="", tip="", dio="";
            Korisnik.Spremnost tezinaVjezbe;
            Vjezba.TipVjezbe tipVjezbe;
            Vjezba.DioTijela dioTijela;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("VratiVjezbuPoId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Id = (int)reader["vjezbaId"];
                        naziv = (string)reader["naziv"];
                        ytCode = (string)reader["ytCode"];
                        tezina = (string)reader["tezinaVjezbe"];
                        opis = (string)reader["opis"];
                        tip = (string)reader["tipVjezbe"];
                        dio = (string)reader["dioTijela"];
                    }
                }
            }
            tezinaVjezbe = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), tezina);
            tipVjezbe = (Vjezba.TipVjezbe)Enum.Parse(typeof(Vjezba.TipVjezbe), tip);
            dioTijela = (Vjezba.DioTijela)Enum.Parse(typeof(Vjezba.DioTijela), dio);
            return new Vjezba(id,naziv,ytCode,tezinaVjezbe,opis,tipVjezbe,dioTijela);
        }

        public static void AzurirajVjezbu(Vjezba v)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateVjezba",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", v.Id);
                    cmd.Parameters.Add("@naziv", v.Naziv);
                    cmd.Parameters.Add("@ytCode", v.YtCode);
                    cmd.Parameters.Add("@tezina", v.TezinaVjezbe);
                    cmd.Parameters.Add("@opis", v.Opis);
                    cmd.Parameters.Add("@tipVjezbe", v.Tip_Vjezbe.ToString());
                    cmd.Parameters.Add("@dioTijela", v.Dio_Tijela.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void BrisiVjezbu(Vjezba v)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("BrisiVjezbu", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", v.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int DodajTrening(LicniTrening t)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DodajTrening", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@naziv", t.Naziv);
                        cmd.Parameters.Add("@opis", t.Opis);
                        cmd.Parameters.Add("@dan", t.Dan.ToString());
                        cmd.Parameters.Add("@korisnikId", t.KorisnikID);
                        SqlParameter id = new SqlParameter { ParameterName = "@treningId ", Direction = ParameterDirection.Output, SqlDbType = SqlDbType.Int };
                        cmd.Parameters.Add(id);
                        cmd.ExecuteNonQuery();
                        t.TreningID = (int)cmd.Parameters["@treningId"].Value;
                    }
                }
            }
            catch (Exception ex) { }
            return t.TreningID;
        }

        public static void DodajVjezUTrening(LicniTrening t, VjezbaTreninga v)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DodajVjezbUTrening", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@treningId", t.TreningID);
                        cmd.Parameters.Add("@vjezbaId", v.vjezba.Id);
                        cmd.Parameters.Add("@ponavljanja", v.ponavljanja);
                        cmd.Parameters.Add("@serije", v.serija);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            t.DodajVjezbe(v);
        }

        public static LicniTrening UcitajTrening(int korisnikId, DaniSedmica dan)
        {
            int trId = -1, korId = -1;
            string naziv = "", opis = "", danStr = "";
            DaniSedmica? dns = null;
            //try
            //{
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("VratiTrening", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@korisnikId", korisnikId);
                        cmd.Parameters.Add("@dan", dan.ToString());
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                trId = (int)reader["TreningId"];
                                naziv = (string)reader["Naziv"];
                                opis = (string)reader["Opis"];
                                danStr = (string)reader["Dan"];
                                korId = (int)reader["KorisnikId"];
                            }
                        }
                    }
                }
            //}
            //catch (Exception ex) { }
            dns = (DaniSedmica)Enum.Parse(typeof(DaniSedmica), danStr);
            LicniTrening novi = new LicniTrening(trId, naziv, opis, dns, korId);
            foreach (var x in UcitajLicneVjezbe(novi.TreningID))
                novi.DodajVjezbe(x);
            return novi;
        }

        private static List<VjezbaTreninga> UcitajLicneVjezbe(int treningId)
        {
            int id = -1;
            List<VjezbaTreninga> lista = new List<VjezbaTreninga>();
            VjezbaTreninga trg = new VjezbaTreninga();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("VratiLicneVjezbe", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@treningId", treningId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id = (int)reader["VjezbaId"];
                                trg.ponavljanja = (int)reader["Ponavljanja"];
                                trg.serija = (int)reader["Serija"];
                                Vjezba v = VratiVjezbuPoId(id);
                                trg.vjezba = v;
                                lista.Add(trg);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
            return lista;
        }

        public static void IzmjeniTrening(LicniTrening l)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("IzmjeniTrening", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@naziv", l.Naziv);
                        cmd.Parameters.Add("@opis", l.Opis);
                        cmd.Parameters.Add("@treningId", l.TreningID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void BrisiTrening(LicniTrening l)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("BrisiTrening", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@korisnikId", l.KorisnikID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { }
            BrisiVjezbeTrening(l.TreningID);
        }

        public static void BrisiVjezbeTrening(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("BrisiVjezbeTrening", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TreningId", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static bool TreningPostoji(int korisnikId, DaniSedmica dan)
        {
            bool status = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("TreningPostoji", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@korisnikId ", korisnikId);
                        cmd.Parameters.Add("@dan ", dan.ToString());
                        status = (bool)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex) { }
            return status;
        }



    }
}
