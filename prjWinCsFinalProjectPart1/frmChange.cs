using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjWinCsFinalProjectPart1
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }

        //struct decleration
        struct Country
        {
            public string Name;
            public string Currency;
            public double Value;
        }


        //array decleration

        Country[] tabCountries = new Country[25];


        // global variables

        Int16 nbCountry;
        Int16 currentCountry;
        double currencyToUS;

        //function to read the file

        private void readFile()
        {
            StreamReader myfile = new StreamReader("Rates.txt");
            Int16 i = 0;

            while (myfile.EndOfStream ==  false)
            {
                tabCountries[i].Name = myfile.ReadLine();
                tabCountries[i].Currency = myfile.ReadLine();
                tabCountries[i].Value = Convert.ToDouble(myfile.ReadLine());

                cboCountry.Items.Add(tabCountries[i].Name);

                i++;
            }
            myfile.Close();
            nbCountry = i;
        }

        private void frmChange_Load(object sender, EventArgs e)
        {
            readFile();
            cboCountry.SelectedIndex = 0;
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCountry = (short) cboCountry.SelectedIndex;

            currencyToUS = Math.Round(1 / tabCountries[currentCountry].Value, 4);

            radBtnValueFromUS.Text = "de USDollars a " + tabCountries[currentCountry].Currency;
            radBtnValueToUS.Text = tabCountries[currentCountry].Currency + " a USDollars";

            lblCurrencyRatesFrom.Text = "1 US Dollar = " + currencyToUS + " " + tabCountries[currentCountry].Currency  + "(s)";
            lblCurrencyRatesTo.Text = "1 " + tabCountries[currentCountry].Currency + "(s) = " + tabCountries[currentCountry].Value + "US Dollar";

            radBtnValueFromUS.Checked = radBtnValueToUS.Checked = false;

            lblCurrencyFrom.Text = "";
            
        }

        private void radBtnValueFrom_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrencyFrom.Text = "US Dollars";
            txtAmount.Text = "";
            lblResult.Text = "";
            txtAmount.Focus();

        }

        private void radBtnValueTo_CheckedChanged(object sender, EventArgs e)
        {
            lblCurrencyFrom.Text = tabCountries[currentCountry].Currency;
            txtAmount.Focus();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if ( txtAmount.Text == "" )
            {
                MessageBox.Show("Please Enter the amount you want to change!!", "Warning", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else if (radBtnValueFromUS.Checked == false && radBtnValueToUS.Checked == false)
            {
                MessageBox.Show("Please select the conversion you want to do!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double amount = Convert.ToSingle(txtAmount.Text);
                double total = 0;

                if (radBtnValueFromUS.Checked)
                {
                    total = amount * tabCountries[currentCountry].Value;
                    lblResult.Text =  total  + tabCountries[currentCountry].Currency  + "(s)";
                }
                else
                {
                    total = amount * currencyToUS;
                    lblResult.Text = total +  " US Dollars(s)";
                }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            radBtnValueFromUS.Checked = radBtnValueToUS.Checked = false;
            txtAmount.Text = "";
            lblResult.Text = "";
            lblCurrencyFrom.Text = "";
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the program ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
