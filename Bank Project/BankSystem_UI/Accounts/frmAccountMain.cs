using BankSystem_UI.Transactions;
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
    public partial class frmAccountMain : Form
    {
        public frmAccountMain()
        {
            InitializeComponent();
        }

        private void frmAccountMain_Load(object sender, EventArgs e)
        {
            panel6.Left = (this.ClientSize.Width - panel6.Width) / 2;
            panel6.Top  = (this.ClientSize.Height - panel6.Height) / 2;
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountsManagement frm = new frmAccountsManagement();
            frm.ShowDialog();

            frmAccountMain_Load(null , null);
        }

        private void accountStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountStatement frm = new frmAccountStatement();
            frm.ShowDialog();
            frmAccountMain_Load(null, null);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccountTypes frm = new frmAccountTypes();
            frm.ShowDialog();
            frmAccountMain_Load(null, null);

        }

        private void label3_Click(object sender, EventArgs e)
        {

            
        }

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmAccount frm = new frmConfirmAccount();
            frm.ShowDialog();
            frmAccountMain_Load(null, null);

        }

  
    }
}
