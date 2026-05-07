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
    public partial class frmChangePinCode : frmScreen
    {
        private int _AccountID;
        private clsAccount _Account;

        public frmChangePinCode(int AccountID)
        {
            InitializeComponent();

            _AccountID = AccountID;
        }


        private void _ResetDefualtValues()
        {
            txtCurrentPincode.Text = "";
            txtNewPinCode.Text = "";
            txtConfirmPinCode.Text = "";
            txtCurrentPincode.Focus();
        }

        private void frmChangePinCode_Load(object sender, EventArgs e)
        {
            _Account = clsAccount.Find(_AccountID);

            if (_Account == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find Account with id = " + _AccountID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            lblAccountNumber.Text = _Account.AccountNumber.Trim();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPincode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPincode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPincode, "PinCode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPincode, null);
            }
            ;

            if (_Account.PinCode != txtCurrentPincode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPincode, "Current PinCode is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPincode, null);
            }
            ;
        }

        private void txtNewPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPinCode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPinCode, "New PinCode cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtNewPinCode, null);
            }
            ;

        }

        private void txtConfirmPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPinCode.Text.Trim() != txtNewPinCode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPinCode, "PinCode Confirmation does not match New PinCode!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPinCode, null);
            }        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show(
              "Some fields are not valid! Hover over the red icon(s) to see the error.",
              "Validation Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);

                return;
            }


            _Account.PinCode = txtNewPinCode.Text.Trim();

            if (_Account.Save())
            {
                MessageBox.Show("PinCode Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, PinCode did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
