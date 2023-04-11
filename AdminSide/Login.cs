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
    public partial class login : Form
    {
        string username="", password="";
        private Bunifu.UI.WinForms.BunifuTransition transition = new Bunifu.UI.WinForms.BunifuTransition();

        public login()
        {
            InitializeComponent();
            bunifuElipse1.ApplyElipse(prijavaBtn, 15);
            bunifuElipse1.ApplyElipse(errorLabel, 15);
            errorLabel.Hide();
        }

        private void user_txt_Enter(object sender, EventArgs e)
        {
            if(user_txt.Text=="Username")
                user_txt.Text="";
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (passTxt.Text == "Password")
                passTxt.Text = "";
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passTxt.Text))
                passTxt.Text = "Password";
            else
                password = passTxt.Text;
        }

        //zbog neponavljanja sadrzaja stavili smo da je admin login unaprijed definisan
        //ovo se moze preko baze podataka ali zbog ustede vremene idemo rucno
        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            if (username == "" || password == "")
            {
                errorLabel.Text = "Sva polja moraju biti popunjena";
                transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
            else
                transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);

            if (username == "admin" && password == "admin")
            {
                transition.HideSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
                MainForm nova = new MainForm(this);
                this.Hide();
                nova.Show();
            }
            else
            {
                errorLabel.Text = "Ne mozemo pronaci nalog sa ovim username i password";
                transition.ShowSync(errorLabel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            }
        }

        private void user_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_txt.Text))
                user_txt.Text = "Username";
            else
                username = user_txt.Text;
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

    }
}
