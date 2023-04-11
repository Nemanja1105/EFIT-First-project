using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodyweight_Students
{
    public partial class VjezbaItem : UserControl
    {
        private Vjezba vjezba;
        private string index;
        public Vjezba Vj { set { vjezba = value; Postavi(); } }
        public string Index { set { index = value; indLbl.Text = index; } }


        public VjezbaItem()
        {
            InitializeComponent();
            bunifuElipse1.ApplyElipse(this, 20);
        }

        void Postavi()
        {
            nazLbl.Text = vjezba.Naziv;
            nivLbl.Text = vjezba.TezinaVjezbe.ToString();
            opisLbl.Text = vjezba.Opis;

        }

        private void yt1_Click(object sender, EventArgs e)
        {
            VjezbaPrikaz prikaz = new VjezbaPrikaz();
            prikaz.Vj = vjezba;
            prikaz.ShowDialog();
            prikaz.Dispose();
        }

        private void VjezbaItem_Load(object sender, EventArgs e)
        {

        }
    }
}
