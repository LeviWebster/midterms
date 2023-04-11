using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace midterms
{
    public partial class frmMain : Form
    {

        //porting data from login forum attempt
        public frmMain(string strTextBox)
        { 
            InitializeComponent();
            lbl_showpass.Text = strTextBox;
        }

        public frmMain()
        {
        }

        //place holder actions for buttens, or other actions not used.
        private void box_savings_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void txt_deposit_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_cost_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_PayAccount_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_transferAmount_TextChanged(object sender, EventArgs e)
        {
        }
        private void box_checking_CheckedChanged(object sender, EventArgs e)
        {
        }

        // withdrawing action function 
        private void btn_actionsubmit_Click(object sender, EventArgs e)
        {

            // calling the purchase function and calling creating the variables
            string Password = lbl_showpass.Text;
            int withdrawamt = Convert.ToInt16(txt_cost.Text);
            var tuple = SQLhelper.SelectFromloadDB(Password);
            int savingamount = Convert.ToInt16(tuple.Item1);
            int checkingamount = Convert.ToInt16(tuple.Item2);

            //checking what account to use
            bool checkingvariable = box_checking.Checked;
            if (checkingvariable == true)
            {
                SQLhelper.purchasechecking(withdrawamt, checkingamount, Password);
            }
            else
            {
                SQLhelper.purchasesavings(withdrawamt, savingamount, Password);
            }

        }

        //the transfer action
        private void btn_transfer_Click(object sender, EventArgs e)
        {
            //defining the second set of variables
            string Password = lbl_showpass.Text;
            var tuple = SQLhelper.SelectFromloadDB(Password);
            int savingamount = Convert.ToInt16(tuple.Item1);
            int checkingamount = Convert.ToInt16(tuple.Item2);
            int transferamount = Convert.ToInt16(txt_transferAmount.Text);

            bool checkingvariable = box_checking.Checked;

            //checking to use checkiong or savings
            if (checkingvariable = true)
            {
                SQLhelper.transfertochecking(transferamount, savingamount, checkingamount, Password);
            }
            else
            {
             SQLhelper.transfertosavings(transferamount, savingamount, checkingamount, Password);
            }
        }

        //placeholder function
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

    }

}
