using BankSystem_Business;
using BankSystem_UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem_UI.People
{
    public partial class frmAdd_Edit_Person : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;


       public enum enMode { AddNew = 0, Update = 1 }
       public enum enGendor { Male = 0, Female = 1 }


        private enMode _Mode;
        private clsPerson _Person;
        private int _PersonID = -1;

        public frmAdd_Edit_Person()
        {
            InitializeComponent();
          //  this.Title = "Add New Person";

            btnUpdate.Visible = false;
            _Mode = enMode.AddNew;
        }

        public frmAdd_Edit_Person(int perosnID)
        {
            InitializeComponent();
            btnSave.Visible = false;
            _PersonID = perosnID;
            _Mode = enMode.Update;
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows)
            {
                cbCountry.Items.Add(Row["CountryName"]);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
            }
        }

        private void _Reversrbtn()
        {
            if (_Mode == enMode.AddNew)
            {
                btnUpdate.Visible = false;
                btnSave.Visible = true;

            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
           }

        }

        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;


            if (_Person.Gender == 0)
                rbMale.Checked= true;
            else
                rbFemale.Checked = true;


            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);

            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Egypt");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset defualt values?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ResetDefualtValues();
            }
        }

        private void frmAdd_Edit_Person_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }


        private void _Save()
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gender = (short)enGendor.Male;
            else
                _Person.Gender = (short)enGendor.Female;


            _Person.CountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                _Reversrbtn();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);
                // Trigger the event to send data back to the caller form.     
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Save();
        }


    
        /// ///////////////////////////////////////////////////
                //Validation


        private void LettersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // امنع الأرقام + الرموز + علامات الترقيم + المسافات
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar)
                || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // تمنع الحرف يدخل
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // اسمح بالمسح (Backspace)
            }
        }

        private void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // يمنع أي حاجة غير الأرقام
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
    && e.KeyChar != '+' && e.KeyChar != '-'
    && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true; // امنع أي إدخال غير مسموح
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "Enter First Name");
                e.Cancel = true; // يمنع التركيز يسيب التكست بوكس
            }
            else
            {
                errorProvider1.SetError(txtFirstName, ""); // يشيل العلامة لو مظبوط
            }
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                errorProvider1.SetError(txtSecondName, "Enter Second Name");
                e.Cancel = true; // يمنع التركيز يسيب التكست بوكس
            }
            else
            {
                errorProvider1.SetError(txtSecondName, ""); // يشيل العلامة لو مظبوط
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Enter Last Name");
                e.Cancel = true; // يمنع التركيز يسيب التكست بوكس
            }
            else
            {
                errorProvider1.SetError(txtLastName, ""); // يشيل العلامة لو مظبوط
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Enter Phone Number");
                e.Cancel = true; // يمنع التركيز يسيب التكست بوكس
            }
            else
            {
                errorProvider1.SetError(txtPhone, ""); // يشيل العلامة لو مظبوط
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Enter your Address");
                e.Cancel = true; // يمنع التركيز يسيب التكست بوكس
            }
            else
            {
                errorProvider1.SetError(txtAddress, ""); // يشيل العلامة لو مظبوط
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "Enter NationalNo");
                e.Cancel = true; // يمنع التركيز يسيب التكست بوكس
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, ""); // يشيل العلامة لو مظبوط
            }
        }
    }
}
