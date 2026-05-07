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
    public partial class frmScreen : Form
    {
        protected string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value;}
        }


        public frmScreen()
        {
            InitializeComponent();
        }

 

        private void frmScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
