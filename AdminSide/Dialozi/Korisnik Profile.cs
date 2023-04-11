using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSide
{
    public partial class Korisnik_Profile : Form
    {
        private Korisnik k;
        private Loginkorisnika l;
        public Korisnik_Profile(Korisnik k, Loginkorisnika l)
        {
            InitializeComponent();
            this.k = k;
            this.l = l;
            InitializeLabel();
            IscrtajGrafTezina();
            IscrajGrafAktivnost();

            //
            bunifuElipse1.ApplyElipse(verLbl, 15);
            bunifuElipse1.ApplyElipse(panel1, 15);
            bunifuElipse1.ApplyElipse(panel2, 15);
            bunifuElipse1.ApplyElipse(progBtn, 15);
            bunifuElipse1.ApplyElipse(panel3, 15);
            bunifuElipse1.ApplyElipse(panel4, 15);
        }

        //postavljamo labele picture box na vrijednosti
        //koje smo dobili iz konstruktora odnosno korisnika
        //kojeg zelimo prikazati
        private void InitializeLabel()
        {
            imeLbl.Text = k.Ime;
            preLbl.Text = k.Prezime;
            fulLbl.Text = k.Full_Name;
            polLbl.Text = k.Gender.ToString();
            godLbl.Text = k.Godine.ToString();
            emailLbl.Text = l.Email;
            nivoLbl.Text = k.Nivo_Spreme.ToString();
            visLbl.Text = k.Visina.ToString();
            tezLbl.Text = k.ListaVaganje.Last().tezina.ToString();
            if(l.IsVerified)
            {
                verLbl.Text = "Verifikovan";
                verLbl.BackColor = Color.FromArgb(106, 182, 51);
            }
            else
            {
                verLbl.Text = "Nije Verifikovan";
                verLbl.BackColor = Color.FromArgb(201, 48, 44);
            }
            if (k.Gender == Korisnik.Pol.Muski)
                bunifuPictureBox1.Image = Resursi.musko;
            else
                bunifuPictureBox1.Image = Resursi.zensko;
        }

        //zatvaramo formu
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Bunifu.DataViz.WinForms.DataPoint dataPoint;
        private void IscrtajGrafTezina()
        {
            dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            foreach(var x in k.ListaVaganje)
            {
                dataPoint.addLabely(x.datum_vaganja.ToShortDateString(), x.tezina);
            }
            canvas.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.FromArgb(86, 103, 135));
            bunifuDataViz1.Render(canvas);
        }
        
        private void IscrajGrafAktivnost()
        {
            dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            List<Korisnik.Aktivnost> aktivnosts = KorisnikDMS.UcitajAktivnost(k.ID);

            
            foreach(var x in aktivnosts)
            {
                dataPoint.addLabely(x.VrijemeAktivnosti.ToShortDateString(), x.aktivnost);
            }
            canvas.addData(dataPoint);
            bunifuDataViz2.Render(canvas);
        }

        //funkcije koje omogucavaju pomjeranje forme
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void PlayerDialog_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void PlayerDialog_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void PlayerDialog_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
