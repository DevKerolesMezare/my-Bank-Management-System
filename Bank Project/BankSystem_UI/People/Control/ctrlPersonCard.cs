using BankSystem_Business;
using BankSystem_UI.Properties;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BankSystem_UI.People.Control
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard() => InitializeComponent();


        private clsPerson _Person;

        private int _PersonID = -1;

        public int PersonID { get { return _PersonID; } }

        public clsPerson SelectedPersonInfo { get { return _Person; } }


        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show(
                    "No Person with National No. = " + NationalNo.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FullName;
            lblGendor.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.CountryID).CountryName;
            lblAddress.Text = _Person.Address;

            _LoadPersonImage();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_Edit_Person frm_Edit = new frmAdd_Edit_Person(_PersonID);
            frm_Edit.ShowDialog();

            // refresh form
            LoadPersonInfo(_PersonID);
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != string.Empty)
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show(
                        "Could not find this image: = " + ImagePath,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;
        }


    }
}
