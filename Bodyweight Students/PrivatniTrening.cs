using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodyweight_Students
{
    public partial class PrivatniTrening : UserControl
    {
        private int korisnikId;
        private DaniSedmica dan;
        private LicniTrening l;
        private List<LicniTrening> treninzi = new List<LicniTrening>();
        //prvi dan u sedmici
        private int index = 0;
        private List<string> dani = new List<string> { "Ponedeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota", "Nedelja" };
        public PrivatniTrening(int korisnikId)
        {
            InitializeComponent();
            this.korisnikId = korisnikId;
            bunifuElipse1.ApplyElipse(panel2, 10);
            bunifuElipse1.ApplyElipse(panel3, 10);
            bunifuElipse1.ApplyElipse(panel4, 10);
            bunifuElipse1.ApplyElipse(panel5, 10);
            bunifuElipse1.ApplyElipse(panel6, 10);
            //ucitavamo sve treninge
            UcitajSveTrening();
            //ucitavamo trening za podeljak
            PostaviTrening();
           

        }
        
        //ucitavamo sve treninge za datog korisnika za sve dane
        //za koje postoji trening
        //poslije cemo samo da treninge pretrazujemo po danu
        private void UcitajSveTrening()
        {
            foreach (string x in Enum.GetNames(typeof(DaniSedmica)))
            {
                if(VjezbaDMS.TreningPostoji(korisnikId, (DaniSedmica)Enum.Parse(typeof(DaniSedmica), x)))
                    treninzi.Add(VjezbaDMS.UcitajTrening(korisnikId, (DaniSedmica)Enum.Parse(typeof(DaniSedmica), x)));
            }
                 
        }
        
        //funkcija dinamicki formira duzinu i sirinu labele zavisno od teksta
        private void ScaleFont(Label lab)
        {
            Graphics g = CreateGraphics();
            SizeF nova = g.MeasureString(lab.Text, lab.Font,lab.Width);
            opisLbl.Height = int.Parse(Math.Round(nova.Height+11, 0).ToString());
        }

        //funkcija provjerava da li za dati dan postoji trening
        //pronalazi trening i odredjene komponente inicijalizuju
        //sa vrijednositma ako ne postoji otvara se dialog koji 
        //upozorava korisnika o tome
       private void PostaviTrening()
        {
            if (!treninzi.Exists(p => p.Dan.ToString() == dani[index] && p.KorisnikID == korisnikId))
            {
                Dialog dialog = new Dialog("Trening ne postoji", "Trening dolazi uskoro, za vise informacija javite se treneru");
                dialog.ShowDialog();
                dialog.Dispose();
            }
            else
            {
                l = treninzi.Find(p => p.Dan.ToString() == dani[index] && p.KorisnikID == korisnikId);
                SetujKomponente();
            }
        }

        //setujemo komponente u zavisnoti od treninga
        //ako je naziv odmor komponente su nepoznate
        private void SetujKomponente()
        {
            nazLbl.Text = l.Naziv;
            opisLbl.Text = l.Opis;
            //bolja bi primjena bila upotreba user controle
            //i prosledjivati parametre u kontruktor
            if (l.Naziv != "Odmor")
            {
                vjeLbl1.Text = l.VjezbeTrening[0].vjezba.Naziv;
                vjeLbl2.Text = l.VjezbeTrening[1].vjezba.Naziv;
                vjeLbl3.Text = l.VjezbeTrening[2].vjezba.Naziv;
                vjeLbl4.Text = l.VjezbeTrening[3].vjezba.Naziv;
                vjeLbl5.Text = l.VjezbeTrening[4].vjezba.Naziv;
                pon1.Text = l.VjezbeTrening[0].ponavljanja.ToString();
                pon2.Text = l.VjezbeTrening[1].ponavljanja.ToString();
                pon3.Text = l.VjezbeTrening[2].ponavljanja.ToString();
                pon4.Text = l.VjezbeTrening[3].ponavljanja.ToString();
                pon5.Text = l.VjezbeTrening[4].ponavljanja.ToString();
                ser1.Text = l.VjezbeTrening[0].serija.ToString();
                ser2.Text = l.VjezbeTrening[1].serija.ToString();
                ser3.Text = l.VjezbeTrening[2].serija.ToString();
                ser4.Text = l.VjezbeTrening[3].serija.ToString();
                ser5.Text = l.VjezbeTrening[4].serija.ToString();
               
            }
            else
            {
                vjeLbl1.Text = "Naziv";
                vjeLbl2.Text = "Naziv";
                vjeLbl3.Text = "Naziv";
                vjeLbl4.Text = "Naziv";
                vjeLbl5.Text = "Naziv";
                pon1.Text = "??";
                pon2.Text = "??";
                pon3.Text = "??";
                pon4.Text = "??";
                pon5.Text = "??";
                ser1.Text = "??";
                ser2.Text = "??";
                ser3.Text = "??";
                ser4.Text = "??";
                ser5.Text = "??";
            }
        }
        //strelica desno mijenja treninga unaprijed
        //i poziva funkcija za postavljanje komponenti
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 7)
                index = 0;
            danLbl.Text = dani[index];
            PostaviTrening();
        }

        //strelica lijevo mijenja treninga unazad
        //i poziva funkcija za postavljanje komponenti
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
                index = 6;
            danLbl.Text = dani[index];
            PostaviTrening();
        }

        //funkcija za prikaz vjezbe
        //image button imaju zadnji broj koji predstavnjaju index vjezbe
        //i na osnovu toga prikazujemo odgovarajuci video
        private void PrikaziVjezbu(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton aa = sender as Bunifu.UI.WinForms.BunifuImageButton;
            if (treninzi[index].Naziv != "Odmor")
            {
                VjezbaPrikaz prikaz = new VjezbaPrikaz();
                prikaz.Vj = treninzi[index].VjezbeTrening[Convert.ToInt32(aa.Name.Last().ToString()) - 1].vjezba;
                prikaz.ShowDialog();
                prikaz.Dispose();
            }
            else
            {
                Dialog dialog = new Dialog("Trening ne postoji", "Trening dolazi uskoro, za vise informacija javite se treneru");
                dialog.ShowDialog();
                dialog.Dispose();
            }
        }

        
    }
}
