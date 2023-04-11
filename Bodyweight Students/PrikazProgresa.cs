using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodyweight_Students
{
    public partial class PrikazProgresa : Form
    {
        List<Korisnik.Slike> slike = new List<Korisnik.Slike>();
        int index = 0;
        //ucitavamo slike iz baze podataka
        //ako slike jos uvijek nisu ucitana
        //prikazuje se upozorenje da slika ne postoji
        public PrikazProgresa(int id)
        {
            InitializeComponent();
            slike = KorisnikDMS.UcitajSlike(id);
            if (slike.Count == 0)
                pictureBox1.Image = Resursi.no_image;
            else
            {
                pictureBox1.Image = slike[0].slika;
                label1.Text = slike[0].datum.ToShortDateString();
            }

        }

        //dugme pomjeranje desno uvecava index pomocu kojeg
        //prolazimo kroz niz ako je index jednak broju slika
        //on se reset na 0
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (slike.Count == 0)
                pictureBox1.Image = Resursi.no_image;
            else
            {
                index++;
                if (index == slike.Count)
                    index = 0;
                pictureBox1.Image = slike[index].slika;
                label1.Text = slike[index].datum.ToShortDateString();
            }
        }
        //dugme pomjera lijevo umanjuje index pomocu kojeg
        //prolazimo kroz niz ako je index-1 on se na stavlja 
        //na najveci index
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (slike.Count == 0)
                pictureBox1.Image = Resursi.no_image;
            {
                index--;
                if (index == -1)
                    index = slike.Count - 1;
                pictureBox1.Image = slike[index].slika;
                label1.Text = slike[index].datum.ToShortDateString();
            }

        }

        //zatvaranje forme
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funkcije koje omogucavaju pomjeranje forme
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void PlayerDialog_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void PlayerDialog_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void PlayerDialog_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
