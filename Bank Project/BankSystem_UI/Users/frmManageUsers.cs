using BankSystem_Business;
using BankSystem_UI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.UsersManagement
{
    public partial class frmManageUsers : frmScreen
    {
        public frmManageUsers()
        {
            InitializeComponent();
            this.Title = "Users Management Screen...";
        }

        private static DataTable _dtAllUsers ;

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();
            cbFilterBy.SelectedIndex = 0;
            dgvUsers.DataSource = _dtAllUsers;

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();

            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 350;

            dgvUsers.Columns[3].HeaderText = "UserName";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 120;

        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(cbFilterBy.Text)
            {

                case "User ID":
                    FilterColumn = "UserID";               
                    break;


                case "Person ID":
                    FilterColumn = "PersonID";               
                    break;


                case "User Name":
                    FilterColumn = "UserName";               
                    break;

                case "Full Name":
                    FilterColumn = "FullName";               
                    break;


                case "Is Active":
                    FilterColumn = "IsActive";               
                    break;
            }

            if(txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                 _dtAllUsers.DefaultView.RowFilter = "";               
                lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
                return;
            }

            if(FilterColumn != "FullName" && FilterColumn != "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}" , FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'" , FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

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
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}" , FilterColumn , FilterValue);
          
      

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
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

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAdd = new frmAddUpdateUser();
            frmAdd.ShowDialog();

            frmManageUsers_Load(null, null);
        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManageUsers_Load(null, null);
            }

            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAdd = new frmAddUpdateUser();
            frmAdd.ShowDialog();

            frmManageUsers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser Frm1 = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            frmManageUsers_Load(null, null);

        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
