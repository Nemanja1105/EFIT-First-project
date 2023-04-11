using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using CefSharp;
using CefSharp.WinForms;

namespace Bodyweight_Students
{
    public partial class MainForm : Form
    {
        private Korisnik k;
        private LoginForm stara;
        public MainForm(Korisnik k,LoginForm l)
        {
            InitializeComponent();
            InitializeChromium();
            this.k = k;
            this.stara = l;
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        //pokretanje chrome servisa
        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            if (Cef.IsInitialized == false)
                Cef.Initialize(settings);
        }
        //minimaze i maximaze meni bar
        private void meniImg_Click(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            if (meniPanel.Size.Width == 194)
            {
                transition.HideSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
                meniPanel.Width = 76;
                transition.ShowSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            {
                transition.HideSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
                meniPanel.Width = 194;
                transition.ShowSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

        //funkcija pomjera slajder kada se pritisne na dugme
        private void PomjeriSlide(BunifuButton btn)
        {

            Bunifu.UI.WinForms.BunifuTransition transition = new BunifuTransition();

            transition.HideSync(slider, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.VertSlide);
            slider.Top = btn.Top;
            transition.ShowSync(slider, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.VertSlide);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            home1.BringToFront();
        }


        private void genBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            GeneratorVjezbi generatorVjezbi1 = new GeneratorVjezbi();
            panel2.Controls.Add(generatorVjezbi1);
            generatorVjezbi1.Prikaz = generatorPrikaz1;
            generatorVjezbi1.K = k;
            generatorVjezbi1.BringToFront();
            
        }

        private void privBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            PrivatniTrening privatniTrening = new PrivatniTrening(k.ID);
            panel2.Controls.Add(privatniTrening);
            privatniTrening.Dock = DockStyle.Fill;
            privatniTrening.BringToFront();
        }

        private void proggBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            /* TvojProgress progress = new TvojProgress(KorisnikDMS.VratiKorisnika(3));

             panel2.Controls.Add(progress);
             progress.Dock = DockStyle.Fill;
             progress.BringToFront();*/
            tvojProgress1.K = k;
            tvojProgress1.BringToFront();


        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            chat1.BringToFront();
            
        }


        private void infoBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            about1.BringToFront();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            stara.Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Edit_Profile profile = new Edit_Profile();
            profile.K = k;
            profile.L = KorisnikDMS.VratiLogin(k.ID);
            profile.ShowDialog();
        }
    }
}
