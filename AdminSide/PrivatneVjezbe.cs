using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSide
{
    public partial class PrivatneVjezbe : UserControl
    {
        private List<CustomKorisnik> korisnici = KorisnikDMS.UcitajKorisnike();
        public PrivatneVjezbe()
        {
            InitializeComponent();
            UnesiKorisnike();
        }

        private void UnesiKorisnike()
        {
            foreach (var x in korisnici)
                bunifuDataGridView1.Rows.Add(x.KorisnikId,x.FullName);
        }

        //funkcija pronalazi id selektovanog korisnika
        private int nadjiId()
        {
            int id = -1;
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                if (x.Selected == true)
                {
                    id = (int)x.Cells[0].Value;
                    break;
                }
            }
            return id;
        }
        //funkcija otvara formu za dodanje novog treninga
        //na osnovu indexa koji je selektovan i dana
        private void OtvoriTreningForm(DaniSedmica dan)
        {
            int id = nadjiId();
            Trening trg = new Trening(id, dan);
            trg.ShowDialog();
            trg.Dispose();
        }

        //funkcija otvara formu za dodanje novog treninga
        //na osnovu indexa koji je selektovan i dana
        //ako trening ne postoji korisnik se obavjesava o tome
        private void OtvoriIzmjenaForm(DaniSedmica dan)
        {
            int id = nadjiId();
            if (VjezbaDMS.TreningPostoji(id, dan))
            {
                TreningIzmjena trg = new TreningIzmjena(id, dan);
                trg.ShowDialog();
                trg.Dispose();
            }
            else
            {
                Dialog dialog = new Dialog("Trening ne postoji!!", "Izabrani korisnik nema definisan trening");
                dialog.ShowDialog();
                dialog.Dispose();
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Ponedeljak);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Utorak);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Srijeda);
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Cetvrtak);
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Petak);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Subota);
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            OtvoriTreningForm(DaniSedmica.Nedelja);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
             OtvoriIzmjenaForm(DaniSedmica.Ponedeljak);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            OtvoriIzmjenaForm(DaniSedmica.Utorak);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            OtvoriIzmjenaForm(DaniSedmica.Srijeda);
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            OtvoriIzmjenaForm(DaniSedmica.Cetvrtak);
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            OtvoriIzmjenaForm(DaniSedmica.Petak);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            OtvoriIzmjenaForm(DaniSedmica.Subota);
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            OtvoriIzmjenaForm(DaniSedmica.Nedelja);
        }
    }
}
