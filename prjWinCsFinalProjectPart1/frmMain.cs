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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuCalStandard_Click(object sender, EventArgs e)
        {
            frmStandardCalculator calStd = new frmStandardCalculator();
            calStd.MdiParent = this;
            calStd.Show();
        }

        private void mnuQuitProgramme_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure to close the Calculator?", "Closing Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox aboutBox = new frmAboutBox();
            aboutBox.MdiParent = this;
            aboutBox.Show();
        }

        private void toolStrpStandard_Click(object sender, EventArgs e)
        {
            frmStandardCalculator calcStd = new frmStandardCalculator();
            calcStd.MdiParent = this;
            calcStd.Show();
        }

        private void mnuCalScientifique_Click(object sender, EventArgs e)
        {
            frmScientificCalculator calStf = new frmScientificCalculator();
            calStf.MdiParent = this;
            calStf.Show();
        }

        private void toolStrpScientific_Click(object sender, EventArgs e)
        {
            frmScientificCalculator calStf = new frmScientificCalculator();
            calStf.MdiParent = this;
            calStf.Show();
        }


        private void toolStrpStatusBar_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStrpStatusBar.Checked == true)
            {
                statusStrp.Visible = true;
            }
            else
                statusStrp.Visible = false;
        }

        private void toolStrpStatusBar_Click(object sender, EventArgs e)
        {
            if (toolStrpStatusBar.Checked == true)
            {
                toolStrpStatusBar.Checked = false;
            }
            else
                toolStrpStatusBar.Checked = true;
        }

        private void toolStrpEnLigne_Click(object sender, EventArgs e)
        {

        }

        private void toolStrpToolbar_Click(object sender, EventArgs e)
        {
            if (toolStrpToolbar.Checked == true)
            {
                toolStrpToolbar.Checked = false;
            }
            else
                toolStrpToolbar.Checked = true;
        }

        private void toolStrpToolbar_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStrpToolbar.Checked == true)
            {
                toolStrpShortcuts.Visible = true;
            }
            else
                toolStrpShortcuts.Visible = false;
        }

        private void mnuUserManual_Click(object sender, EventArgs e)
        {
            frmUserManual usrManual =  new frmUserManual();
            usrManual.MdiParent = this;
            usrManual.Show();

        }

        private void versionLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChange changeCurrOffline = new frmChange();
            changeCurrOffline.MdiParent = this;
            changeCurrOffline.Show();
        }

        private void toolStrpBureauxChange_Click(object sender, EventArgs e)
        {
            frmChange changeCurrOffline = new frmChange();
            changeCurrOffline.MdiParent = this;
            changeCurrOffline.Show();
        }
    }
}
