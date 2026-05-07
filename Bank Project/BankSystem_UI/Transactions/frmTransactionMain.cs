using BankSystem_UI.Accounts;
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

namespace BankSystem_UI.Transactions
{
    public partial class frmTransactionMain : Form
    {

        public frmTransactionMain()
        {
            InitializeComponent();
        }


        private void depoistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeposit frm = new frmDeposit();       
            frm.ShowDialog();
            frmTransactionMain_Load(null, null);
        }


        private void normalWithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdraw frm = new frmWithdraw();
            frm.ShowDialog();
            frmTransactionMain_Load(null, null);
        }

        private void frmTransactionMain_Load(object sender, EventArgs e)
        {
            panel6.Left = (this.ClientSize.Width - panel6.Width) / 2;
            panel6.Top  = (this.ClientSize.Height - panel6.Height) / 2;
        }

        private void seginOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
      

        private void transfarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer();
            frm.ShowDialog();
            frmTransactionMain_Load(null ,null );
        }

        private void transactionTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quickWithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickWithdraw frmQuickWithdraw = new frmQuickWithdraw();     
            frmQuickWithdraw.ShowDialog();
            frmTransactionMain_Load(null, null);
        }

        private void showAccountDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentAccount == null)
                return;

            frmShowAccountInfo frm = new frmShowAccountInfo(clsGlobal.CurrentAccount.AccountID);
            frm.ShowDialog();
            frmTransactionMain_Load(null, null);    
        }

        private void chanageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePinCode frmChangePinCode  =  new frmChangePinCode(clsGlobal.CurrentAccount.AccountID); 
            frmChangePinCode.ShowDialog();
            frmTransactionMain_Load(null, null);
        }
    }
}
