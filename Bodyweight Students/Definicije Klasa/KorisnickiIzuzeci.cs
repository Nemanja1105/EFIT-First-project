using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodyweight_Students
{
    class KorisnickiIzuzeci
    {/*
        //sva polja
        public class Izuzetak_Prazno : Exception
        {
            public Izuzetak_Prazno() : base("Molimo popunite polje!!") { }
        }
        //ime i prezime
        public class Ime_Forma : Exception
        {
            public Ime_Forma() : base("Ovo polje zahtjeva unos samo slova") { }
        }
        //dozvoljene vrijednosti za starost//
        public class Godine_Format : Exception
        {
            public Godine_Format() : base("Godine moraju biti od 12 do 65") { }
        }
        //dopusten unos samo brojeva za godine,kile i visinu
        public class Samo_Brojevi : Exception
        {
            public Samo_Brojevi() : base("Ovo polje zahtjeva unos samo brojeva") { }
        }
        */
        public class MailException : Exception
        {
            public MailException() : base("Greska prilikom konekcija sa mail serverom!!") { }
        }
        

        public class ImeException : Exception
        {
            public enum errors { prazno,format};
            private errors greska;
            public ImeException(errors g) { this.greska = g; }
            public override string Message
            {
                get
                {
                    if (greska == errors.prazno)
                        return "Polje ime mora biti popunjeno!!";
                    else
                        return "Polje ime sadrzi samo slova!!";
                }
            }
            public errors Greska { get { return greska; } }
        }

        public class PrezimeException : Exception
        {
            public enum errors { prazno, format };
            private errors greska;
            public PrezimeException(errors g) { this.greska = g; }
            public override string Message
            {
                get
                {
                    if (greska == errors.prazno)
                        return "Polje prezime mora biti popunjeno!!";
                    else
                        return "Polje prezime sadrzi samo slova!!";
                }
            }
            public errors Greska { get { return greska; } }
        }

        public class GodineException:Exception
        {
            public enum errors { prazno, format,ogranicenje };
            private errors greska;
            public GodineException(errors g) { this.greska = g; }
            public override string Message
            {
                get
                {
                    if (greska == errors.prazno)
                        return "Polje godine mora biti popunjeno!!";
                    else if (greska == errors.format)
                        return "Polje godine sadrzi samo brojeve!!";
                    else
                        return "Godine moraju da budu vece od 14 manje od 65";
                }
            }
            public errors Greska { get { return greska; } }
        }
        


        public class MailTestException : Exception
        {
            public enum errors { prazno, format,postoji };
            private errors greska;
            public MailTestException(errors g) { this.greska = g; }
            public override string Message
            {
                get
                {
                    if (greska == errors.prazno)
                        return "Polje email mora biti popunjeno!!";
                    else if (greska == errors.format)
                        return "Pogresan format email-a";
                    else
                        return "Email je vec registrovan";
                }
            }
            public errors Greska { get { return this.greska; } }
        }

        public class PasswordException:Exception
        {
            public enum erros { prazno,duzina};
            private erros greska;
            public PasswordException(erros g) { this.greska = g; }
            public override string Message
            {
                get
                {
                    if (greska == erros.prazno)
                        return "Polje za sifru mora biti popunjeno!!";
                    else
                        return "Sifra mora da ima najmanje 8 karaktera!!";
                }
            }
            public erros Greska { get { return this.greska; } }
        }


           
        
    }
}
