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

namespace AdminSide
{
    public partial class MainForm : Form
    {
        login l;
        public MainForm(login l)
        {
            InitializeComponent();
            InitializeChromium();
            this.l = l;

            //ucitavamo home page
            if (!panel4.Controls.Contains(Home_page.Instance))
            {
                for (int i = panel4.Controls.Count - 1; i >= 0; --i)
                {
                    var ctl = panel4.Controls[i];
                    ctl.Dispose();
                }
                panel4.Controls.Add(Home_page.Instance);
                Home_page.Instance.Dock = DockStyle.Fill;
                Home_page.Instance.BringToFront();

            }
            else
                Home_page.Instance.BringToFront();

        }

        //pokretanje chrome servisa
        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            if (Cef.IsInitialized == false)
                Cef.Initialize(settings);
        }

        private void PomjeriSlide(BunifuButton btn)
        {

            BunifuTransition transition = new BunifuTransition();
            transition.HideSync(slider, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.VertSlide);
            slider.Top = btn.Top;
            transition.ShowSync(slider, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.VertSlide);
        }


        private void homeBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            /*if (!panel4.Controls.Contains(Home_page.Instance))
            {
                for (int i = panel4.Controls.Count - 1; i >= 0; --i)
                {
                    var ctl = panel4.Controls[i];
                    ctl.Dispose();
                }
                panel4.Controls.Add(Home_page.Instance);
                Home_page.Instance.Dock = DockStyle.Fill;
                Home_page.Instance.BringToFront();

            }
            else
                Home_page.Instance.BringToFront();*/

            Home_page data = new Home_page();
            panel4.Controls.Clear();
            panel4.Controls.Add(data);
            data.Dock = DockStyle.Fill;
            data.BringToFront();

        }

        private void vjezbeBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            if (!panel4.Controls.Contains(Vjezbe_data.Instance))
            {
                for (int i = panel4.Controls.Count - 1; i >= 0; --i)
                {
                    var ctl = panel4.Controls[i];
                    ctl.Dispose();
                }
                panel4.Controls.Add(Vjezbe_data.Instance);
                Vjezbe_data.Instance.Dock = DockStyle.Fill;
                Vjezbe_data.Instance.BringToFront();
             
            }
            else
                Vjezbe_data.Instance.BringToFront();




        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            /*if (!panel4.Controls.Contains(KorisnikData.Instance))
            {
                for (int i = panel4.Controls.Count - 1; i >= 0; --i)
                {
                    var ctl = panel4.Controls[i];
                    ctl.Dispose();
                }
                panel4.Controls.Add(KorisnikData.Instance);
                KorisnikData.Instance.Dock = DockStyle.Fill;
                KorisnikData.Instance.BringToFront();
            }
            else
                KorisnikData.Instance.BringToFront();
                */
            KorisnikData data = new KorisnikData();
            panel4.Controls.Clear();
            panel4.Controls.Add(data);
            data.Dock = DockStyle.Fill;
            data.BringToFront();
            
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
        }

        private void privBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            PrivatneVjezbe nove = new PrivatneVjezbe();
            panel4.Controls.Clear();
            panel4.Controls.Add(nove);
            nove.Dock = DockStyle.Fill;
            nove.BringToFront();
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            PomjeriSlide((BunifuButton)sender);
            Chat chat = new Chat();
            panel4.Controls.Clear();
            panel4.Controls.Add(chat);
            chat.Dock = DockStyle.Fill;
            chat.BringToFront();
        }

        //minimaze i maximaze meni bar
        private void meniImg_Click(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            if (meniPanel.Size.Width==194)
            {
                transition.HideSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
                meniPanel.Width = 72;
                transition.ShowSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            {
                transition.HideSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
                meniPanel.Width = 194;
                transition.ShowSync(meniPanel, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
