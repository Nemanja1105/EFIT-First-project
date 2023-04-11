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
    public enum Tip { dodaj,izmjeni}

    public partial class DodajVjezbu : Form
    {
     //objekat kojem ce se pristupiti iz pozvane forme
        private Vjezba dod = new Vjezba();
        public Vjezba Dodati { get { return dod; }set { dod = value; } }

        public DodajVjezbu(Tip t,Vjezba v=null)
        {
            InitializeComponent();
            InitializeComboBoxes();
            if (v != null)
                this.dod = v;
            InitializeControl(t);
            
        }

        //inicijalizujemo comboboksove sa podacima iz klase 
        //koji su definisani
       private void InitializeComboBoxes()
        {
            tipCombo.Items.Clear();
            dioCombo.Items.Clear();
            foreach (string tip in (string[])Enum.GetNames(typeof(Vjezba.TipVjezbe)))
                tipCombo.Items.Add(tip);
            foreach (string tip in (string[])Enum.GetNames(typeof(Vjezba.DioTijela)))
                dioCombo.Items.Add(tip);
        }

        //da ne pravimo dvije razlicite forme za dodaj i izmeni
        //mozemo koristiti isti
       private void InitializeControl(Tip t)
        {
            if(t==Tip.dodaj)
            {
                label1.Text = "Dodaj Vjezbu";
                dodajBtn.ButtonText = "Dodaj";
            }
            else
            {
                label1.Text = "Izmjeni vjezbu";
                dodajBtn.ButtonText = "Izmjeni";
                nazivTxt.Text = dod.Naziv;
                opisTxt.Text = dod.Opis;
                linkTxt.Text = dod.YtCode;
                tezinaCombo.Text = dod.TezinaVjezbe.ToString();
                dioCombo.Text = dod.Dio_Tijela.ToString();
                tipCombo.Text = dod.Tip_Vjezbe.ToString();
            }
        }

        //dugme za otkazivanje
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //ako su parametri unijeti vraca se ok ako nije cancel
        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nazivTxt.Text) && !string.IsNullOrEmpty(linkTxt.Text) && !string.IsNullOrEmpty(opisTxt.Text) &&
                tezinaCombo.Text != "Izabrati" && dioCombo.Text != "Izabrati" && tipCombo.Text != "Izabrati")
            {
                Dodati.Naziv = nazivTxt.Text;
                Dodati.YtCode = linkTxt.Text; ;
                Dodati.Opis = opisTxt.Text;
                Dodati.TezinaVjezbe = (Korisnik.Spremnost)Enum.Parse(typeof(Korisnik.Spremnost), tezinaCombo.Text);
                Dodati.Tip_Vjezbe = (Vjezba.TipVjezbe)Enum.Parse(typeof(Vjezba.TipVjezbe), tipCombo.Text);
                Dodati.Dio_Tijela = (Vjezba.DioTijela)Enum.Parse(typeof(Vjezba.DioTijela), dioCombo.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
