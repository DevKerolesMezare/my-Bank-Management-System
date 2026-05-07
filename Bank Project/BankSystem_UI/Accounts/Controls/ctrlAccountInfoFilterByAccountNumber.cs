using BankSystem_Business;
using BankSystem_UI.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.Accounts
{
    public partial class ctrlAccountInfoFilterByAccountNumber : UserControl
    {
        public ctrlAccountInfoFilterByAccountNumber()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (ctrlAccountInfo1.LoadAccountInfo(txtAccountNumber.Text))
            {
                btnGoTransaction.Enabled = true;
                pnlAccountConfirm.Enabled = false;

                llReset.Visible = true;
            }
        }

        private void llReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {          
            pnlAccountConfirm.Enabled = true;
            btnGoTransaction.Enabled = false;
            txtAccountNumber.Text = "";
            ctrlAccountInfo1.ResetCtrl();

            llReset.Visible = false;
        }

        private void btnGoTransaction_Click(object sender, EventArgs e)
        {
            frmTransactionMain frmMain = new frmTransactionMain();     
            frmMain.ShowDialog();
            ctrlAccountInfoFilterByAccountNumber_Load(null , null);
        }

        private void ctrlAccountInfoFilterByAccountNumber_Load(object sender, EventArgs e)
        {

        }
    }
}
