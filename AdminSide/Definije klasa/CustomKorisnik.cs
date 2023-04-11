using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSide
{
    class CustomKorisnik
    {
        private int korisnikId;
        private string ime;
        private string prezime;
        private Korisnik.Spremnost spremnost;
        private string email;
        private string password;
        private bool verifikacija;
        private DateTime datumReg;

        public CustomKorisnik(int korisnikId, string ime, string prezime, Korisnik.Spremnost spremnost, string email, string password, bool verifikacija, DateTime datumReg)
        {
            this.KorisnikId = korisnikId;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Spremnost = spremnost;
            this.Email = email;
            this.Password = password;
            this.Verifikacija = verifikacija;
            this.DatumReg = datumReg;
        }

        public int KorisnikId { get => korisnikId; set => korisnikId = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public Korisnik.Spremnost Spremnost { get => spremnost; set => spremnost = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool Verifikacija { get => verifikacija; set => verifikacija = value; }
        public DateTime DatumReg { get => datumReg; set => datumReg = value; }
        public string FullName { get => ime + " " + prezime; }
    }
}
