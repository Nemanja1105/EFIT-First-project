using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace AdminSide
{
    public partial class Vjezbe_data : UserControl
    {
        private List<Vjezba> lista = new List<Vjezba>();

        private static Vjezbe_data instance;
        public static Vjezbe_data Instance
        {
            get
            {
                if (instance == null)
                    return new Vjezbe_data();
                return instance;
            }
        }

        public Vjezbe_data()
        {
            InitializeComponent();
            InitializeComboBoxes();
            LoadData();

          
            bunifuElipse1.ApplyElipse(searchTxt,10);
        }

    
        //ovim funkcijama dodajemo informacije o vjezbama u search comboboxovima
        private void InitializeComboBoxes()
        {
            tipVjezbeCombo.Items.Clear();
            dioTijelaCombo.Items.Clear();
            tipVjezbeCombo.Items.Add("All");
            dioTijelaCombo.Items.Add("All");
            foreach (string tip in (string[])Enum.GetNames(typeof(Vjezba.TipVjezbe)))
                tipVjezbeCombo.Items.Add(tip);
            foreach (string tip in (string[])Enum.GetNames(typeof(Vjezba.DioTijela)))
                dioTijelaCombo.Items.Add(tip);

        }

        //ucitavamo vjezbe iz baze podataka i ubacujemo ih u gridview
        private void LoadData()
        {
            lista=VjezbaDMS.VratiVjezbe();
            
            PisiGrid(lista);
        }

        //dodajemo vrijednosti u data grid iz liste
        private void PisiGrid(List<Vjezba> list)
        {
            bunifuDataGridView1.Rows.Clear();
            foreach (Vjezba x in list)
                bunifuDataGridView1.Rows.Add(false, x.Naziv, x.YtCode, x.Opis, x.TezinaVjezbe.ToString(), x.Tip_Vjezbe.ToString(), x.Dio_Tijela.ToString());
        }
       
        //kada se promjeni vrijednost u textboxu mi pretrazujemo listu
        //parametar ime da li pocinje sa tim tekstom
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "Ime vjezbe")
            {
                dioTijelaCombo.Text = "All";
                tipVjezbeCombo.Text = "All";

                string search = searchTxt.Text;
                var list = lista.Where((Vjezba v) => v.Naziv.StartsWith(search)).Select((Vjezba v) => v);
                PisiGrid(list.ToList<Vjezba>());
            }
        }

        //kada udjemo u textbox da se ukloni natpis
        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text == "Ime vjezbe")
                searchTxt.Text = "";
        }

        //ako nista nije unijeto u txtbox vrati natpis
        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxt.Text))
                searchTxt.Text = "Ime vjezbe";
        }

        //kada se god promjeni filter ostale filtere resetujemo
        //i prikazujemo grid po zeljenom filteru
        //kada je selektovano all vraca cijelu listu
        private void tipVjezbeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipVjezbeCombo.Text != "All")
            {
                dioTijelaCombo.Text = "All";
                searchTxt.Text = "Ime vjezbe";
                var list = lista.Where((Vjezba v) => v.Tip_Vjezbe.ToString() == tipVjezbeCombo.Text).Select((Vjezba v) => v);
                PisiGrid(list.ToList<Vjezba>());
  
            }
            else
                PisiGrid(lista);
        }

        //kada se god promjeni filter ostale filtere resetujemo
        //i prikazujemo grid po zeljenom filteru
        //kada je selektovano all vraca cijelu listu
        private void dioTijelaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dioTijelaCombo.Text != "All")
            {
                tipVjezbeCombo.Text = "All";
                searchTxt.Text = "Ime vjezbe";
                var list = lista.Where((Vjezba v) => v.Dio_Tijela.ToString() == dioTijelaCombo.Text).Select((Vjezba v) => v);
                PisiGrid(list.ToList<Vjezba>());
            }
            else
                PisiGrid(lista);
        }

        //ova funkcija brise selectovane vjezbe
        //prvo se prikaze dialog za upozorenje
        //ako je rezultat OK brise se vjezba tj red gdje je selektovan checkbox
        //na kraju se gridview resetuje da se prikaze novo stanje
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DelDialog del = new DelDialog("Obrisati Vjezbu", "Da li ste sigurni da zelite obrisate ove zapise ?");
            DialogResult res = del.ShowDialog();
            if(res==DialogResult.OK)
            {
                foreach(DataGridViewRow x in bunifuDataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                   
                    if ((bool)chkg.EditedFormattedValue==true)
                    {
                        
                        var vjezba = lista.Find(v => v.Naziv == (string)x.Cells[1].Value);
                        lista.Remove(vjezba);
                        VjezbaDMS.BrisiVjezbu(vjezba);
                    }
                }
                PisiGrid(lista);
            }
        }

        //otvaramo dialog za unos nove vjezbe
        //ako je sve dobro proteklo dobijamo vjezbu
        //unosimo je u bazi i resetujemo trenutni prikaz
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DodajVjezbu dodaj = new DodajVjezbu(Tip.dodaj);
            DialogResult res = dodaj.ShowDialog();
            if(res==DialogResult.OK)
            {
                VjezbaDMS.DodajVjezbu(dodaj.Dodati);
                lista.Clear();
                lista = VjezbaDMS.VratiVjezbe();
                PisiGrid(lista);
            }
        }

        private void izmjeniBtn_Click(object sender, EventArgs e)
        {
            Vjezba vjezba=null;
            foreach (DataGridViewRow x in bunifuDataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkg = x.Cells[0] as DataGridViewCheckBoxCell;
                //editujemo samo prvi zapis koji je cekiran
                if ((bool)chkg.EditedFormattedValue == true)
                {
                    vjezba = lista.Find(v => v.Naziv == (string)x.Cells[1].Value);
                    break;
                }
            }
            if (vjezba != null)
            {
                DodajVjezbu izmjeni = new DodajVjezbu(Tip.izmjeni, vjezba);
                DialogResult res = izmjeni.ShowDialog();
                if (res == DialogResult.OK)
                {
                    VjezbaDMS.AzurirajVjezbu(izmjeni.Dodati);
                    lista.Clear();
                    lista = VjezbaDMS.VratiVjezbe();
                    PisiGrid(lista);
                }
            }
        }

        private void bunifuDataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if(e.Button==MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add(new MenuItem("Dodaj"));
                menu.MenuItems.Add(new MenuItem("Izbrisi"));
                menu.MenuItems.Add(new MenuItem("Izmjeni"));
                menu.MenuItems.Add(new MenuItem("Pogledaj video"));
                int trenutniRed = bunifuDataGridView1.HitTest(e.X, e.Y).RowIndex;
                if(trenutniRed>=0)
                {
                    bunifuDataGridView1.Rows[trenutniRed].Cells[0].Value = true;
                    menu.Show(bunifuDataGridView1, new Point(e.X, e.Y));
                    //bunifuDataGridView1.Rows[trenutniRed].Cells[0].Value=true;
                }
            }
        }

        //otvaramo file dialog i biramo excel file
        //ako smo izabrali odgovarajuce otvaramo file i citamo vjezbe
        //iz njega, pronalazimo vjezbe koje nemamo u bazi
        //dodajemo ih i osvjezavamo datagrid
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "xlsx Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                Excel excel = new Excel(filename, 1);
                List<Vjezba> list = excel.UcitajVjezbe();
                var result = list.Where(p => !lista.Exists(q=>q.Naziv.ToUpper()==p.Naziv.ToUpper()));
                List<Vjezba> nova = result.ToList<Vjezba>();
                if (nova.Count != 0)
                {
                    foreach (var x in nova)
                        VjezbaDMS.DodajVjezbu(x);
                    lista.Clear();
                    lista = VjezbaDMS.VratiVjezbe();
                    PisiGrid(lista);
                }
                excel.Close();
            }
        }
        
        bool isClicked = false;
        //kada pritisnemo desnik meni se pojavljaju i selectuje red
        private void bunifuDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                bunifuDataGridView1.Rows[e.RowIndex].Selected = true;
                bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value = true;
                menu.Show(bunifuDataGridView1,e.Location );
                menu.Show(Cursor.Position);
                
            }
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
        //otvaramo save dialog i biramo gdje cemo sacuvati nas file i biramo ime
        //u novom threadu pokrecemo funkciju za ispis vjezbi u excel
        //kada task zavrsi zatvorimo excel
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xlsx Files(*.xlsx)| *.xlsx | All Files(*.*) | *.* ";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Excel excel = new Excel(saveFileDialog1.FileName);
                Task T1 = new Task(() => excel.PisiVjezbe(lista));
                T1.Start();
                T1.ContinueWith(task => excel.Close());
            }

        }
        

        //ako se klikne na menu item
        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            isClicked = true;
        }

        //pregled yt pritiskom na item menija
        //naziv i yt kod dobijamo od selectovanog itema
        private void pregledajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = bunifuDataGridView1.SelectedRows[0];
            
            PlayerDialog player = new PlayerDialog((string)red.Cells[1].Value);
            player.LoadYt((string)red.Cells[2].Value);
            player.ShowDialog();
        }

        
    }
}
