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
    public partial class ResetPass : Form
    {
        private string prva;
        private string druga;
        private LoginForm l;
        private Loginkorisnika k;

        public ResetPass(LoginForm l,Loginkorisnika k)
        {
            InitializeComponent();
            this.l = l;
            this.k = k;

            bunifuElipse1.ApplyElipse(errorLabel, 15);
            bunifuElipse1.ApplyElipse(subBtn, 15);
            errorLabel.Hide();
        }

        //funkcija za reset passworda
        //funkcija provjerava tacnost lozinke i da li se poklapaju
        private void subBtn_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();
            if (!string.IsNullOrEmpty(prvaTxt.Text)&&!string.IsNullOrEmpty(drugaTxt.Text)&&
                prvaTxt.Text.Length>=8 &&drugaTxt.Text.Length>=8)
            {
                transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                string prva = prvaTxt.Text;
                string druga = drugaTxt.Text;
                if(prva==druga)
                {
                    transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                    k.Password = prva;
                    KorisnikDMS.ResetujLozinku(k);
                    l.Show();
                    this.Hide();
                }
                else
                {
                    errorLabel.Text = "Lozinke se ne poklapaju!!";
                    transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                }

            }
            else
            {
                errorLabel.Text = "Unijeta lozinka ne prati pravila aplikacije";
                transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            };
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }
    }
}
