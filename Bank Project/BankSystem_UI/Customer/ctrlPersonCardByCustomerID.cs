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

namespace BankSystem_UI.Customer
{
    public partial class ctrlPersonCardByCustomerID : UserControl
    {
        private clsCustomer _Customer;

        public ctrlPersonCardByCustomerID()
        {
            InitializeComponent();
        }

        private int _CustomerID = -1; 

        public int CustomerID
        {
            get { return _CustomerID; }
        }

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        private bool _FilterEnable = true; 

        public bool FilterEnable
        {
            get
            {
                return _FilterEnable;
            }
            set
            {
                _FilterEnable = value;
                gbFilters.Enabled = _FilterEnable;
            }

        }


        public void LoadPersonInfoByCustomerID(int CustomerID)
        {
            txtCustomerID.Text = CustomerID.ToString();

            _Customer = clsCustomer.Find(CustomerID);
            if (_Customer != null)
            {
                ctrlPersonCard1.LoadPersonInfo(_Customer.PersonID);
            }
        }

        public void FilterFocus()
        {
            txtCustomerID.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           
            _Customer = clsCustomer.Find(Convert.ToInt32(txtCustomerID.Text));

            if (_Customer != null)
            {
                _CustomerID =  _Customer.CustomerID;
                ctrlPersonCard1.LoadPersonInfo(_Customer.PersonID);
            }
            else
            {
                MessageBox.Show("No Customer with CustomerID = " + txtCustomerID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Text ="";
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frmAdd = new frmAddUpdateCustomer();
            frmAdd.DataBack += DataBackEvent;
            frmAdd.ShowDialog();
        }

        private void DataBackEvent(object sender, int CustomerID)
        {
            // Handle the data received
            txtCustomerID.Text = CustomerID.ToString();

            _Customer = clsCustomer.Find(CustomerID);
            if ( _Customer != null )
                ctrlPersonCard1.LoadPersonInfo(_Customer.PersonID);
            else
                MessageBox.Show("No Customer with CustomerID = " + txtCustomerID.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // يمنع الكتابة
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            btnFind.Enabled = (txtCustomerID.Text != "");
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardByCustomerID_Load(object sender, EventArgs e)
        {
            btnFind.Enabled = (txtCustomerID.Text != "");
        }
    }
}
