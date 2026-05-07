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
    public partial class frmAccountsManagement : frmScreen
    {
        private static DataTable _dtAllAccounts;

        public frmAccountsManagement()
        {
            InitializeComponent();
            this.Title = "Account Management Screen...";
        }


        private void frmAccountsManagement_Load(object sender, EventArgs e)
        {
            _dtAllAccounts = clsAccount.GetAllAccounts();
            lblRecordsCount.Text = _dtAllAccounts.Rows.Count.ToString();
            dgvAccounts.DataSource = _dtAllAccounts;

            cbFilterBy.SelectedIndex = 0;

            
            dgvAccounts.Columns[0].HeaderText = "Account ID";
            dgvAccounts.Columns[0].Width = 130;



            dgvAccounts.Columns[1].HeaderText = "Customer ID";
            dgvAccounts.Columns[1].Width = 135;



            dgvAccounts.Columns[2].HeaderText = "User ID";
            dgvAccounts.Columns[2].Width = 100;



            dgvAccounts.Columns[3].HeaderText = "FullName";
            dgvAccounts.Columns[3].Width = 300;



            dgvAccounts.Columns[4].HeaderText = "Account Number";
            dgvAccounts.Columns[4].Width = 120;



            dgvAccounts.Columns[5].HeaderText = "Account Balance";
            dgvAccounts.Columns[5].Width = 120;



            dgvAccounts.Columns[6].HeaderText = "Type Name";
            dgvAccounts.Columns[6].Width = 140;


            dgvAccounts.Columns[7].HeaderText = "Created Date";
            dgvAccounts.Columns[7].Width = 250;

            

            dgvAccounts.Columns[8].HeaderText = "Is Active";
            dgvAccounts.Columns[8].Width = 100;
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        { 
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Account ID":
                    FilterColumn = "AccountID";
                    break;
                  
                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break;
                  
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                  
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                  
                case "Type Name":
                    FilterColumn = "TypeName";
                    break;
                  


                case "Account Number":
                    FilterColumn = "AccountNumber";
                    break;
                  
                case "Account Balance":
                    FilterColumn = "Account Balance";
                    break;
                  
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
            }

            if (cbFilterBy.Text == "None")
                _dtAllAccounts.DefaultView.RowFilter = "";


            if (cbFilterBy.Text != "Full Name" && cbFilterBy.Text != "Type Name")
                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text);
            else
                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text);
            

            lblRecordsCount.Text = _dtAllAccounts.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;
 

            switch(FilterValue)
            {
                case "All":
                    break;

                case "Yes":
                    FilterValue = "1";
                    break;

                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtAllAccounts.DefaultView.RowFilter = "";
            else
                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
    

            lblRecordsCount.Text = _dtAllAccounts.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                {
                    txtFilterValue.Enabled = true;
                    txtFilterValue.Text = "";
                    txtFilterValue.Focus();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditAccount frmAddEditAccount = new frmAddEditAccount();
            frmAddEditAccount.ShowDialog();


            frmAccountsManagement_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditAccount frmAddEditAccount = new frmAddEditAccount((int)dgvAccounts.CurrentRow.Cells[0].Value);
            frmAddEditAccount.ShowDialog();


            frmAccountsManagement_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAccountInfo frm = new frmShowAccountInfo((int)dgvAccounts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
