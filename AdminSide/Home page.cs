using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSide
{
    public partial class Home_page : UserControl
    {
        private static Home_page instance=null;
        public static Home_page Instance
        {
            get
            {
                if (instance == null)
                    return new Home_page();
                else
                    return instance;
            }
        }

        public Home_page()
        {
            InitializeComponent();
        }

        private void Home_page_Load(object sender, EventArgs e)
        {
            bunifuElipse1.ApplyElipse(panel4, 10);
            bunifuElipse1.ApplyElipse(panel5, 10);
            bunifuElipse1.ApplyElipse(panel6, 10);
            bunifuElipse1.ApplyElipse(panel7, 10);
            SetLabele();
            SetProgress();
            SetProcess();
            NacratajPocetak();
            NacrtajVerUn();
        }

        //funkcija crta grafik koji prikazuje broj verifikovanih i neverifikovanih
        //broj dobijamo iz klase proracun
        Bunifu.DataViz.WinForms.DataPoint dataPoint;
        private void NacrtajVerUn()
        {
            dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_pie);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            bunifuDataViz2.colorSet.Add(Color.FromArgb(33, 150, 243));
            bunifuDataViz2.colorSet.Add(Color.FromArgb(239, 79, 76));
            dataPoint.addLabely("VER", Proracuni.Verifikovani);
            dataPoint.addLabely("UNVER", Proracuni.NisuVerifikovani);
            canvas.addData(dataPoint);
            bunifuDataViz2.Render(canvas);
            verLbl.Text = Proracuni.Verifikovani.ToString();
            unverLbl.Text = Proracuni.NisuVerifikovani.ToString();

        }

        //kada se home otvara prvo se isrctava novi korisnici sedmicno
        //posto ni jedan radio button nije selectovan na pocetku
        private void NacratajPocetak()
        {
            dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea);
            bunifuDataViz1.colorSet.Add(Color.FromArgb(63, 81, 181));
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            foreach (var x in Proracuni.NoviKorisniciSedmica)
                dataPoint.addLabely(x.Key.ToShortDateString(), x.Value);
            canvas.addData(dataPoint);
            bunifuDataViz1.Render(canvas);
        }

        //funkcija crta graf novih korisnika sedmicno
        //kad je radio button checked
        private void bunifuRadioButton1_Click(object sender, EventArgs e)
        {
            if(bunifuRadioButton1.Checked)
            {
                dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea);
                bunifuDataViz1.colorSet.Add(Color.FromArgb(63, 81, 181));
                Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
                foreach (var x in Proracuni.NoviKorisniciSedmica)
                    dataPoint.addLabely(x.Key.ToShortDateString(), x.Value);
                canvas.addData(dataPoint);
                bunifuDataViz1.Render(canvas);
            }
        }

        //funkcija crta graf novi korisnica mjesec
        //kada je radio button 2 checked
        private void bunifuRadioButton2_Click(object sender, EventArgs e)
        {
            if (bunifuRadioButton2.Checked)
            {
                dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea);
                bunifuDataViz1.colorSet.Add(Color.FromArgb(63, 81, 181));
                Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
                foreach (var x in Proracuni.NoviKorisniciMjesec)
                    dataPoint.addLabely(x.Key.ToShortDateString(), x.Value);
                canvas.addData(dataPoint);
                bunifuDataViz1.Render(canvas);
            }
        }

        //u progress bar unosi kolika je prosjecna aktivnost sedmicna i mjesecna
        //podatke dobija iz klase proracuni
        private void SetProgress()
        {
            List<Korisnik.Aktivnost> aktivnosti = KorisnikDMS.UcitajSveAktivnosti();
            progress1.Value =(int) Proracuni.ProsjecnaAktivnostSedmicna;
            progress2.Value = (int)Proracuni.ProsjecnaAktivnostMjesecna;
            progress2.SuperScriptText = "m";
            progress1.SuperScriptText = "m";
            progress2.SuperScriptMargin=new Padding(-3, 50, 0, 0);
            progress1.SuperScriptMargin = new Padding(-3, 50, 0, 0);
            
        }
        //u proccess bar unosi broj pocetnih srednjih i naprednih korisnika
        //podatke dobija iz klase proracuni
        private void SetProcess()
        {
            pocProg.MaximumValue = sreProg.MaximumValue = napProg.MaximumValue = Proracuni.UkupnoKorisnika;
            pocProg.Value = Proracuni.BrojPocetnih;
            pocLbl.Text = Proracuni.BrojPocetnih.ToString();
            sreProg.Value = Proracuni.BrojSrednjih;
            sreLbl.Text = Proracuni.BrojSrednjih.ToString();
            napProg.Value = Proracuni.BrojNaprednih;
            napLbl.Text = Proracuni.BrojNaprednih.ToString();
        }
        //stavlja vrijednosti pocetnih labela sa podacima iz klase proracun
        private void SetLabele()
        {
            danLbl.Text = Proracuni.PosjeteDanas.ToString();
            korLbl.Text = Proracuni.UkupnoKorisnika.ToString();
            vjeLbl.Text = Proracuni.UkupnoVjezbi.ToString();
        }

        
    }
}
