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
    public partial class TreningIzmjena : Form
    {
        private int korisnikId;
        private DaniSedmica dan;
        LicniTrening trening;
        public TreningIzmjena(int KorisnikId, DaniSedmica dan)
        {
            InitializeComponent();
            this.korisnikId = KorisnikId;
            this.dan = dan;
            trening = VjezbaDMS.UcitajTrening(korisnikId, dan);
            UnesiVjezbeUGrid();
            SelektujVjezbeTreninga();
        }

        //zatvaranje forme
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Vjezba> vjezbe = VjezbaDMS.VratiVjezbe();
        //pisemo vjezbe u grid kako bi ih korisnik mogao izabrati
        private void UnesiVjezbeUGrid()
        {
            foreach (var x in vjezbe)
                bunifuDataGridView1.Rows.Add(false, x.Naziv, "0", "0");
        }

        //selektujemo vjezbe koje se trenutno nalaze u treningu
        //kao i opis i naziv treninga
        private void SelektujVjezbeTreninga()
        { 
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                if (trening.VjezbeTrening.Exists(v => v.vjezba.Naziv == (string)x.Cells[1].Value))
                {
                    VjezbaTreninga vj = trening.VjezbeTrening.Find(v => v.vjezba.Naziv == (string)x.Cells[1].Value);
                    x.Cells[0].Value = true;
                    x.Cells[2].Value = vj.ponavljanja;
                    x.Cells[3].Value = vj.serija;
                }
            }
            nazivTxt.Text = trening.Naziv;
            opisTxt.Text = trening.Opis;

        }

        //brisemo trening i opet ga stvaramo
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            string naziv = nazivTxt.Text;
            string opis = opisTxt.Text;
            LicniTrening novi = new LicniTrening(naziv, opis, dan, korisnikId);
            VjezbaDMS.BrisiVjezbeTrening(trening.TreningID);
            VjezbaDMS.IzmjeniTrening(novi);
            LicniTrening novi1 = VjezbaDMS.UcitajTrening(korisnikId, dan);
            VjezbaTreninga vjezba = new VjezbaTreninga();
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                if ((bool)chkg.EditedFormattedValue == true)
                {
                    Vjezba v = vjezbe.Find(y => y.Naziv == (string)x.Cells[1].Value);
                    string pon = (string)x.Cells[2].Value.ToString();
                    string ser = (string)x.Cells[3].Value.ToString();
                    vjezba.ponavljanja = Convert.ToInt32(pon);
                    vjezba.serija = Convert.ToInt32(ser);
                    vjezba.vjezba = v;
                    VjezbaDMS.DodajVjezUTrening(novi1, vjezba);
                }
            }
            this.Close();
        }

        //funkcija izlazi iz forme
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
