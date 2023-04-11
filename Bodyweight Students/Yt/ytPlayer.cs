using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using System.Runtime.InteropServices;

namespace Bodyweight_Students
{
    
    public partial class ytPlayer : UserControl
    {
       
        private string id = null;
        private ChromiumWebBrowser chromeBrowser;
        Bunifu.UI.WinForms.BunifuPictureBox pic;

        public ytPlayer()
        {
            InitializeComponent();
            InitializeChromium();

        }
        //youtube id kada dodamo novi id pozivamo
        //loadVideo koji ocitava dati id
        public string VideoId
        { get { return id; } set { id = value; LoadVideo(id); } }


        //inicijalizujemo cef browser tj stvaramo process
        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            if (Cef.IsInitialized == false)
                Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser();
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.FrameLoadStart += web_FrameLoadStart;
            chromeBrowser.FrameLoadEnd += web_FrameLoadEnd;
            this.Controls.Add(chromeBrowser);

        }

        //kada dobijemo novi id kreiramo link kayoutube embed video
        //cef ucitava link i pojavljuje se na pozadini
        private void LoadVideo(string code)
        {
            string url = "https://www.youtube.com/embed/" + code + "?rel=0&autoplay=1&loop=1&controls=0" +
                "&showinfo=0&hd=1&modestbranding=0&frameborder=0";
            chromeBrowser.Load(url);
        }

        private void web_FrameLoadStart(object sender, CefSharp.FrameLoadStartEventArgs e)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    chromeBrowser.Hide();
                }));
            }
            else
            {
                chromeBrowser.Hide();
            }
        }

        private void web_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    chromeBrowser.Show();
                }));
            }
            else
            {
                chromeBrowser.Show();
            }
        }
    }
}
