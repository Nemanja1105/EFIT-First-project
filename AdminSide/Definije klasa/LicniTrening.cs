using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSide
{
    //dani u sedmici
    public enum DaniSedmica { Ponedeljak, Utorak, Srijeda, Cetvrtak, Petak, Subota, Nedelja };

    //struktra za vjezbu
    public struct VjezbaTreninga
    {
        public Vjezba vjezba;
        public int ponavljanja;
        public int serija;
    }


    public class LicniTrening
    {
        //polja koja opisuje trening
        private int TreningId;
        private string naziv;
        private string opis;
        private DaniSedmica? dan;
        private int KorisnikId;
        List<VjezbaTreninga> vjezbe = new List<VjezbaTreninga>();

        //konstruktor za prvo upisivanje u bazi podataka
        public LicniTrening(string naziv, string opis, DaniSedmica? dan, int korisnikId)
        {
            this.naziv = naziv;
            this.opis = opis;
            this.dan = dan;
            KorisnikId = korisnikId;
        }
        //konstruktor za citanje iz baze podataka
        public LicniTrening(int treningId, string naziv, string opis, DaniSedmica? dan, int korisnikId)
        {
            TreningId = treningId;
            this.naziv = naziv;
            this.opis = opis;
            this.dan = dan;
            KorisnikId = korisnikId;
        }

        public int TreningID { get => TreningId; set => TreningId = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }
        public DaniSedmica? Dan { get => dan; set => dan = value; }
        public int KorisnikID { get => KorisnikId; set => KorisnikId = value; }
        public List<VjezbaTreninga> VjezbeTrening { get => vjezbe;}

        public void DodajVjezbe(VjezbaTreninga v)
        {
            vjezbe.Add(v);
        }
    }
}
