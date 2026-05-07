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

namespace BankSystem_UI.People
{
    public partial class frmManagerPeople : frmScreen
    {
        //private int _CurrentPersonID = Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value);

        public frmManagerPeople()
        {
            InitializeComponent();
            this.Title = "People Management Screen...";
        }

        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "Gender", "DateOfBirth", "CountryName",
                                                         "Phone", "Email");




        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gender", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvPeople.DataSource = _dtPeople;
            lblRecordsCount.Text = _dtPeople.DefaultView.Count.ToString();
        }


        private void frmManagerPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = _dtPeople.DefaultView.Count.ToString();
            if (dgvPeople.Rows.Count > 0)
            {


                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 90;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 160;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 100;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;

            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "Gender";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = _dtPeople.DefaultView.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtPeople.DefaultView.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int _PersonID = Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value);

            if (MessageBox.Show($"Are you sure you want to delete this person with ID [{_PersonID}]?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (clsPerson.DeletePerson(_PersonID))
                {
                    MessageBox.Show($"Person with ID [{_PersonID}] deleted successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            _RefreshPeopleList();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAdd_Edit_Person frmAdd = new frmAdd_Edit_Person();
            frmAdd.ShowDialog();

            _RefreshPeopleList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            frmShowPersonInfocs frmShowPerson = new frmShowPersonInfocs(Convert.ToInt32( dgvPeople.CurrentRow.Cells[0].Value));
            frmShowPerson.ShowDialog();
            _RefreshPeopleList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Edit_Person frmAdd = new frmAdd_Edit_Person();
            frmAdd.ShowDialog();
            _RefreshPeopleList();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Edit_Person frmAdd_Edit = new frmAdd_Edit_Person(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value));
            frmAdd_Edit.ShowDialog();

            _RefreshPeopleList();
        }
    }
}
