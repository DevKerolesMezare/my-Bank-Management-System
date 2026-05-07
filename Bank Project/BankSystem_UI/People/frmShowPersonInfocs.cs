using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.People
{
    public partial class frmShowPersonInfocs : frmScreen
    {

        private int _PersonID = -1;

        public frmShowPersonInfocs(int personID)
        {
            InitializeComponent();
            this.Title = "Person Details";
            _PersonID = personID;
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {
            if (_PersonID != -1) 
                  ctrlPersonCard1.LoadPersonInfo(_PersonID);
        }
    }
}
