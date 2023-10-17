using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsFinalProjectPart1
{
    public partial class frmChangeOnline : Form
    {
        public frmChangeOnline()
        {
            InitializeComponent();
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            lblRateInfo.Text = "Bienvenue au programme de taux d'echange!" + "\n";
            lblRateInfo.Text += DateTime.Now.ToString();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
