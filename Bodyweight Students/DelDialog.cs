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
    public partial class DelDialog : Form
    {
        private string tip;
        public DelDialog(string tip,string message)
        {
            InitializeComponent();
            this.tip = tip;
            label1.Text = tip;
            label2.Text = message;
            bunifuButton2.ButtonText = tip;
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
