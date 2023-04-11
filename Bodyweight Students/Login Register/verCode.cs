using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bodyweight_Students
{
    public partial class verCode : Form
    {
        Loginkorisnika log;
        LoginForm stara;

        //kada se udje u verification form
        //dobijamo informacije o loginu
        //prikazujemo email u tajnom formatu
        //poslije toga saljemo kod email korisnika
        public verCode(Loginkorisnika l,LoginForm f)
        {
            InitializeComponent();
            this.log = l;
            this.stara = f;

            
            opisLbl.Text += "\n" + tajniString(log.Email);

            //posto slanje emaila trosi dosta vremena
            //pokrenuli smo ga u novoj niti odvojeno od ui niti
            //posto ne vracamo vrijednost koristimo thread
            Thread T1 = new Thread(delegate () { log.PosaljiKodNaMail(); });
            T1.Start();

            errorLbl.Hide();
            bunifuElipse1.ApplyElipse(subBtn, 15);
            bunifuElipse1.ApplyElipse(errorLbl, 15);
        }

        private string tajniString(string email)
        {
            string novi = "";
            novi += email[0];
            int index = email.IndexOf("@");
            for (int i = 1; i < email.Length; i++)
            {
                if (i < index)
                    novi += "*";
                else
                    novi += email[i];
            }
            return novi;
        }
        //ako se vracamo nazad ovaj gasimo stari prikazujemo
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            stara.Show();
            
        }
        //ako se unijeti kod poklapa sa generisanim
        //kodom mijenja se status u bazi i pristupa se dalje aplikaciji
        private void subBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            string text = codeTxt.Text;
            if (text != "Enter here")
            {
                if (text == log.Kod)
                {
                    transition.HideSync(errorLbl, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    log.IsVerified = true;
                    Thread T = new Thread(delegate () { KorisnikDMS.AzurirajVerifikaciju(log); });
                    T.Start();
                    stara.Show();
                    this.Close();
                }
                else
                {
                    errorLbl.Text = "Unijeti kod se ne poklapa! Pokusajte ponovo.";
                    transition.ShowSync(errorLbl, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
            }
        }
        //kada se dugme pritisne generise se novi kod
        //i salje na email
        private void ResendBtn_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(delegate () { log.PosaljiKodNaMail(); });
            T1.Start();
        }

        private void verCode_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
    }
}
