using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;


namespace AdminSide
{
    public class Loginkorisnika
    {
        //privatna polja koja su nam potrebna prilikom login korisnika
        private string email;
        private string password;
        private bool verification;
        private int korisnik_id;
        private string kod;

        //konstuktori podrazumjevani i parametarski
        public Loginkorisnika()
        {

            email = ""; password = "";
            verification = false; korisnik_id = -1;
        }

        //email i password treba provjeriti prilikom registracije korisnika
        //kada se jednom provjeri konstruktor koristimo samo za inicijalizaciju
        //parametara iz baze podataka
        //za validaciju koristimo regex patern koji se spremljen u konfig fajlu
        public Loginkorisnika(string email, string password, bool verification, int korisnik_id)
        {
          this.email = email;
          this.password = password;
          this.verification = verification;
          this.korisnik_id = korisnik_id;
        }

        //geteri i seteri za klasu
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } }
        
        public bool IsVerified { get { return verification; } set { verification = value; } }
        public int Korisnik_id { get { return korisnik_id; } }
    }
}
