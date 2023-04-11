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


namespace Bodyweight_Students
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
            //patern za regex format emaila
            string validationPatern = ConfigurationManager.AppSettings["regexPatern"];

            //provjeravamo email i password posto su to parametri koji se unose
            //verifikaciju dobijamo od programa, a korisnik id od baze pod.
            if (string.IsNullOrEmpty(email))
                throw new KorisnickiIzuzeci.MailTestException(KorisnickiIzuzeci.MailTestException.errors.prazno);
            else if (!Regex.IsMatch(email, validationPatern))
                throw new KorisnickiIzuzeci.MailTestException(KorisnickiIzuzeci.MailTestException.errors.format);
            else
                this.email = email;

            if (string.IsNullOrEmpty(password))
                throw new KorisnickiIzuzeci.PasswordException(KorisnickiIzuzeci.PasswordException.erros.prazno);
            else if (password.Length < 8)
                throw new KorisnickiIzuzeci.PasswordException(KorisnickiIzuzeci.PasswordException.erros.duzina);
            else
                this.password = password;

            this.verification = verification; this.korisnik_id = korisnik_id;
        }

        //geteri i seteri za klasu
        public string Email { get { return email; } set { email = value; } }
        public string Password
        {   get
                { return password; }
            set {
                password = value;
            }
        }
        public bool IsVerified { get { return verification; } set { verification = value; } }
        public int Korisnik_id { get { return korisnik_id; } }
        public string Kod { get { return kod; } }

        //koristimo guid kriptografski alat za kreiranje privremenog
        //kljuca za verifikaciju korisnika
        //kada god pozovemo funkciju kreira se novi kljuc
        private void GenerisiKod()
        {
            Guid generator = Guid.NewGuid();
            string kod = generator.ToString().Substring(0, 6).ToUpper();
            this.kod = kod;
        }

        //ako je parametar iz baze podataka isVerified
        //false pozivamo ovu funkcijuk koja salje verifikacioni kod na email
        public void PosaljiKodNaMail()
        {
            //generisemo privremeni kod za verifikaciju
            //koji se salje na email korisnika
            GenerisiKod();

            //smtp parametri za komunikaciju sa mail serverom
            string smtpServer = ConfigurationManager.AppSettings["smtpServer"];
            int smtpPort = Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]);
            string smtpEmail = ConfigurationManager.AppSettings["smtpEmail"];
            string smtpPassword = ConfigurationManager.AppSettings["smtpPass"];



            //ako se desi greska izbaciti korisnicku gresku
            //i ponovo pokrenuti funkciju ne zanima nas zbog cega
            //je doslo do greska
            //try
           // {
                SmtpClient smtpserver = new SmtpClient(smtpServer, smtpPort);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(smtpEmail);
                mail.To.Add(this.email);
                mail.Subject = "Verification code";
            //u resursima se nalazi html kod 
            // mail.IsBodyHtml = true;
            //mail.Body = Resursi.sajt.Replace("{Code}", this.kod);
            mail.Body = this.kod;
            smtpserver.UseDefaultCredentials = false;
            smtpserver.Credentials = new NetworkCredential(smtpEmail, smtpPassword);
                smtpserver.EnableSsl = true;
                
            smtpserver.Send(mail);
          //  }
            //catch(Exception ex)
            //{
              //  throw new KorisnickiIzuzeci.MailException();
           // }
            
        }

    }
}
