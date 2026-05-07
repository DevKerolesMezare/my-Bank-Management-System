using BankSystem_Business;
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
    public partial class ctrlAccountDetailsCard : UserControl
    {
        private clsAccount _Account;
        private int _AccountID;

        public int AccountID
        {
             get { return _AccountID; }
        }



        public ctrlAccountDetailsCard()
        {
            InitializeComponent();
        }
         
        public void LoadAccountInfo(int AccountID)
        {
            _Account = clsAccount.Find(AccountID);

            if (_Account == null)
            {
                _ResetDefaultValue();
                MessageBox.Show("No User with AccountID = " + AccountID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            _FillAccountInfo();
        }

        private void _FillAccountInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_Account.CustomerInfo.PersonID);

            lblAccountID.Text = _Account.AccountID.ToString();
            lblAccountNumber.Text = _Account.AccountNumber.ToString();
            lblAccountBalance.Text = _Account.AccountBalance.ToString();
            lblAccountType.Text = _Account.AccountType.TypeName.Trim();
            lblCustomerID.Text = _Account.CustomerID.ToString();

            if(_Account.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }

        private void _ResetDefaultValue()
        {
            ctrlPersonCard1.ResetPersonInfo();

            lblAccountID.Text = "???";
            lblAccountBalance.Text = "???";
            lblCustomerID.Text = "???";
            lblAccountNumber.Text = "???";
            lblAccountType.Text = "???";
            lblIsActive.Text= "???";
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
