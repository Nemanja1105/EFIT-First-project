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
    public partial class Trening : Form
    {
        private int korisnikId;
        private DaniSedmica dan;
        public Trening(int KorisnikId,DaniSedmica dan)
        {
            InitializeComponent();
            UnesiVjezbeUGrid();
            this.korisnikId = KorisnikId;
            this.dan = dan;
        }
        private List<Vjezba> vjezbe = VjezbaDMS.VratiVjezbe();
        //pisemo vjezbe u grid kako bi ih korisnik mogao izabrati
        private void UnesiVjezbeUGrid()
        {
            foreach (var x in vjezbe)
                bunifuDataGridView1.Rows.Add(false, x.Naziv, "0", "0");
        }

        //funkcija zatvara formu
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funkcija kreira licni trening sa svojim parametrima
        //trazi koji su redovi selektovani i te vjezbe dodaje
        //u posebnu tabelu spajanja, nakon cega se forma zatvara
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            VjezbaTreninga vjezba = new VjezbaTreninga();
            string naziv = nazivTxt.Text;
            string opis = opisTxt.Text;

            LicniTrening trening = new LicniTrening(naziv, opis, dan, korisnikId);
            VjezbaDMS.DodajTrening(trening);
            LicniTrening novi = VjezbaDMS.UcitajTrening(korisnikId, dan);
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                if ((bool)chkg.EditedFormattedValue == true)
                {
                    Vjezba v = vjezbe.Find(y => y.Naziv == (string)x.Cells[1].Value);
                    string pon = (string)x.Cells[2].Value;
                    string ser = (string)x.Cells[3].Value;
                    vjezba.ponavljanja = Convert.ToInt32(pon);
                    vjezba.serija = Convert.ToInt32(ser);
                    vjezba.vjezba = v;
                    VjezbaDMS.DodajVjezUTrening(novi, vjezba);
                }
            }
            this.Close();
        }
    }
}
