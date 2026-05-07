using BankSystem_Business;
using BankSystem_UI.Global_Classes;
using System;
using System.Windows.Forms;


namespace BankSystem_UI.Transactions
{
    public partial class frmTransfer : frmScreen
    {

        private clsTransfer _transfer;

        private int? _returnCode = null;

        public frmTransfer()
        {
            InitializeComponent();

            this.Title = "Transfer Screen...";

            _transfer = new clsTransfer();
        }

        private void _ResetDefaultValue()
        {
            lblTransferID.Text = "???";
            txtAmount.Text = "";
            txtToAccount.Text = "";
            txtFromAccount.Text = "";
            txtNote.Text = "";
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            if (clsAccount.Find(txtFromAccount.Text) != null)
                _transfer.FromAccountID =  clsAccount.Find(txtFromAccount.Text).AccountID;


            if (clsAccount.Find(txtToAccount.Text) != null)
             _transfer.ToAccountID = clsAccount.Find(txtToAccount.Text).AccountID;
            else
            {
                MessageBox.Show(
         "Account not found",      // The message text
         "Alert",                  // The title of the message box
         MessageBoxButtons.OK,     // Buttons to display
         MessageBoxIcon.Warning    // Icon for the message box
     );
                return; 
            }
                
            _transfer.Amount = Convert.ToDecimal(txtAmount.Text);
            _transfer.Note= txtNote.Text.Trim();
            _transfer.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            if (_transfer.AddNewTransfer(ref _returnCode))
            {
                lblTransferID.Text = _transfer.TransferID.ToString();
                MessageBox.Show("Transfer successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            else
            {
                if (_returnCode == 0)
                {
                    MessageBox.Show("Invalid transfer (check balance or accounts)", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (_returnCode == -1)
                {
                    MessageBox.Show("Error! Transaction failed", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unknown error occurred", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if(clsGlobal.CurrentAccount != null)
            {
                txtFromAccount.Text = clsGlobal.CurrentAccount.AccountNumber.ToString();
                txtFromAccount.ReadOnly = true;
            }
        }
    }
}
