using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSide
{
    

    public class Vjezba
    {
        public enum TipVjezbe { kardio,Bodyweight, Bodybuilding, Weighted_Calisthenics };//......
        public enum DioTijela { Ruke,Ramena,Ledja,Noge,Prsa,Stomak,UPB};//.....

        private int id=-1;
        private string naziv="";
        private string ytCode="";
        private string opis="";
        private Korisnik.Spremnost ?tezinaVjezbe=null;
        private TipVjezbe ?tipVjezbe=null;
        private DioTijela ?dioTijela=null;
        

        public Vjezba() { }
        //kontruktor koji se koristi za unos nove vjezbe u bazu podataka
        public Vjezba(string naziv, string ytCode, Korisnik.Spremnost tezinaVjezbe,string opis,TipVjezbe tipVjezbe,DioTijela dioTijela)
        {
            this.naziv = naziv;
            this.ytCode = ytCode;
            this.tezinaVjezbe = tezinaVjezbe;
            this.opis = opis;
            this.tipVjezbe = tipVjezbe;
            this.dioTijela = dioTijela;
        }
        //konstruktor za citanje iz baze podataka
        public Vjezba(int id, string naziv, string ytCode, Korisnik.Spremnost tezinaVjezbe,string opis,TipVjezbe tipVjezbe, DioTijela dioTijela)
        {
            this.id = id;
            this.naziv = naziv;
            this.ytCode = ytCode;
            this.tezinaVjezbe = tezinaVjezbe;
            this.opis = opis;
            this.tipVjezbe = tipVjezbe;
            this.dioTijela = dioTijela;
        }

        //geteri i seteri na privatna polja
        public int Id { get{return id;} set {id = value;} }
        public string Naziv { get {return naziv;} set { naziv = value; } }
        public string YtCode { get {return ytCode;}set { ytCode = value; } }
        public string Opis { get  {return opis; }set { opis = value; } }
        public Korisnik.Spremnost ?TezinaVjezbe { get{return (Korisnik.Spremnost)tezinaVjezbe;}set { tezinaVjezbe = value; } }
        public TipVjezbe ?Tip_Vjezbe { get {return (TipVjezbe)tipVjezbe;}set { tipVjezbe = value; } }
        public DioTijela ?Dio_Tijela { get { return (DioTijela)dioTijela; }set { dioTijela = value; } }
    }

    public class VjezbaComparater : IEqualityComparer<Vjezba>
    {
        public bool Equals(Vjezba x, Vjezba y)
        {
            if (x.Naziv.ToUpper() == y.Naziv.ToUpper())
                return true;
            return false;
        }

        public int GetHashCode(Vjezba obj)
        {
            return obj.GetHashCode();
        }
    }
}
