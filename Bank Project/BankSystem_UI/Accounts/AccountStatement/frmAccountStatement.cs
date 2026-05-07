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
    public partial class frmAccountStatement :frmScreen
    {

        private static DataTable _dtAccountStatement;



        public frmAccountStatement()
        {
            InitializeComponent();

            this.Title = "Account Statement Screen..."; 
        }

        private void frmAccountStatement_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // لو مش رقم أو حرف أو زر تحكم (Backspace مثلاً) يمنع الكتابة
                    e.Handled = true;
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string accNum = txtAccountNumber.Text.Trim();

            if (string.IsNullOrEmpty(accNum))
            {
                e.Cancel = true; // يمنع الخروج من الحقل
                errorProvider1.SetError(txtAccountNumber, "Account number is required!");
            }
            else if (!clsAccount.IsAccountExists(accNum))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "Account number does not exist!");
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber, "");
            }
        }


        private void dtpStartDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime today = DateTime.Today;

            if (start > today)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpStartDate, "Start date cannot be in the future!");
            }
            else
            {
                errorProvider1.SetError(dtpStartDate, "");
            }
        }


        private void dtpEndDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;
            DateTime today = DateTime.Today.AddDays(1);

            if (end < start)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpEndDate, "End date cannot be earlier than start date!");
            }
            else if (start > today || end > today)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpEndDate, "Dates cannot be in the future!");
            }
            else
            {
                errorProvider1.SetError(dtpEndDate, ""); // يمسح رسالة الخطأ
            }
        }

        private void _LoadData()
        {
            _dtAccountStatement = clsAccount.GetAccountStatement(txtAccountNumber.Text , dtpStartDate.Value , dtpEndDate.Value);
            lblRecordsCount.Text = _dtAccountStatement.Rows.Count.ToString();

            dgvAccountStatement.DataSource = _dtAccountStatement;


            if (dgvAccountStatement.Rows.Count > 0)
            {
                dgvAccountStatement.Columns[0].HeaderText = "First Name";
                dgvAccountStatement.Columns[0].Width = 100;

                dgvAccountStatement.Columns[1].HeaderText = "Second Name";
                dgvAccountStatement.Columns[1].Width = 100;

                dgvAccountStatement.Columns[2].HeaderText = "Third Name";
                dgvAccountStatement.Columns[2].Width = 100;

                dgvAccountStatement.Columns[3].HeaderText = "Last Name";
                dgvAccountStatement.Columns[3].Width = 100;

                dgvAccountStatement.Columns[4].HeaderText = "Date of Birth";
                dgvAccountStatement.Columns[4].Width = 90;

                dgvAccountStatement.Columns[5].HeaderText = "Gender";
                dgvAccountStatement.Columns[5].Width = 60;

                dgvAccountStatement.Columns[6].HeaderText = "Country";
                dgvAccountStatement.Columns[6].Width = 80;

                dgvAccountStatement.Columns[7].HeaderText = "Account No.";
                dgvAccountStatement.Columns[7].Width = 100;

                dgvAccountStatement.Columns[8].HeaderText = "Balance";
                dgvAccountStatement.Columns[8].Width = 80;

                dgvAccountStatement.Columns[9].HeaderText = "Account Type";
                dgvAccountStatement.Columns[9].Width = 100;

                dgvAccountStatement.Columns[10].HeaderText = "Amount";
                dgvAccountStatement.Columns[10].Width = 80;

                dgvAccountStatement.Columns[11].HeaderText = "Transaction Date";
                dgvAccountStatement.Columns[11].Width = 140;

                dgvAccountStatement.Columns[12].HeaderText = "Note";
                dgvAccountStatement.Columns[12].Width = 250;

                dgvAccountStatement.Columns[13].HeaderText = "Transaction Type";
                dgvAccountStatement.Columns[13].Width = 100;

                dgvAccountStatement.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;         
                    
               }
            else
            {
                MessageBox.Show(
           "There is no information available at the moment.",
           "No Data",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information
       );
            }


        }

        private void btnFindStatement_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) // يتحقق من كل الفالديشن
                return;

            _LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available at the moment.","Feature Unavailable",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }



        private void _ResetDefaultValue()
        {
            DateTime oneYearAgo = DateTime.Today.AddYears(-1);

            dtpStartDate.Value = oneYearAgo;
            dtpStartDate.MinDate = oneYearAgo;
            dtpStartDate.MaxDate = DateTime.Today;

            dtpEndDate.Value = DateTime.Today.AddDays(1);
            dtpEndDate.MinDate = oneYearAgo;
            dtpEndDate.MaxDate = DateTime.Today.AddDays(1);

            // مسح TextBox رقم الحساب
            txtAccountNumber.Clear();

            // مسح أي ErrorProvider
            errorProvider1.Clear();

            // مسح DataGridView
            dgvAccountStatement.DataSource = null;

            lblRecordsCount.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }
    }
}
