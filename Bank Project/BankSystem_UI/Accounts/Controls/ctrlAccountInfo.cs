using BankSystem_Business;
using BankSystem_UI.Customer;
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

namespace BankSystem_UI.Accounts
{
    public partial class ctrlAccountInfo : UserControl
    {
        private clsAccount _Account;

        public ctrlAccountInfo()
        {
            InitializeComponent();
        }
        

        public void LoadAccountInfo(int accountID)
        {
            _Account = clsAccount.Find(accountID);

            if(_Account == null)
            {
                ResetCtrl();

                MessageBox.Show("No account found with this ID." + accountID,
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return; 
            }

            clsGlobal.CurrentAccount = _Account;
            _FillAccountInfo();
        }


        public bool LoadAccountInfo(string AccountNumber)
        {
            _Account = clsAccount.Find(AccountNumber);

            if(_Account == null)
            {
                ResetCtrl();

                MessageBox.Show("No account found with this AccountNumber." + AccountNumber,
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false; 
            }

            clsGlobal.CurrentAccount = _Account;
            _FillAccountInfo();

            return true;
        }


        private void _FillAccountInfo()
        {
            lblAccountID.Text = _Account.AccountID.ToString();

            lblAccountBalance.Text = _Account.AccountBalance.ToString() + "$";

            lblAccountType.Text = _Account.AccountType.TypeName.Trim();

            if (_Account.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
         
        }

        public void ResetCtrl()
        {
            _Account = null;
            clsGlobal.CurrentAccount = _Account;
            lblAccountID.Text = "???";
            lblAccountType.Text = "???";
            lblAccountBalance.Text = "???";
            lblIsActive.Text = "???";            
        }

        private void ctrlAccountInfo_Load(object sender, EventArgs e)
        {
            ResetCtrl();
        }
    }
}
