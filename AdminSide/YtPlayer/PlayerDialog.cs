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
    public partial class PlayerDialog : Form
    {
        private ytPlayer yt;
        public PlayerDialog(string naziv)
        {
            InitializeComponent();
            yt = new ytPlayer();
            yt.Dock = DockStyle.Bottom;
            this.Controls.Add(yt);
            label1.Text = naziv;
        }

        public void LoadYt(string code)
        {
            yt.VideoId = code;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
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
