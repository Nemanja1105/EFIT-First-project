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
    public partial class KorisnikData : UserControl
    {
        private static KorisnikData instance;
        public static KorisnikData Instance
        {
            get
            {
                if (instance == null)
                    return new KorisnikData();
                else
                    return instance;
            }
        }

        private List<CustomKorisnik> korisnici;
        public KorisnikData()
        {
            InitializeComponent();
            LoadData();
            bunifuElipse1.ApplyElipse(searchTxt, 10);
        }

        //ucitavamo korisnike iz baze podataka
        private void LoadData()
        {
            korisnici = KorisnikDMS.UcitajKorisnike();
            PisiGrid(korisnici);
        }

        //unosimo podatke o korisnicima u datagrid
        private void PisiGrid(List<CustomKorisnik> korisnici)
        {
            bunifuDataGridView1.Rows.Clear();
            foreach (CustomKorisnik k in korisnici)
                bunifuDataGridView1.Rows.Add(false, k.KorisnikId, k.Ime, k.Prezime, k.Spremnost.ToString(), k.Email, k.Verifikacija.ToString(),k.DatumReg.ToShortDateString());
        }

        //kada udjemo u textbox da se ukloni natpis
        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text == "Ime Korisnika")
                searchTxt.Text = "";
        }

        //ako nista nije unijeto u txtbox vrati natpis
        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxt.Text))
                searchTxt.Text = "Ime Korisnika";
        }

        //pretrazivanje grida po imenu ili prezimenu
        //kada se god promjeni text pretrazujemo grid po unijetom parametru
        private void searchTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "Ime Korisnika")
            {
                nivoCombo.Text = "All";
                verCombo.Text = "All";
                string search = searchTxt.Text;
                var list = korisnici.Where(k => k.Ime.StartsWith(search)||k.Prezime.StartsWith(search)).Select((CustomKorisnik x) => x);
                PisiGrid(list.ToList());
            }
        }

        //kada se filter promjeni ostale filtere resetujemo
        //i prikazujemo podatke koji ispunjavaju dati filter
        private void nivoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nivoCombo.Text != "All")
            {
                verCombo.Text = "All";
                searchTxt.Text = "Ime Korisnika";
                var list = korisnici.Where(k => k.Spremnost.ToString() == nivoCombo.Text).Select((CustomKorisnik k) => k);
                PisiGrid(list.ToList());
            }
            else
                PisiGrid(korisnici);
        }

        //kada se filter promjeni ostale filtere resetujemo
        //i prikazujemo podatke koji ispunjavaju dati filter
        private void verCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (verCombo.Text != "All")
            {
                nivoCombo.Text = "All";
                searchTxt.Text = "Ime Korisnika";
                bool statusVer = (verCombo.Text == "Verifikovan") ? true : false;
                var list = korisnici.Where(k => k.Verifikacija == statusVer).Select((CustomKorisnik k) => k);
                PisiGrid(list.ToList());
            }
            else
                PisiGrid(korisnici);
        }

        //funkcija za brisanje korisnika iz baze podataka
        //nakon toga se grid osvjezava
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DelDialog del = new DelDialog("Obrisati Korisnika", "Da li ste sigurni da zelite obrisate ove zapise?");
            DialogResult res=del.ShowDialog();
            if(res==DialogResult.OK)
            {
                foreach(DataGridViewRow x in bunifuDataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                    if((bool)chkg.EditedFormattedValue == true)
                    {
                        var korisnik = korisnici.Find(k => k.KorisnikId == (int)x.Cells[1].Value);
                        korisnici.Remove(korisnik);
                        KorisnikDMS.BrisiKorisnika(new Korisnik() { ID = korisnik.KorisnikId });
                    }
                }
                PisiGrid(korisnici);
            }
        }

        //funkcija za resetovanje lozinke cekiranog korisnika
        //ako je potvrdjen odgovor setujemo lozinku na reset
        //prilikom login provjerava se da li je pw=reset ako jeste
        //otvara se dialog za setovanje nove lozinke
        private void izmjeniBtn_Click(object sender, EventArgs e)
        {
            CustomKorisnik korisnik = null;
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                //editujemo samo prvi zapis koji je cekiran
                if ((bool)chkg.EditedFormattedValue == true)
                {
                    korisnik = korisnici.Find(v => v.KorisnikId == (int)x.Cells[1].Value);
                    break;
                }
            }
            if (korisnik != null)
            {
                DelDialog del = new DelDialog("Resetuj Lozinku", "Da li ste sigurni da zelite resetovati lozinku? ");
                DialogResult res = del.ShowDialog();
                if (res == DialogResult.OK)
                    KorisnikDMS.PromjeniSifruLogin(korisnik.KorisnikId, "reset");
            }
        }

        //funkcija za prikaz profila korisnika
        //bira se prvi korisnik koje je checkovan
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int korisnikId=-1;
            foreach(DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                
                if ((bool)chkg.EditedFormattedValue == true)
                {
                    korisnikId = (int)x.Cells[1].Value;
                    break;
                }
            }
            Korisnik k = KorisnikDMS.VratiKorisnika(korisnikId);
            Loginkorisnika l = KorisnikDMS.VratiLogin(korisnikId);
            Korisnik_Profile prev = new Korisnik_Profile(k, l);
            prev.ShowDialog();
        }


        //funkcija povecava nivo spremnosti za izabranog korisnika
        //ako je dialog ok mjenjamo nivo spreme na sljedeci veci
        //nakon toga editujemo korisnika u bazi i refresujemo data grid
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            CustomKorisnik korisnik = null;
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                //editujemo samo prvi zapis koji je cekiran
                if ((bool)chkg.EditedFormattedValue == true)
                {
                    korisnik = korisnici.Find(v => v.KorisnikId == (int)x.Cells[1].Value);
                    break;
                }
            }
            if(korisnik!=null)
            {
                DelDialog del = new DelDialog("Unaprijedi nivo spreme", "Da li ste sigurni da zelite povecati nivo spreme? ");
                DialogResult res = del.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (korisnik.Spremnost != Korisnik.Spremnost.Napredni)
                    {
                        if (korisnik.Spremnost == Korisnik.Spremnost.Pocetni)
                            korisnik.Spremnost = Korisnik.Spremnost.Srednji;
                        else
                            korisnik.Spremnost = Korisnik.Spremnost.Napredni;
                        KorisnikDMS.AzurirajNivoSpreme(new Korisnik() { ID = korisnik.KorisnikId, Nivo_Spreme = korisnik.Spremnost });
                        korisnici.Clear();
                        korisnici = KorisnikDMS.UcitajKorisnike();
                        PisiGrid(korisnici);
                    }
                }

            }
        }


        bool isClicked = false;
        //kada pritisnemo desnik meni se pojavljaju i selectuje red
        private void bunifuDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bunifuDataGridView1.Rows[e.RowIndex].Selected = true;
                bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                meni.Show(bunifuDataGridView1, e.Location);
                meni.Show(Cursor.Position);

            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            isClicked = true;
        }

        //kada se izadje iz menije treba da se unselektuje taj red
        // i resetuje checkbox
        private void menu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (!isClicked)
            {
                bunifuDataGridView1.ClearSelection();
                foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
                    x.Cells[0].Value = false;
            }
            isClicked = false;

        }
    }
}
