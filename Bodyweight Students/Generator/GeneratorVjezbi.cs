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
    public partial class GeneratorVjezbi : UserControl
    {
        private GeneratorPrikaz prikaz;
        private Korisnik k;
        public GeneratorPrikaz Prikaz { set { prikaz = value; } }
        public Korisnik K { set { k = value; } }
        
        public GeneratorVjezbi()
        {
            InitializeComponent();
            bunifuElipse1.ApplyElipse(panel1, 10);
            bunifuElipse1.ApplyElipse(panel2, 10);
            bunifuElipse1.ApplyElipse(panel3, 10);
            bunifuElipse1.ApplyElipse(panel4, 10);
            bunifuElipse1.ApplyElipse(panel5, 10);
            bunifuElipse1.ApplyElipse(panel6, 10);
        }

        private List<Vjezba> vjezbe= VjezbaDMS.VratiVjezbe();
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            List<Vjezba> res = vjezbe.FindAll(x => x.TezinaVjezbe == k.Nivo_Spreme && x.Dio_Tijela == Vjezba.DioTijela.Prsa);
            prikaz.Vjezbe = res;
            prikaz.Naslov = "Prsa";
            prikaz.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            List<Vjezba> res = vjezbe.FindAll(x => x.TezinaVjezbe == k.Nivo_Spreme && x.Dio_Tijela == Vjezba.DioTijela.Ruke);
            prikaz.Vjezbe = res;
            prikaz.Naslov = "Ruke";
            prikaz.BringToFront();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            List<Vjezba> res = vjezbe.FindAll(x => x.TezinaVjezbe == k.Nivo_Spreme && x.Dio_Tijela == Vjezba.DioTijela.Noge);
            prikaz.Vjezbe = res;
            prikaz.Naslov = "Noge";
            prikaz.BringToFront();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            List<Vjezba> res = vjezbe.FindAll(x => x.TezinaVjezbe == k.Nivo_Spreme && x.Dio_Tijela == Vjezba.DioTijela.Ramena);
            prikaz.Vjezbe = res;
            prikaz.Naslov = "Ramena";
            prikaz.BringToFront();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            List<Vjezba> res = vjezbe.FindAll(x => x.TezinaVjezbe == k.Nivo_Spreme && x.Dio_Tijela == Vjezba.DioTijela.Stomak);
            prikaz.Vjezbe = res;
            prikaz.Naslov = "Stomak";
            prikaz.BringToFront();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            List<Vjezba> res = vjezbe.FindAll(x => x.TezinaVjezbe == k.Nivo_Spreme && x.Dio_Tijela == Vjezba.DioTijela.Ledja);
            MessageBox.Show(res.Last().Naziv);
            prikaz.Vjezbe = res;
            prikaz.Naslov = "Ledja";
            prikaz.BringToFront();
        }
    }
}
