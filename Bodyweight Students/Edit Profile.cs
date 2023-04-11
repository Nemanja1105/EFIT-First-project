using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodyweight_Students
{
    public partial class Edit_Profile : Form
    {
        private Korisnik k;
        private Loginkorisnika l;
        public Korisnik K { set { k = value; InicijalizujKomponente(); } }
        public Loginkorisnika L { set { l = value; InicijalizujLoginKomponente(); } }
        public Edit_Profile()
        {
            InitializeComponent();
            bunifuElipse1.ApplyElipse(verLbl, 15);
            bunifuElipse1.ApplyElipse(panel1, 15);
            bunifuElipse1.ApplyElipse(panel2, 15);
            bunifuElipse1.ApplyElipse(panel3, 15);
            bunifuElipse1.ApplyElipse(izmjeniBtn, 15);
            bunifuElipse1.ApplyElipse(deakBtn, 15);
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
        //inicijalizujemo labele koje su vezane za login korisnika
        private void InicijalizujLoginKomponente()
        {
            if (l.IsVerified)
            {
                verLbl.Text = "Verifikovan";
                verLbl.BackColor = Color.FromArgb(106, 182, 51);
            }
            else
            {
                verLbl.Text = "Nije Verifikovan";
                verLbl.BackColor = Color.FromArgb(201, 48, 44);
            }
            emailTxt.Text=l.Email;
        }

        //funkcija inicijalizuje komponente koje su vezane za korisnika
        private void InicijalizujKomponente()
        {
            fulLbl.Text = k.Full_Name;
            imeTxt.Text = k.Ime;
            PrezimeTxt.Text = k.Prezime;
            polTxt.Text = k.Gender.ToString();
            godineTxt.Text = k.Godine.ToString();
            nivoCombo.Text = k.Nivo_Spreme.ToString();
            visinaTxt.Text = k.Visina.ToString();
            if(k.ListaVaganje.Count>0)
                tezinaTxt.Text = k.ListaVaganje.Last().tezina.ToString();
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        //funkcija nas vraca na main formu
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //funkcija za izmjenu lozinke
        //ako je trenutna lozinka tacna i ako nova lozinka ispucanja uslove
        //koji su definisani ona se mjenjaju funkcijom
        //ako je doslo do greska ispisuje se dialog za upozorenje korisnika
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (trenutnaSifTxt.Text == l.Password && !string.IsNullOrEmpty(novaTxt.Text)&&novaTxt.Text.Length>=8)
            {
                l.Password = novaTxt.Text;
                KorisnikDMS.PromjeniSifruLogin(l);
                Dialog del = new Dialog("Obavjestenje", "Vasa sifra je uspjesno promjenjena!!");
                del.ShowDialog();
            }
            else
            {
                Dialog del = new Dialog("Obavjestenje", "Greska prilikom promjene sifre!!");
                del.ShowDialog();
            }
        }

        //funkcija za izmjenu pojedinih polja korisnika
        //prije promjene vrsi se promjena validnosti novih parametara
        //poslije toga vrsi update paramatara u bazi
        //ako je doslo do greska ispisuje se dialog sa upozorenjem za korisnika
        private void izmjeniBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(godineTxt.Text)&&godineTxt.Text.All(char.IsDigit)&&!string.IsNullOrEmpty(visinaTxt.Text)
                &&visinaTxt.Text.All(char.IsDigit))
            {
                int visina = Convert.ToInt32(visinaTxt.Text);
                int godine = Convert.ToInt32(godineTxt.Text);
                k.Visina = visina;
                k.Godine = godine;
                k.Nivo_Spreme = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), nivoCombo.Text);
                KorisnikDMS.UpdateKorisnik(k);
                Dialog del = new Dialog("Obavjestenje", "Promjene na nalogu uspjesno obavljene!!");
                del.ShowDialog();
            }
            else
            {
                Dialog del = new Dialog("Obavjestenje", "Greska prilikom promjena na nalogu!!");
                del.ShowDialog();
            }
        }
        //funkcija za potpuno brisanje naseg naloga
        private void deakBtn_Click(object sender, EventArgs e)
        {
            DelDialog del = new DelDialog("Brisanje", "Vas nalog ce biti trajno obrisan!!");
            if(del.ShowDialog()==DialogResult.OK)
            {
                KorisnikDMS.BrisiKorisnika(k);
                Application.Exit();
            }
        }
    }
}
