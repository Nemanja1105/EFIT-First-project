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
    public partial class ForgotVerCode : Form
    {
        Loginkorisnika log;
        LoginForm stara;

        //konstruktor
        public ForgotVerCode(Loginkorisnika l,LoginForm f)
        {
            InitializeComponent();

            this.log = l;
            this.stara = f;
            bunifuElipse1.ApplyElipse(subBtn, 15);
            bunifuElipse1.ApplyElipse(errorLabel, 15);

            bunifuFormFadeTransition1.ShowAsyc(this);
            errorLabel.Hide();

        }
        //kada se dugme pritisne generise se novi kod
        //i salje na email
        private void ResendBtn_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(delegate () { log.PosaljiKodNaMail(); });
            T1.Start();
        }

        //ako je kod jednak generisanim otvara se forma za reset sifre
        private void subBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            string text = codeTxt.Text;
            if(text!="Enter here")
            {
                if(text==log.Kod)
                {
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    ResetPass reset = new ResetPass(stara, log);
                    reset.Show();
                    this.Hide();
                }
                else
                {
                    errorLabel.Text = "Unijeti kod se ne poklapa! Pokusajte ponovo.";
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }
            }
        }
        //back button na login form
        private void backBtn_Click(object sender, EventArgs e)
        {
            stara.Show();
            this.Close();
        }
    }
}
