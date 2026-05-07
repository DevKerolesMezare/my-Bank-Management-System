using BankSystem_Business;
using BankSystem_UI.Customer;
using BankSystem_UI.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.CustomersManagement
{
    public partial class frmManagerCustomers : frmScreen
    {

        private DataTable _dtAllCustomers;


        public frmManagerCustomers()
        {
            InitializeComponent();
            this.Title = "Customers Management Screen...";
        }

        private void frmManagerCustomers_Load(object sender, EventArgs e)
        {

            _dtAllCustomers = clsCustomer.GetAllCustomers();
            dgvCustomers.DataSource = _dtAllCustomers;
            lblRecordsCount.Text = dgvCustomers.Rows.Count.ToString();


            if (dgvCustomers.Rows.Count > 0)
            {
                dgvCustomers.Columns[0].HeaderText = "Customer ID";
                dgvCustomers.Columns[0].Width = 125; 

                dgvCustomers.Columns[1].HeaderText = "PersonID";
                dgvCustomers.Columns[1].Width = 110;

                dgvCustomers.Columns[2].HeaderText = "User ID";
                dgvCustomers.Columns[2].Width = 110; 

                dgvCustomers.Columns[3].HeaderText = "Full Name";
                dgvCustomers.Columns[3].Width = 280; 

                dgvCustomers.Columns[4].HeaderText = "CratedAT";
                dgvCustomers.Columns[4].Width = 165; 

                dgvCustomers.Columns[5].HeaderText = "Is Blocked";
                dgvCustomers.Columns[5].Width = 100; 
            }
        }

        private void cbIsBlocked_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsBlocked";
            string FilterValue = cbIsBlocked.Text;


            switch (FilterValue)
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
                _dtAllCustomers.DefaultView.RowFilter = "";
            else
                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}" , FilterColumn , FilterValue);

            lblRecordsCount.Text = _dtAllCustomers.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "Is Blocked")
            {
                txtFilterValue.Visible = false;
                cbIsBlocked.Visible = true;

                cbIsBlocked.Focus();
                cbIsBlocked.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbIsBlocked.Visible = false;

                if(cbFilterBy.Text == "None")
                    txtFilterValue.Enabled = false;
                else
                {
                    txtFilterValue.Enabled = true;

                    txtFilterValue.Text ="";
                    txtFilterValue.Focus();
                }

            }
        }


        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break; 


                case "User ID":
                    FilterColumn = "UserID";
                    break; 


                case "Person ID":
                    FilterColumn = "PersonID";
                    break; 

                case "Full Name":
                    FilterColumn = "FullName";
                    break; 


                case "Is Blocked":
                    FilterColumn = "IsBlocked";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFilterValue.Text.Trim() == "" || FilterColumn =="None")
            {
                _dtAllCustomers.DefaultView.RowFilter = "";
                lblRecordsCount.Text =  _dtAllCustomers.Rows.Count.ToString();
                return; 
            }


            if (FilterColumn != "FullName")
                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}" , FilterColumn , txtFilterValue.Text.Trim());

            else
                _dtAllCustomers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


            lblRecordsCount.Text = _dtAllCustomers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text != "Full Name")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();

            frmManagerCustomers_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.ShowDialog();

            frmManagerCustomers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManagerCustomers_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to delete this Customer with ID [{(int)dgvCustomers.CurrentRow.Cells[0].Value}]?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsCustomer.DeleteCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Customer has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManagerCustomers_Load(null, null);
                }

                else
                    MessageBox.Show("Customer is not deleted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfocs frmShowPerson = new frmShowPersonInfocs(Convert.ToInt32(dgvCustomers.CurrentRow.Cells[1].Value));
            frmShowPerson.ShowDialog();

            frmManagerCustomers_Load(null, null);
        }

        private void findPersonByCustomerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonCardByCustomerID fr = new frmPersonCardByCustomerID();

                fr.ShowDialog();
        }
    }
}
