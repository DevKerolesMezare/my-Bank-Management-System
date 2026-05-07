using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.People.Control
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex=1;
            txtFilterValue.Text =PersonID.ToString();
            _FindNow();
        }

        private void _FindNow()
        { 
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                     ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAdd_Edit_Person frmAdd = new frmAdd_Edit_Person();
            frmAdd.DataBack += DataBackEvent;
            frmAdd.ShowDialog();
        }


        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text=PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            _FindNow();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.Text = "Person ID";
        }

      
    }
}
