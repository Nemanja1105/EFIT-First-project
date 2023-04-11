using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Bodyweight_Students
{
    class KorisnikDB
    {
        //static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        static string connString = "Data Source=NEMANJA-PC\\NEMANJASQL;Initial Catalog=\"BodyWeight DB\";Integrated Security=True";
        static public void DodajKorisnika(Korisnik k)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DodajKorisnika",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ime", k.Ime));
                    cmd.Parameters.Add(new SqlParameter("@prezime", k.Prezime));
                    cmd.Parameters.Add(new SqlParameter("@godine", k.Godine));
                    cmd.Parameters.Add(new SqlParameter("@nivoSpreme", k.Nivo_Spreme.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@visina", k.Visina));
                    cmd.Parameters.Add(new SqlParameter("@tezina", k.Vaganje[0].tezina));
                    cmd.Parameters.Add(new SqlParameter("@pol", (k.Gender == Korisnik.Pol.Muski) ? 1 : 0));
                    cmd.Parameters.Add(new SqlParameter("@datumPrijave", k.Datum_prijave));
                    SqlParameter id = new SqlParameter { ParameterName = "@id", Direction = ParameterDirection.Output ,SqlDbType=SqlDbType.Int};
                    cmd.Parameters.Add(id);
                    cmd.ExecuteNonQuery();
                    k.Korisnik_ID = (int)cmd.Parameters["@id"].Value;

                   
                }
            }

        }

    }
    
}
