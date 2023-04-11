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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }
        int br = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            br++;
            if (br == 1)
                pictureBox1.Image = Resursi.PRVI;
            else if (br == 2)
                pictureBox1.Image = Resursi.DRUGI;
            else if(br==3)
            {
                pictureBox1.Image = Resursi.TRECI;
                br = 0;
            }
        }
    }
}
