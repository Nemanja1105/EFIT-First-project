using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using LiveCharts.Configurations;
using System.Media;

namespace Bodyweight_Students
{
    public partial class TvojProgress : UserControl
    {
        private Korisnik k;
        public Korisnik K { set { k = value; IscrtajGrafTezina(); IscrtajGrafAktivnost(); } }
        public TvojProgress()
        {
            InitializeComponent();
           // this.k = k;
            bunifuElipse1.ApplyElipse(panel1, 10);
            bunifuElipse1.ApplyElipse(panel2, 10);
            bunifuElipse1.ApplyElipse(panel3, 10);
            bunifuElipse1.ApplyElipse(dodBtn, 10);
            bunifuElipse1.ApplyElipse(novBtn, 10);
            bunifuElipse1.ApplyElipse(pogledajBtn, 10);
            //IscrtajGrafTezina();
            //IscrtajGrafAktivnost();
            
        }

       //crtamo graf na osnovu tezina iz baze podataka
       //posto mi na grafu ne mozemo prikazati datum
       //moramo ga konvertovati,pa tako i za ispis moramo ga
       //opet dekriptovati da bi znali ko je je datum u pitanju
        private void IscrtajGrafTezina()
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.Hide();
            cartesianChart1.Show();
            var dayConfig = Mappers.Xy<DateTimePoint>()
  .X(dateModel => dateModel.DateTime.Ticks / (TimeSpan.FromDays(1).Ticks))
  .Y(dateModel => dateModel.Value);
            ChartValues<DateTimePoint> values = new ChartValues<DateTimePoint>();
             foreach (var x in k.ListaVaganje)
             {
                 values.Add(new DateTimePoint(x.datum_vaganja,x.tezina));
             }
            cartesianChart1.Series = new SeriesCollection(dayConfig) { new LineSeries()
            { Title="Tezina",Values = values,PointGeometrySize=20} };
            cartesianChart1.AxisX.Add(new Axis
            {
                LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("d")
        });
           cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString() + "kg"
            }); 
        }

        //crtamo graf na osnovu aktivnost iz baze podataka
        //posto mi na grafu ne mozemo prikazati datum
        //moramo ga konvertovati,pa tako i za ispis moramo ga
        //opet dekriptovati da bi znali ko je je datum u pitanju
        private void IscrtajGrafAktivnost()
        {
            
            cartesianChart2.Hide();
            cartesianChart2.Show();
            var dayConfig = Mappers.Xy<DateTimePoint>()
            .X(dateModel => dateModel.DateTime.Ticks / TimeSpan.FromDays(1).Ticks)
            .Y(dateModel => dateModel.Value);

            ChartValues<DateTimePoint> values = new ChartValues<DateTimePoint>();
            foreach (var x in KorisnikDMS.UcitajAktivnost(k.ID))
            {
                values.Add(new DateTimePoint(x.VrijemeAktivnosti,x.aktivnost));
            }
            cartesianChart2.Series = new SeriesCollection(dayConfig) { new LineSeries() { Title = "Aktivnost", Values = values, PointGeometrySize = 20
            ,Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(81, 85, 123)),
            Fill=new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(190, 177, 255))} };
            /*cartesianChart2.AxisX.Add(new Axis
            {
                LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("d")
            });
            cartesianChart2.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString() + "m"
            });*/
            
        }

        //funkcija za dodavanje nove tezine u bazu podataka
        //ucitavamo tezinu i datum vaganja
        //provjeravamo unos ako nije dobro zapis se nece sacuvati
        //i ispisuje se dialog za pogresan unos
        private void dodBtn_Click(object sender, EventArgs e)
        {
            Korisnik.Vaga vaganje = new Korisnik.Vaga();
            vaganje.datum_vaganja = bunifuDatePicker1.Value;
            try
            {
                vaganje.tezina = Convert.ToInt32(tezTxt.Text);
                KorisnikDMS.DodajVaganje(vaganje, k);
                IscrtajGrafTezina();
            }
            catch (Exception ex)
            {
                Dialog nova= new Dialog("Pogresan unos", "Tezina je cjelobrojnog tipa, molimo vas ponovite unos");
                nova.ShowDialog();
                nova.Dispose();
            }
        }

        //funkcija za odabir slike sa racunaru
        //kada se slika izabere sacuvamo njen path
        string path="";
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
                path = dialog.FileName;
        }
        //funkcija za ubacivanje novog progresa(slika)
        //ako slika nije izabrata ispisujemo dialog da nije izabrana
        //ako je sve uredno slike se upload u bazu
        private void novBtn_Click(object sender, EventArgs e)
        {
            Korisnik.Slike slika = new Korisnik.Slike();
            slika.datum = bunifuDatePicker2.Value;
            if (!string.IsNullOrEmpty(path))
            { 
                slika.slika = Image.FromFile(path);
                KorisnikDMS.DodajSliku(slika, k);
                Dialog del = new Dialog("Slika uspjesno opremljena na server", "");
                del.ShowDialog();
                del.Dispose();

            }
            else
            {
                Dialog del = new Dialog("Slika nije izabrana", "Da bi ste dodali novi progres izaberite sliku sa vaseg racunara");
                del.ShowDialog();
                del.Dispose();
            }
            
        }
        //funkcija za prikaz progresa
        private void pogledajBtn_Click(object sender, EventArgs e)
        {
            PrikazProgresa prog = new PrikazProgresa(k.ID);
            prog.ShowDialog();
            prog.Dispose();
        }
    }
}
