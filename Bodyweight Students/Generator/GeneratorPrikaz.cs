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
    public partial class GeneratorPrikaz : UserControl
    {
        private List<Vjezba> vjezbe;
        private string naslov;
        public string Naslov { set { naslov = value;label1.Text = naslov; } }
        public List<Vjezba> Vjezbe { set { vjezbe = value; Postavi(); } }
        public GeneratorPrikaz()
        {
            InitializeComponent();
        }

        void Postavi()
        {
            panel1.Controls.Clear();
            refLbl.Top = label2.Top;
            int brojac = 0;
            foreach(var x in vjezbe)
            {
                brojac++;
                VjezbaItem item = new VjezbaItem();
                item.Vj = x;
                item.Index = brojac.ToString();
                item.Left = refLbl.Left;
                item.Top = refLbl.Bottom; refLbl.Top = item.Bottom + 6;
                panel1.Controls.Add(item);
                item.BringToFront();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
