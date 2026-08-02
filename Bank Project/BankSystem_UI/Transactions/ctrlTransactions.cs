using BankSystem_Business;
using BankSystem_UI.Global_Classes;
using System;
using System.Windows.Forms;

namespace BankSystem_UI.Transactions
{
    public partial class ctrlTransactions : UserControl
    {

        public string AccountNumber { get; set; }

        public enum enTransaction {eDeposit = 1, eWithDraw = 2 };
        public enTransaction _enTransaction; 

        private clsTransaction _transaction;
        private int _transactionId;

        private clsAccount _Account;
        
        public int TransactionId
        {
            get { return TransactionId; }
        }


        public ctrlTransactions()
        {
            InitializeComponent();
        }

        private void _LoadData(string AccountNumber)
        {
            this.AccountNumber = AccountNumber;
            _Account = clsAccount.Find(AccountNumber);

            if (_Account != null)
            {
                _transaction = new clsTransaction();

                pnlAccountNumber.Enabled = (clsGlobal.CurrentUser != null);
                pnlTransaction.Enabled = true;
                pnlCurrentBalance.Visible = true;

                lblCurrentBalance.Text = _Account.AccountBalance.ToString();

                MessageBox.Show("Account number found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Reset();
            MessageBox.Show("Account number not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData(txtAccountNumber.Text);
        }  

        private void Reset()
        {
            pnlAccountNumber.Enabled = true;
            pnlTransaction.Enabled = false;
            pnlCurrentBalance.Visible = false;

            txtAccountNumber.Text = "";
            txtNote.Text = "";

            lblCurrentBalance.Text = "???";
            lblNewBalance.Text = "???";
            nudAmount.Value = 5;

        }

        private void ctrlTransactions_Load(object sender, EventArgs e)
        {
            Reset();

            lblAccountNumber.Visible = (clsGlobal.CurrentAccount != null);

            if (lblAccountNumber.Visible)
            {          
                btnFind.Visible = false;
                txtAccountNumber.Visible = false;
                lblAccountNumber.Text = clsGlobal.CurrentAccount.AccountNumber.Trim();

                // refresh
                this.AccountNumber =  clsGlobal.CurrentAccount.AccountNumber;
                _LoadData(clsGlobal.CurrentAccount.AccountNumber);
            
            }

        }



        public void Deposit()
        {
            _transaction.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _transaction.Amount = nudAmount.Value;
            _transaction.AccountID = _Account.AccountID;
            _transaction.Note = txtNote.Text;
            _transaction.TransactionTypeID = (int)enTransaction.eDeposit;



            if (_transaction.AddNewTransaction())
            {

                // refresh
                _Account = clsAccount.Find(AccountNumber);
                lblNewBalance.Text = _Account.AccountBalance.ToString();

                lblNewTransactionID.Text = _transaction.TransactionID.ToString();

                MessageBox.Show($"Deposit completed successfully. TransactionID({_transaction.TransactionID})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transaction failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void WithDraw()
        {
            _transaction.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _transaction.Amount = nudAmount.Value;
            _transaction.AccountID = _Account.AccountID;
            _transaction.Note = txtNote.Text;
            _transaction.TransactionTypeID = (int)enTransaction.eWithDraw;

            
            if(nudAmount.Value < _Account.AccountBalance)
            {
                if (_transaction.AddNewTransaction())
                {
                    pnlisSuccess.Visible = true;

                    // refresh
                    _Account = clsAccount.Find(lblAccountNumber.Text);
                    lblNewBalance.Text = _Account.AccountBalance.ToString();

                    lblNewTransactionID.Text = _transaction.TransactionID.ToString();

                    MessageBox.Show($"Withdraw completed successfully. TransactionID({_transaction.TransactionID})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                                   "The requested amount is not available in your account or exceeds your balance.",
                                   "Warning",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning
                                   );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The transaction has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Reset();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to complete this transaction?", "Confirm Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("The transaction was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_enTransaction == enTransaction.eDeposit)
                Deposit();
            else
                WithDraw();
        }

        private void pnlCurrentBalance_Paint(object sender, PaintEventArgs e)
        {

        }
    }
  
}
