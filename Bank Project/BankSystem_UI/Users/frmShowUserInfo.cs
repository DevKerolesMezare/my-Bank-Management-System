using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.Users
{
    public partial class frmShowUserInfo : frmScreen
    {
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            this.Title = "User Details";
            ctrlUserCardcs1.LoadUserInfo(UserID);
        }
    }
}
