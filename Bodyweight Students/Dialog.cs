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
    public partial class Dialog : Form
    {
        private string tip;
        public Dialog(string tip, string message)
        {
            InitializeComponent();
            this.tip = tip;
            label1.Text = tip;
            label2.Text = message;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
