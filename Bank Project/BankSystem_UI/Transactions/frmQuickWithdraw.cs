using BankSystem_Business;
using BankSystem_UI.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.Transactions
{
    public partial class frmQuickWithdraw : frmScreen
    {
        private clsTransaction _Transaction;

        public frmQuickWithdraw()
        {
            InitializeComponent();

            this.Title  =  "Quick Withdraw Screen...";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentAccount == null || clsGlobal.CurrentUser == null)
                return;

            _Transaction = new clsTransaction();
            _Transaction.AccountID = clsGlobal.CurrentAccount.AccountID;
            _Transaction.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Transaction.Amount = Convert.ToInt32(((Button)sender).Tag);
            _Transaction.TransactionTypeID = 2;


            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_Transaction.AddNewTransaction())
                    MessageBox.Show("Withdrawal completed successfully ✅, TransactionID: " + _Transaction.TransactionID.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Withdrawal failed ❌", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Transaction cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
