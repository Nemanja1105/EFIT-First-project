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
    public partial class VjezbaPrikaz : Form
    {
        private ytPlayer yt;
        private Vjezba vjezba;
        public Vjezba Vj { set { Setuj(value); } }
        public VjezbaPrikaz()
        {
            InitializeComponent();
            yt = new ytPlayer();
            yt.Dock = DockStyle.Fill;
            panel1.Controls.Add(yt);

        }

        //setujemo yt link i opis vjezbe kada dobijemo vjezbu iz setera
        private void Setuj(Vjezba v)
        {
            yt.VideoId = v.YtCode;
            opisLbl.Text = v.Opis;
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
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
