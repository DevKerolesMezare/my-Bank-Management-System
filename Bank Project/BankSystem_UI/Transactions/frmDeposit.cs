using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankSystem_UI.Transactions.ctrlTransactions;

namespace BankSystem_UI.Transactions
{
    public partial class frmDeposit : frmScreen
    {
        public frmDeposit()
        {
            InitializeComponent();

            this.Title = "Deposit Screen...";

            ctrlTransactions1._enTransaction = enTransaction.eDeposit;
        }
    }
}
