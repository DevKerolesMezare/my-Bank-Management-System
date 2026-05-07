using BankSystem_Business;
using BankSystem_UI.Accounts.Account_Types;
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
    public partial class frmAccountTypes : frmScreen
    {
        public frmAccountTypes()
        {
            InitializeComponent();

            this.Title = "Account Types Screen...";
        }

        private void frmAccountTypes_Load(object sender, EventArgs e)
        {
            dgvAccountTypes.DataSource = clsAccountType.GetAllAccountTypes();
            lblRecordsCount.Text = dgvAccountTypes.Rows.Count.ToString();

            if (dgvAccountTypes.Rows.Count > 0)
            {
                dgvAccountTypes.Columns[0].HeaderText = "Account Type ID";
                dgvAccountTypes.Columns[0].Width = 170; 


                dgvAccountTypes.Columns[1].HeaderText = "Type Name";
                dgvAccountTypes.Columns[1].Width = 210;

                dgvAccountTypes.Columns[2].HeaderText = "IsActive";
                dgvAccountTypes.Columns[2].Width = 100;

            }

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsAccountType.EnableDisableService((int)dgvAccountTypes.CurrentRow.Cells[0].Value, false);

            frmAccountTypes_Load(null, null);
        }
        private void enableServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsAccountType.EnableDisableService((int)dgvAccountTypes.CurrentRow.Cells[0].Value, true);

            frmAccountTypes_Load(null, null);
        }

        private void updateNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateAccountType frmUpdate = new frmUpdateAccountType((int)dgvAccountTypes.CurrentRow.Cells[0].Value);
            frmUpdate.ShowDialog();

            frmAccountTypes_Load(null, null);

        }
    }
}
