using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSide
{
    static class Proracuni
    {
        private static List<CustomKorisnik> korisnici = KorisnikDMS.UcitajKorisnike();
        private static List<Vjezba> vjezbe = VjezbaDMS.VratiVjezbe();
        private static List<Korisnik.Aktivnost> aktivnosti=KorisnikDMS.UcitajSveAktivnosti();

        public static int UkupnoKorisnika { get { return korisnici.Count; } }
        public static int UkupnoVjezbi { get { return vjezbe.Count; } }
        public static int Verifikovani { get { return korisnici.Count(k => k.Verifikacija == true); } }
        public static int NisuVerifikovani { get { return korisnici.Count(k => k.Verifikacija == false); } }
        public static int BrojPocetnih { get { return korisnici.Count(k => k.Spremnost == Korisnik.Spremnost.Pocetni); } }
        public static int BrojSrednjih { get { return korisnici.Count(k => k.Spremnost == Korisnik.Spremnost.Srednji); } }
        public static int BrojNaprednih { get { return korisnici.Count(k => k.Spremnost == Korisnik.Spremnost.Napredni); } }
        public static int PosjeteDanas { get { return aktivnosti.Count(a => a.VrijemeAktivnosti.Date == DateTime.Now.Date); } }
        

        public static Dictionary<DateTime,int> NoviKorisniciSedmica
        {
            get
            {
                Dictionary<DateTime, int> rijecnik = new Dictionary<DateTime, int>();
                DateTime today = DateTime.Today;
                int currentDayOfWeek = (int)today.DayOfWeek;
                DateTime sunday = today.AddDays(-currentDayOfWeek);
                DateTime monday = sunday.AddDays(1);
                if (currentDayOfWeek == 0)
                {
                    monday = monday.AddDays(-7);
                }
                var dates = Enumerable.Range(0, 7).Select(days => monday.AddDays(days)).ToList();
                foreach (var x in dates)
                    rijecnik.Add(x, 0);
                foreach (var x in korisnici)
                {
                    if(dates.Contains(x.DatumReg))
                        rijecnik[x.DatumReg]++;
                }
                return rijecnik;
            }
        }

        public static Dictionary<DateTime,int> NoviKorisniciMjesec
        {
            get
            {
                Dictionary<DateTime, int> rijecnik = new Dictionary<DateTime, int>();
                for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
                    rijecnik.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, i), 0);
                foreach(var x in korisnici)
                {
                    if (x.DatumReg.Month == DateTime.Now.Month)
                        rijecnik[x.DatumReg]++;
                }
                return rijecnik;
            }
        }

        public static double ProsjecnaAktivnostMjesecna
        {
            get
            {
                double sum = 0;int br = 0;
                foreach(var x in aktivnosti)
                    if(x.VrijemeAktivnosti.Month==DateTime.Now.Month&&x.VrijemeAktivnosti.Year==DateTime.Now.Year)
                    {
                        sum += x.aktivnost;
                        br++;
                    }
                if (sum != 0)
                    return sum / br;
                else
                    return 0;
            }
        }

        public static double ProsjecnaAktivnostSedmicna
        {
            get
            {
                double sum = 0;int br = 0;
                var cal = CultureInfo.CurrentCulture.Calendar;
                
                foreach (var x in aktivnosti)
                {
                    if(cal.GetWeekOfYear(x.VrijemeAktivnosti,CalendarWeekRule.FirstDay,DayOfWeek.Monday)== cal.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) && x.VrijemeAktivnosti.Year==DateTime.Now.Year)
                    {
                        sum += x.aktivnost;
                        br++;
                    }
                }
                if (sum != 0)
                    return sum / br;
                else
                    return 0;
            }
        }

      








    }
}
