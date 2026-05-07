using BankSystem_UI.Accounts;
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
    public partial class frmConfirmAccount : frmScreen
    {
        public frmConfirmAccount()
        {
            InitializeComponent();

            this.Title = "Confirm Account Screen...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlAccountInfoFilterByAccountNumber1_Load(object sender, EventArgs e)
        {

        }
    }


   
}
