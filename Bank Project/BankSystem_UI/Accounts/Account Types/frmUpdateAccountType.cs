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

namespace BankSystem_UI.Accounts.Account_Types
{
    public partial class frmUpdateAccountType : frmScreen
    {

        private clsAccountType _AccountType;
        private int _AccountTypeID = -1; 

        public frmUpdateAccountType(int AccountTypeID)
        {
            InitializeComponent();

            this.Title = "Update Account Type Screen...";

            this._AccountTypeID = AccountTypeID;
        }



        private void _LoadData()
        {
            _AccountType = clsAccountType.Find(_AccountTypeID);

            if (_AccountType == null)
            {
                MessageBox.Show("No Account Type found with AccountTypeID = " + _AccountTypeID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             this.Close();
                return; 
            }

            lblAccountTypeID.Text = _AccountTypeID.ToString();

            txtTypeName.Text = _AccountType.TypeName.Trim();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateAccountType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTypeName.Text))
                return;

            _AccountType.TypeName = txtTypeName.Text.Trim();

            if(_AccountType.UpdateAccountType())
            {
                MessageBox.Show("Data updated successfully.",
                   "Update",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed. No changes were made.",
                "Update",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }


        }
    }
}
