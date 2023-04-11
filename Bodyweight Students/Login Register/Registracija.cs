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
using System.Text.RegularExpressions;

namespace Bodyweight_Students
{
    public partial class Registracija : Form
    {
        LoginForm log;
        string ime="", prezime="",email="",sifra1="",sifra2="";
        int godine=0, visina=0, tezina=0;
        Korisnik.Spremnost? nivoSpreme=null;
        Korisnik.Pol pol;

        Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
   

        public Registracija(LoginForm l)
        {
            this.log = l;
            InitializeComponent();
            bunifuFormFadeTransition1.ShowAsyc(this);

            bunifuElipse1.ApplyElipse(signUpBtn, 15);
            bunifuElipse1.ApplyElipse(errorLabel, 15);
            errorLabel.Hide();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Dispose();
            
        }


        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text != "Enter name")
            {
                if(nameTxt.Text.Any(char.IsDigit))
                {
                    errorLabel.Text = "Molimo vas da unesete samo slova";
                    nameTxt.Focus();
                    nameTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                {
                    nameTxt.BorderColorFocused = Color.FromArgb(81,85,123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    ime = nameTxt.Text;
                }
            }
        }

        private void surTxt_Leave(object sender, EventArgs e)
        {
            if (surTxt.Text != "Enter surname")
            {
                if (surTxt.Text.Any(char.IsDigit))
                {
                    errorLabel.Text = "Molimo vas da unesete samo slova";
                    surTxt.Focus();
                    surTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                {
                    surTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    prezime = surTxt.Text;
                }
            }
        }

        //kada izadjemo iz textboxa prvo provjerimo da li unijet broj ako jeste
        //prikazujemo error i izlazimo iz fje
        //kada smo provjerili pomenuto ostao nam je jos overflow error
        //ako broj ne mozemo parse znaci da je prevelik i izbacujemo gresku
        //ako je i ovo ispunjeno gledamo opseg izmedju 12 i 65
        //ako su svi uslovi ispunjeni godine se dodjeljuju
        //da je radjeno preko try catch kod bi bio duplo manji
        private void ageTxt_Leave(object sender, EventArgs e)
        {
            if (ageTxt.Text != "Enter age")
            {
                if (ageTxt.Text.Any(char.IsLetter))
                {
                    errorLabel.Text = "Molimo vas da unesete samo brojeve";
                    ageTxt.Focus();
                    ageTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    return;
                }
                else
                {
                    ageTxt.BorderColorFocused  = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }

                int temp;
                bool status = int.TryParse(ageTxt.Text, out temp);

                if (status==false)
                {
                    errorLabel.Text = "Molimo vas u godine unesete u opsegu od 12 do 65";
                    ageTxt.Focus();
                    ageTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    return;
                }
                else
                {
                    ageTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                if(temp<12||temp>65)
                {
                    errorLabel.Text = "Molimo vas u godine unesete u opsegu od 12 do 65";
                    ageTxt.Focus();
                    ageTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                {
                    ageTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    godine = temp;
                }
            }
        }

        //provjera kao i kod godina samo sto ovdje provjeravamo da ne bude kilaza negativna
        private void tezinaTxt_Leave(object sender, EventArgs e)
        {
            if (tezinaTxt.Text != "Enter weight")
            {
                if (tezinaTxt.Text.Any(char.IsLetter))
                {
                    errorLabel.Text = "Molimo vas da unesete samo brojeve";
                    tezinaTxt.Focus();
                    tezinaTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    return;
                }
                else
                {
                    tezinaTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }

                int temp;
                bool status = int.TryParse(tezinaTxt.Text, out temp);

                if (status == false||temp<0)
                {
                    errorLabel.Text = "Molimo vas da unesete realnu tezinu";
                    tezinaTxt.Focus();
                    tezinaTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    return;
                }
                else
                {
                    tezinaTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    tezina = temp;
                }
            }
        }

        //isto kao i kod godina samo provjeravamo da kilaza ne bude ista
        private void visTxt_Leave(object sender, EventArgs e)
        {

            if (visTxt.Text != "Enter height")
            {
                if (visTxt.Text.Any(char.IsLetter))
                {
                    errorLabel.Text = "Molimo vas da unesete samo brojeve";
                    visTxt.Focus();
                    visTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    return;
                }
                else
                {
                    tezinaTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }

                int temp;
                bool status = int.TryParse(visTxt.Text, out temp);

                if (status == false || temp < 0)
                {
                    errorLabel.Text = "Molimo vas da unesete realnu visinu";
                    visTxt.Focus();
                    visTxt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    return;
                }
                else
                {
                    visTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    visina = temp;
                }
            }
        }
        //provjeravamo da li je format uredan i da li je vec registovan
        //ako jeste ispisuju se greske
        private void emailTxt_Leave(object sender, EventArgs e)
        {
            string validationPatern = ConfigurationManager.AppSettings["regexPatern"];
            if (emailTxt.Text != "Enter email")
            {
                if (!Regex.IsMatch(emailTxt.Text, validationPatern))
                {
                    emailTxt.Focus();
                    emailTxt.BorderColorFocused = Color.Red;
                    errorLabel.Text = "Pogresan format email-a";
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else if (KorisnikDMS.EmailPostoji(emailTxt.Text))
                {
                    emailTxt.Focus();
                    emailTxt.BorderColorFocused = Color.Red;
                    errorLabel.Text = "Unijeti email je vec registrovan";
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);

                }
                else
                {
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    emailTxt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    email = emailTxt.Text;

                }
            }
        }
        //provjera duzine sifre
        private void pass1Txt_Leave(object sender, EventArgs e)
        {
            if (pass1Txt.Text != "Password")
            {
                if (pass1Txt.Text.Length < 8)
                {
                    pass1Txt.Focus();
                    errorLabel.Text = "Lozinka mora da ima vise od 8 karaktera";
                    pass1Txt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                {
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    pass1Txt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    sifra1 = pass1Txt.Text;
                }
            }
        }
        //provjera duzine sifre
        private void pass2Txt_Leave(object sender, EventArgs e)
        {
            if (pass2Txt.Text != "Password")
            {
                if (pass2Txt.Text.Length < 8)
                {
                    pass2Txt.Focus();
                    errorLabel.Text = "Lozinka mora da ima vise od 8 karaktera";
                    pass2Txt.BorderColorFocused = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
                else
                {
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    pass2Txt.BorderColorFocused = Color.FromArgb(81, 85, 123);
                    sifra2 = pass1Txt.Text;
                }
            }
        }
        //kada god promjenimo index izabrali smo promjenu
        private void nivoSpremeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(nivoSpremeCombo.Text!="Choose here")
            {
                nivoSpreme = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), nivoSpremeCombo.Text);
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            pol = (muskoRb.Checked) ? Korisnik.Pol.Muski : Korisnik.Pol.Zenski;
            if (ime == "" || prezime == "" || godine == 0 || tezina == 0 || visina == 0 ||
                email == "" || sifra1 == "" || sifra1 == ""||nivoSpreme==null)
            {
                errorLabel.Text = "Sva polja moraju biti popunjena";
                transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);

            }
            else
            {
                transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                if (sifra1 == sifra2)
                {
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    pass2Txt.BorderColorIdle= Color.FromArgb(81, 85, 123);
                    pass2Txt.BorderColorIdle= Color.FromArgb(81, 85, 123);

                    Korisnik.Vaga vaganje = new Korisnik.Vaga();
                    vaganje.tezina = tezina;
                    vaganje.datum_vaganja = DateTime.Now;
                    Korisnik novi = new Korisnik(ime, prezime, godine, nivoSpreme, pol, vaganje, visina, DateTime.Now);
                    KorisnikDMS.DodajKorisnika(novi);
                    Loginkorisnika logNovi = new Loginkorisnika(email, sifra1, false, novi.ID);
                    KorisnikDMS.DodajLogin(logNovi);
                    MessageBox.Show("Registraciju uspjesna!!");
                    this.Hide();
                    log.Show();
                    this.Close();
                }
                else
                {
                    errorLabel.Text = "Lozinke se ne poklapaju";
                    pass1Txt.BorderColorIdle = Color.Red;
                    pass2Txt.BorderColorIdle = Color.Red;
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);

                }
            }
            
        }

        private void email_txt_KeyDown(object sender, KeyEventArgs e)
        {
            Bunifu.Framework.UI.BunifuMetroTextbox txt = (Bunifu.Framework.UI.BunifuMetroTextbox)sender;
            if (e.KeyCode == Keys.Down)
                this.SelectNextControl((Control)sender, true, true, true, true);
            if (e.KeyCode == Keys.Up)
                this.SelectNextControl((Control)sender, false, true, true, true);

        }







    }
}
