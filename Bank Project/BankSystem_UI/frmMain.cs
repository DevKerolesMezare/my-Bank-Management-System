using BankSystem_Business;
using BankSystem_UI.Accounts;
using BankSystem_UI.CustomersManagement;
using BankSystem_UI.Global_Classes;
using BankSystem_UI.Login;
using BankSystem_UI.People;
using BankSystem_UI.Transactions;
using BankSystem_UI.Users;
using BankSystem_UI.UsersManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI
{
    public partial class frmMain : Form
    {
         frmLogin _frmLogin;

        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currenUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();

            frmMain_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGlobal.CurrentUser = null;
                this.Close();
            }
        }


        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerPeople frmManagerPeople = new frmManagerPeople();
            frmManagerPeople.ShowDialog();

            frmMain_Load(null, null);


        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frmManageUsers1 = new frmManageUsers();
            frmManageUsers1.ShowDialog();

            frmMain_Load(null, null);

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerCustomers frmManagerCustomers1 = new frmManagerCustomers();
            frmManagerCustomers1.ShowDialog();

            frmMain_Load(null, null);

        }

        private void panel6_Resize(object sender, EventArgs e)
        {
            CenterPanel6();
        }

        private void CenterPanel6()
        {
            panel6.Left = (this.ClientSize.Width - panel6.Width) / 2;
            panel6.Top  = (this.ClientSize.Height - panel6.Height) / 2;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CenterPanel6();
        }


        private void changeUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
            frmMain_Load(null, null);

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountMain frm = new frmAccountMain();
            frm.ShowDialog();
            frmMain_Load(null, null);
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmAccount frm = new frmConfirmAccount();
            frm.ShowDialog();
            frmMain_Load(null, null);
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactionHistory frm = new frmTransactionHistory();
            frm.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
