using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;


namespace Bodyweight_Students
{
    //posto imamo mnogo komunikacija sa bazom podataka koja moze da bude ogromna
    //funkcije bi se trebale pozivati u zasebnim nitima ili uz pomoc backgroud workera
    public partial class LoginForm : Form
    {
        //temp promjenljive za ocitavanje iz textboxa
        string email, password;

        public LoginForm()
        {
            InitializeComponent();
            
        }

        //na pocetku citamo txt file koji se nalazi u path gdje je i exe file
        //ako se nalazi email u njemu citamo ga i aktiviramo checkbox
        //citamo preko streamreader samo prvu liniju koja nam treba
        //ako imamo email prebacuje se automatski na password
        private void Login_Load(object sender, EventArgs e)
        {
           
            string path = AppDomain.CurrentDomain.BaseDirectory + "EmailSacuvan.txt";
            string status;
            using (StreamReader reader = new StreamReader(path))
            {
                status = reader.ReadLine();
            }
            if (!string.IsNullOrEmpty(status))
            {
                email_txt.Text = status;
                email = status;
                this.SelectNextControl(email_txt, true, true, true, true);
            }
            else
                rem_checkBox.Checked = false;

            //error label na pocetku je hide
            errorLabel.Hide();
            //dugme i error label postaju elipse
            bunifuElipse1.ApplyElipse(signInBtn, 15);
            bunifuElipse1.ApplyElipse(errorLabel, 15);
        }

        //kada se promjeni checkbox on treba da upise ili izbrise email iz text fajla
        //koji se nalazi gdje i exe file, brisemo ga na glup nacin to jeste kreiranjem nove
        //veze ali to jedini ucinkoviti nacin
        private void rem_checkBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "EmailSacuvan.txt";
            if (rem_checkBox.Checked)
            {
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    { writer.WriteLine(email); }
                }
            }
            else
            {
                using (FileStream stream = new FileStream(path, FileMode.Create)) { }
            }
        }


        //unos i provjera lozinke kad izadjemo iz textboxa
        //ako je unos nepravilan izbacuje se errorProvider
        private void password_txt_Leave(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            if (password_txt.Text!="Password")
            {
                password = password_txt.Text;
                if (password.Length < 8)
                {
                    password_txt.Focus();
                    errorLabel.Text = "Lozinka mora da ima vise od 8 karaktera";
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
            
        }

        //unos i provjera email kad izadjemo iz textboxa
        //ako je unos nepravilan izbacuje se errorProvider
        private void email_txt_Leave(object sender, EventArgs e)
        {
            string validationPatern = ConfigurationManager.AppSettings["regexPatern"];
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            if (email_txt.Text != "Email")
            {
                email = email_txt.Text;
                if (!Regex.IsMatch(email, validationPatern))
                {
                    email_txt.Focus();
                    errorLabel.Text = "Pogresan format email-a";
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
        }

        //metoda za textboxove da mozemo preko strelica prelaziti iz jedno 
        //u drugi funkcija radi pomocu tab indexa
        private void email_txt_KeyDown(object sender, KeyEventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox txt = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            if (e.KeyCode == Keys.Down)
                this.SelectNextControl((Control)sender, true, true, true, true);
            if (e.KeyCode == Keys.Up)
                this.SelectNextControl((Control)sender, false, true, true, true);
   
        }

        //ucitane email i password provjeravamo u bazi podataka da li se poklapaju
        //ako se poklapaju citamo korisnika i njegov login pomocu primarnog kljuca kojeg smo dobili iz baze
        //provjeravamo da li je korisnik verifikovan ako jeste ulazi u aplikaciju ako nije
        //otvara mu se prozor za aktivaciju
        //na osnovu ranka korisnika otvara mu se odgovarajuci prozor(member,admin)
        private void signInBtn_Click(object sender, EventArgs e)
        {
            Korisnik kor = null; Loginkorisnika log = null;
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            int korisnikId=KorisnikDMS.EmailPasswordLogin(email, password);
            if(korisnikId!=-1)
            {
                transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                log=KorisnikDMS.VratiLogin(korisnikId);
                kor=KorisnikDMS.VratiKorisnika(korisnikId);
                if(log.Password=="Reset")
                {
                    ResetPass reset = new ResetPass(this, log);
                    this.Hide();
                    reset.ShowDialog();
                    this.Hide();
                }
                if (log.IsVerified)
                {
                    MainForm main = new MainForm(kor,this);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    verCode novi = new verCode(log,this);
                    this.Hide();
                    novi.Show();
                    
                }
            }
            else
            {
                errorLabel.Text = "Ne mozemo pronaci nalog sa ovim email i password";
                transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }

        }

        
        

        private void ResendBtn_Click(object sender, EventArgs e)
        {
            ForgetPassPocetak forget = new ForgetPassPocetak(this);
            this.Hide();
            forget.Show();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Registracija novi = new Registracija(this);
            this.Hide();
            novi.Show();
        }



        //dugme za gasenje aplikacije 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
