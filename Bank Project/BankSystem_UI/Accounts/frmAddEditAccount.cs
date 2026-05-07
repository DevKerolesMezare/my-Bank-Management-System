using BankSystem_Business;
using BankSystem_UI.Global_Classes;
using BankSystem_UI.People.Control;
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
    public partial class frmAddEditAccount : frmScreen
    {
        public enum enMode {AddNew = 0 , Update = 1};

        private enMode _Mode; 

        private clsAccount _Account;
        private int _AccountID = -1; 

        public frmAddEditAccount()
        {
            InitializeComponent();
            this.Title = "Add New Account";

            _Mode = enMode.AddNew;
        }
        public frmAddEditAccount(int AccountID)
        {
            InitializeComponent();
            this.Title = "Update Account";

            this._AccountID = AccountID;
            _Mode = enMode.Update;
        }


        private void _FillAccountsTypeInComboBox()
        {
            DataTable dt = clsAccountType.GetAllAccountTypes();

            foreach (DataRow row in dt.Rows)
            {
                cbAccountType.Items.Add(row["TypeName"].ToString());
            }
        }

        private void frmAddEditAccount_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
            {
                btnUpdate.Visible = true;
                _LoadData();
            }
            else
                btnSave.Visible = true;
            
        }


        private void _Save()
        {
            if (!this.ValidateChildren())
                return;
            

            //if (clsAccount.IsAccountNumberUsed(txtAccountNumber.Text))
            //{
            //    MessageBox.Show("This Account Number already exists. Please enter another one.",
            //        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtAccountNumber.Text = "";
            //    txtAccountNumber.Focus();
            //    return;
            //}



            if (_Mode == enMode.Update)
            {
                _Account.AccountNumber = txtAccountNumber.Text.Trim();
                _Account.PinCode = txtPinCode.Text.Trim();
                _Account.IsActive = chkIsActive.Checked;
                _Account.AccountTypeID = (clsAccountType.Find(cbAccountType.Text).AccountTypeID); 
                
                _Account.UpdatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            else
            {
                _Account.AccountNumber = txtAccountNumber.Text.Trim();
                _Account.PinCode = txtPinCode.Text.Trim();
                _Account.CustomerID = ctrlPersonCardByCustomerID1.CustomerID;
                _Account.IsActive = chkIsActive.Checked;
                _Account.AccountTypeID = (clsAccountType.Find(cbAccountType.Text).AccountTypeID);
                _Account.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }



            if(_Account.Save())
            {
                this.Title = "Update Account";
                this.Text  = "Update Account";

                lblAccountID.Text = _Account.AccountID.ToString();
                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }




        // private void _

        private void _LoadData()
        {
            _Account = clsAccount.Find(_AccountID);
            ctrlPersonCardByCustomerID1.FilterEnable = false;

            if (_Account == null)
            {
                MessageBox.Show("No Account with ID = " + _AccountID, "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblAccountID.Text = _Account.AccountID.ToString();
            txtAccountNumber.Text = _Account.AccountNumber.Trim();
            txtPinCode.Text = _Account.PinCode.Trim();         
            
            cbAccountType.Text = _Account.AccountType.TypeName.Trim();

            chkIsActive.Checked = _Account.IsActive;

            ctrlPersonCardByCustomerID1.LoadPersonInfoByCustomerID(_Account.CustomerID);
        }

        private void _ResetDefualtValues()
        {
            _FillAccountsTypeInComboBox();


            if (_Mode == enMode.AddNew)
            {
                this.Title = "Add New Account";
                this.Text = "Add New Account";

                _Account = new clsAccount();

                tpAccountInfo.Enabled = false;

                ctrlPersonCardByCustomerID1.FilterFocus();
            }
            else
            {
                this.Title ="Update Account";
                this.Text = "Update Account";

                tpAccountInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            lblAccountID.Text = "???";
            txtAccountNumber.Text = "";
            txtPinCode.Text="";

            cbAccountType.SelectedIndex = 0;

            chkIsActive.Checked = true;
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            bool? isBlocked = clsCustomer.IsCustomerBlocked(ctrlPersonCardByCustomerID1.CustomerID);


            if (_Mode == enMode.Update)
            {
                btnUpdate.Enabled = true;
                tpAccountInfo.Enabled = true;
                tcAccountInfo.SelectedTab = tcAccountInfo.TabPages["tpAccountInfo"];
                return;
            }
            if (ctrlPersonCardByCustomerID1.CustomerID != -1)
            {
                if (isBlocked == true)
                {
                    MessageBox.Show("Your Customer is Blocked, Contact Admin.", "Inactive Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardByCustomerID1.FilterFocus();
                    return;
                }
                else
                {
                    btnSave.Enabled = true;
                    tpAccountInfo.Enabled = true;
                    tcAccountInfo.SelectedTab  = tcAccountInfo.TabPages["tpAccountInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Customer", "Select a Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardByCustomerID1.FilterFocus();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void txtPinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // يمنع إدخال غير الأرقام
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // يمنع إدخال أكتر من 4 أرقام
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "Account Number is required.");
            }
            else if (clsAccount.IsAccountNumberUsed(txtAccountNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "This Account Number already exists.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccountNumber, "");
            }
        }

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPinCode, "Pin Code is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPinCode, "");
            }
        }

        private void frmAddEditAccount_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardByCustomerID1.FilterFocus();
        }

        private void txtConfirmPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPinCode.Text.Trim() != txtConfirmPinCode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPinCode, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPinCode, null);
            }
        }
    }
}
