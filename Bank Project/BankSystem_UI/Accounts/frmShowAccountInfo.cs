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
    public partial class frmShowAccountInfo : frmScreen
    {
        private int _AccountID = -1;

        public frmShowAccountInfo(int accountID)
        {
            InitializeComponent();

            this.Title = "Account Details";

            this._AccountID = accountID;
        }

        private void frmShowAccountInfo_Load(object sender, EventArgs e)
        {
            ctrlAccountDetailsCard1.LoadAccountInfo(this._AccountID);
        }

    }
}
