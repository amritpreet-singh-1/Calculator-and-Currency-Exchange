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
    public partial class frmStandardCalculator : Form
    {
        public frmStandardCalculator()
        {
            InitializeComponent();
        }

        float value1, value2, result, calMemory;
        char operation;
        bool dec = false;
        Int16 newCal = 0;
        String memory = "";
        private void updatePrimaryDisplay(int numPressed)
        {
            if (dec == true)
            {
                int decCount = 0;

                foreach (char c in lblPrimaryDisplay.Text)
                {
                    if (c == '.')
                    {
                        decCount++;
                    }
                }
                if (decCount < 1)
                {
                    lblPrimaryDisplay.Text = lblPrimaryDisplay.Text + '.';
                }
                dec = false;
            }
            else
            {
                if (lblPrimaryDisplay.Text.Equals("0") == true && lblPrimaryDisplay.Text != null)
                {
                    lblPrimaryDisplay.Text = numPressed.ToString();
                }
                else if (lblPrimaryDisplay.Text.Equals("-0") == true)
                {
                    lblPrimaryDisplay.Text = "- " + numPressed.ToString();
                }
                else if (newCal == 1)
                {
                    lblPrimaryDisplay.Text = "0";
                    newCal = 0;
                }
                else
                {
                    lblPrimaryDisplay.Text = lblPrimaryDisplay.Text + numPressed.ToString();
                }
            }
        }

        private void frmStandardCalculator_Load(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMR.Enabled = btnM_Minus.Enabled = btnM_Plus.Enabled = false;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(0);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            updatePrimaryDisplay(9);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (lblPrimaryDisplay.Text.StartsWith("-"))
            {
                lblPrimaryDisplay.Text = lblPrimaryDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(lblPrimaryDisplay.Text) && decimal.Parse(lblPrimaryDisplay.Text) != 0)
            {
                lblPrimaryDisplay.Text = "-" + lblPrimaryDisplay.Text;
            }            
        }
        private void frmStandardCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    btnNum1.PerformClick();
                    break;
                case Keys.D1:
                    btnNum1.PerformClick();
                    break;


                case Keys.NumPad2:
                    btnNum2.PerformClick();
                    break;
                case Keys.D2:
                    btnNum2.PerformClick();
                    break;


                case Keys.NumPad3:
                    btnNum3.PerformClick();
                    break;
                case Keys.D3:
                    btnNum3.PerformClick();
                    break;


                case Keys.NumPad4:
                    btnNum4.PerformClick();
                    break;
                case Keys.D4:
                    btnNum4.PerformClick();
                    break;


                case Keys.NumPad5:
                    btnNum5.PerformClick();
                    break;
                case Keys.D5:
                    btnNum5.PerformClick();
                    break;


                case Keys.NumPad6:
                    btnNum6.PerformClick();
                    break;
                case Keys.D6:
                    btnNum6.PerformClick();
                    break;


                case Keys.NumPad7:
                    btnNum7.PerformClick();
                    break;
                case Keys.D7:
                    btnNum7.PerformClick();
                    break;


                case Keys.NumPad8:
                    btnNum8.PerformClick();
                    break;
                case Keys.D8:
                    btnNum8.PerformClick();
                    break;


                case Keys.NumPad9:
                    btnNum9.PerformClick();
                    break;
                case Keys.D9:
                    btnNum9.PerformClick();
                    break;


                case Keys.NumPad0:
                    btnNum0.PerformClick();
                    break;
                case Keys.D0:
                    btnNum0.PerformClick();
                    break;

                case Keys.Divide:
                    btnDivision.PerformClick();
                    break;

                case Keys.Multiply:
                    btnMultiply.PerformClick();
                    break;

                case Keys.Add:
                    btnAdd.PerformClick();
                    break;

                case Keys.Subtract:
                    btnSub.PerformClick();
                    break;

                case Keys.Decimal:
                    btnFraction.PerformClick();
                    break;
                case Keys.Back:
                    btnBackspace.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void frmStandardCalculator_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            dec = true;
            updatePrimaryDisplay(0);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            result = 0;
            if(lblPrimaryDisplay.Text.Equals("0") == false)
            {
                switch(operation)
                {
                    case '+':
                        value2 = float.Parse(lblPrimaryDisplay.Text);
                        result = value1 + value2;
                        newCal = 1;
                        break;
                    case '-':
                        value2 = float.Parse(lblPrimaryDisplay.Text);
                        result = value1 - value2;
                        newCal = 1;
                        break;
                    case '*':
                        value2 = float.Parse(lblPrimaryDisplay.Text);
                        result = value1 * value2;
                        newCal = 1;
                        break;
                    case '/':
                        value2 = float.Parse(lblPrimaryDisplay.Text);
                        result = value1 / value2;
                        newCal = 1;
                        break;
                    default:
                        break;
                }
            }
            lblSecondaryDisplay.Text += " " + value2;

            lblPrimaryDisplay.Text = result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(lblPrimaryDisplay.Text);
            operation = '+';
            result = result + value1;
            lblPrimaryDisplay.Text = "";
            lblSecondaryDisplay.Text = value1.ToString() + " " +operation;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(lblPrimaryDisplay.Text);
            operation = '-';
            result = result - value1;
            lblPrimaryDisplay.Text = "";
            lblSecondaryDisplay.Text = value1.ToString() + " " + operation;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(lblPrimaryDisplay.Text);
            operation = '*';
            result = result * value1;
            lblPrimaryDisplay.Text = "";
            lblSecondaryDisplay.Text = value1.ToString() + " " + operation;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(lblPrimaryDisplay.Text);
            operation = '/';
            result = result / value1;
            lblPrimaryDisplay.Text = "";
            lblSecondaryDisplay.Text = value1.ToString() + " " + operation;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            double sqrt;
            value1 = float.Parse(lblPrimaryDisplay.Text);
            if (value1 > 0)
            {
                sqrt = Math.Sqrt(value1);
                lblPrimaryDisplay.Text = sqrt.ToString();
                lblSecondaryDisplay.Text = "√" + value1;
                newCal = 1;
            }
            
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double sqr;
            value1 = float.Parse(lblPrimaryDisplay.Text);
            sqr = value1 * value1;
            lblPrimaryDisplay.Text = sqr.ToString();
            lblSecondaryDisplay.Text = "Sqr(" + Convert.ToString(value1) + ")";
            newCal = 1;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            result = float.Parse(lblPrimaryDisplay.Text);
            lblPrimaryDisplay.Text = (1 / result).ToString();
            lblSecondaryDisplay.Text = "1/" + Convert.ToString(result);
            newCal = 1;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (operation == '+')
            {
                lblPrimaryDisplay.Text = (result * ((float.Parse(lblPrimaryDisplay.Text)) / 100)).ToString();
                newCal = 1;
            }
            else if (operation == '-')
            {
                lblPrimaryDisplay.Text = (result * ((float.Parse(lblPrimaryDisplay.Text)) / 100)).ToString();
                newCal = 1;
            }
            else if (operation == '*')
            {
                lblPrimaryDisplay.Text = ((float.Parse(lblPrimaryDisplay.Text)) / 100).ToString();
                newCal = 1;
            }
            else if (operation == '/')
            {
                lblPrimaryDisplay.Text = ((float.Parse(lblPrimaryDisplay.Text)) / 100).ToString();
                newCal = 1;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblPrimaryDisplay.Text = "";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            lblPrimaryDisplay.Text = calMemory.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            calMemory = 0;
            btnM.Enabled = btnMC.Enabled = btnMR.Enabled = btnM_Minus.Enabled = btnM_Plus.Enabled = false;
        }

        private void btnM_Plus_Click(object sender, EventArgs e)
        {
            calMemory += float.Parse(lblPrimaryDisplay.Text);
            memory += calMemory.ToString() + '\n';
        }

        private void btnM_Minus_Click(object sender, EventArgs e)
        {
            calMemory -= float.Parse(lblPrimaryDisplay.Text);
            memory += calMemory.ToString() + '\n';
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(memory.ToString() + "\n Would You like to clear memory?", "Memory", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnMC.PerformClick();
                btnC.PerformClick();
            }
            else
            {
                btnMR.PerformClick();
            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMR.Enabled = btnM_Minus.Enabled = btnM_Plus.Enabled = true;
            calMemory = float.Parse(lblPrimaryDisplay.Text);
            memory += calMemory.ToString() + '\n';

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblPrimaryDisplay.Text = "";
            lblSecondaryDisplay.Text = "";
            value1 = value2 = result = 0;
            operation = '\0';
            dec = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int numLength = lblPrimaryDisplay.Text.Length;
            if (numLength > 1)
            {
                lblPrimaryDisplay.Text = lblPrimaryDisplay.Text.Substring(0, numLength - 1);
            }
            else
            {
                lblPrimaryDisplay.Text = "0";
            }
                
        }
    }

}
