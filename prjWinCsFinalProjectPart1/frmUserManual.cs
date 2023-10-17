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
    public partial class frmUserManual : Form
    {
        public frmUserManual()
        {
            InitializeComponent();
        }

        private void frmUserManual_Load(object sender, EventArgs e)
        {
            lblDescription.Text += "How it works?" +
                "\nThe program starts at frmMain(Frontpage) from where you can navigate to different things.";
            lblDescription.Text += "\nYou can access the Standard Calculator by clicking on the first icon under the Programmes\n or \n" +
                "By going to Programmes > Calculators > Version Standard." +
                "\n" +
                "You can access the Scientific Calculator by clicking on the second icon under the Programmes\n or \n" +
                "By going to Programmes > Calculators > Version Scientifique." +
                "\nYou can change the shortcuts and statusbar's visibility by going to View and " +
                "by clicking on the one of the options." +
                "\nFor information about the program click Aide > A propos.";
            lblDescription.Text += "\n\nInner Working" +
                "\nMethod private void updatePrimaryDisplay(int numPressed) is used to pass the numbers pressed(numPressed) on the form." +
                "\nAlso private void frmStandardCalculator_KeyDown(object sender, KeyEventArgs e) event has been used to record the keys pressed on the KeyBoard and Numpad so that it can be displayed on screen.(Buttons -> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, +, -, *, /, Backspace).";
            lblDescription.Text += "\n\nThe value displayed in lblPrimaryDisplay is saved in value1 or result (Both declared Gloabally) according to the req calculation." +
                "After the req operation button is pressed, if required value2 = new data entered in lblPrimaryDisplay." +
                "\nThe required operation is solved when the btnEqual click is performed or when the required operation buttton is pressed. " +
                "\nEx:- Additon reuires 2 values so First value is entered then the btnAdd is pressed, then the value2 is entered and then when the btnEqual is pressed the operation is solved and the result is displayed in lblPrimaryDisplay. ";
            lblDescription.Text += "\n\n\nAmritpreet Singh, Amritpreet Singh";
        }
    }
}
