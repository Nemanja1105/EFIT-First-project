using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bodyweight_Students
{
    public class Korisnik
    {
      //Enumeracija fizicke spreme kod korisnika//
        public enum Spremnost 
        {Pocetni,Srednji,Napredni};
        
        //Enumeracija pola kod korisnika//
        public enum Pol
        {Muski=1,Zenski=0};

        //struktura za varijaciju tezine u zavisnosti od datuma vaganja//
        public struct Vaga
        {
            public int tezina;
            public DateTime datum_vaganja;
        }

        public struct Slike
        {
            public Image slika;
            public DateTime datum;
        }

        public struct Aktivnost
        {
            public int aktivnost;
            public DateTime VrijemeAktivnosti;
        }

        //Polja za registraciju korisnika//
        private int Korisnik_ID;
        private string ime;
        private string prezime;
        private int godine;
        private Spremnost? nivo_spreme;
        private Pol? pol;
        private List<Vaga> vaganje;
        private int visina;
        private DateTime? datum_prijave;

        //Podrazumijevani konstruktor(inicijalizacija parametara na empty,0 i eventualno null/)
        public Korisnik()
        {
            ime = ""; prezime = ""; godine =0;
            nivo_spreme = null; pol = null;
            visina = 0;
            datum_prijave = null;
            vaganje=new List<Vaga>();

        }
        //Konstruktor sa parametrima za registrovanog korisnika//
        public Korisnik(string ime, string prezime, int godine, Spremnost? nivo_spreme, Pol? pol,Vaga vaganje,int visina, DateTime? datum_prijave)
        {

            this.ime = ime; this.prezime = prezime;
            this.godine = godine; this.nivo_spreme = nivo_spreme;
            this.pol = pol;
            this.visina = visina; this.datum_prijave = datum_prijave;
            this.vaganje = new List<Vaga>();
            this.vaganje.Add(vaganje);
            
        }
        //konstruktor za citanje iz baze podataka
        public Korisnik(int korisnik_ID, string ime, string prezime, int godine, Spremnost? nivo_spreme, Pol? pol, int visina, DateTime? datum_prijave)
        {
            this.Korisnik_ID = korisnik_ID;
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
            this.nivo_spreme = nivo_spreme;
            this.pol = pol;
            this.visina = visina;
            this.datum_prijave = datum_prijave;
            this.vaganje = new List<Vaga>();

        }

        //getter-i & setter-i za private polja//
        public string Ime { get { return this.ime; }}
        public string Prezime{ get {return this.prezime;}}
        public string Full_Name { get { return this.ime + " " + this.prezime; } }
        public int Godine { get {  return this.godine; }set { godine = value; } }
        public Spremnost? Nivo_Spreme { get { return this.nivo_spreme; } set { this.nivo_spreme = value; } }
        public List<Vaga> ListaVaganje { get { return this.vaganje; } }
        public Pol? Gender { get { return this.pol; } }
        public int Visina { get { return this.visina; } set { visina = value; } }
        public DateTime? Datum_prijave { get { return this.datum_prijave; } }
        public int ID { get { return this.Korisnik_ID; } set { this.Korisnik_ID = value; } }

        //funkcija za dodavanje kilaze u listu
        public void DodajVaganje(Vaga v) {vaganje.Add(v); }
               


    }
}
