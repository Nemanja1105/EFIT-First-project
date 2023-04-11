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
using System.Text.RegularExpressions;
using System.Configuration;

namespace Bodyweight_Students
{
    public partial class ForgetPassPocetak : Form
    {
        string email;
        LoginForm log;
        public ForgetPassPocetak(LoginForm l)
        {
            InitializeComponent();
            this.log = l;
            bunifuElipse1.ApplyElipse(subBtn, 15);
            bunifuElipse1.ApplyElipse(errorLabel, 15);
            errorLabel.Hide();
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

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

        private void subBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            if (!KorisnikDMS.EmailPostoji(email))
            {
                email_txt.Focus();
                errorLabel.Text = "Ne mozemo pronaci nalog sa ovim email-om";
                transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
            else
            {
                transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                Loginkorisnika log1 = new Loginkorisnika();
                
                log1.Email = email;
                Thread T1 = new Thread(delegate () { log1.PosaljiKodNaMail(); });
                T1.Start();
                ForgotVerCode novi = new ForgotVerCode(log1, log);
                novi.Show();
                this.Close();
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Close();
        }
    }
}
