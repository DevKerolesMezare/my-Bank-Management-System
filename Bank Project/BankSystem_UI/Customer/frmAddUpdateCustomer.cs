using BankSystem_Business;
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

namespace BankSystem_UI.Customer
{
    public partial class frmAddUpdateCustomer : frmScreen
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private clsCustomer _Customer;
        private int _CustomerID = -1;


        public delegate void DataBackEventHandler(object sender, int CustomerID);
        public event DataBackEventHandler DataBack;


        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;

            _Mode = enMode.Update;
        }

        public frmAddUpdateCustomer()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }


        private void _ResetDefualtValues()
        {
            if(_Mode == enMode.AddNew)
            {
                this.Title =  "Add New Customer";
                this.Text = "Add New Customer";

                _Customer = new clsCustomer();
               
                tpCustomerInfo.Enabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                this.Title =  "Update Customer";
                this.Text = "Update Customer";

                tpCustomerInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            lblCustomerID.Text = "???";
            txtNotes.Text = "";
            chkIsBlocked.Checked = false;   
        }

        private void _LoadData()
        {
            _Customer = clsCustomer.Find(_CustomerID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_Customer == null)
            {
                MessageBox.Show("No Customer with ID = " + _CustomerID, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }


            lblCustomerID.Text = _Customer.CustomerID.ToString();

            txtNotes.Text = _Customer.Notes;
            chkIsBlocked.Checked = _Customer.IsBlocked;

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Customer.PersonID);
        }

        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
                _ResetDefualtValues();
            
            if(_Mode == enMode.Update) 
                 _LoadData();
        }

        private void frmAddUpdateCustomer_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Customer.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Customer.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Customer.Notes = txtNotes.Text;
            _Customer.IsBlocked = chkIsBlocked.Checked;

            if(_Customer.Save())
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                this.Title = "Update Customer";
                this.Text = "Update Customer";


                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, Convert.ToInt32(lblCustomerID.Text));
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpCustomerInfo.Enabled = true;
                tcCustomerInfo.SelectedTab  = tcCustomerInfo.TabPages["tpCustomerInfo"];
                return;
            }

            if(ctrlPersonCardWithFilter1.PersonID != -1)
            {
                if(clsCustomer.IsCustomerExists(ctrlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpCustomerInfo.Enabled = true;
                    tcCustomerInfo.SelectedTab  = tcCustomerInfo.TabPages["tpCustomerInfo"];
                }
            }
        }

 
    }
}
