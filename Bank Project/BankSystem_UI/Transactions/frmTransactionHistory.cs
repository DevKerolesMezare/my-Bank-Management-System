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

namespace BankSystem_UI.Transactions
{
    public partial class frmTransactionHistory : frmScreen
    {

        private DataTable _dtTransactionHistory; 
        public frmTransactionHistory()
        {
            InitializeComponent();

            this.Title = "Transaction History Screen...";

        }

        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            _dtTransactionHistory = clsTransaction.GetAllTransactions();
            dgvTransactions.DataSource = _dtTransactionHistory;
            lblRecordsCount.Text = _dtTransactionHistory.Rows.Count.ToString();

            if (dgvTransactions.Rows.Count > 0)
            {

                // TransactionID
                dgvTransactions.Columns[0].HeaderText = "Transaction ID";
                dgvTransactions.Columns[0].Width = 120;

                // AccountNumber
                dgvTransactions.Columns[1].HeaderText = "Account Number";
                dgvTransactions.Columns[1].Width = 180;

                // Amount
                dgvTransactions.Columns[2].HeaderText = "Amount";
                dgvTransactions.Columns[2].Width = 120;

                // TypeName
                dgvTransactions.Columns[3].HeaderText = "Transaction Type";
                dgvTransactions.Columns[3].Width = 180;

                // TransactionDate
                dgvTransactions.Columns[4].HeaderText = "Date";
                dgvTransactions.Columns[4].Width = 220;

                dgvTransactions.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
    }
}
