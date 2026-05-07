using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_UI.Custom_Controls
{
    public partial class ccTextBoxcs : TextBox
    {
        public ccTextBoxcs()
        {
            InitializeComponent();
        }
     

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public bool IsRequired{set ; get;}

        public enum InputTypeEnum {TextInput , NumberInput }

        public InputTypeEnum InputType;



    }
}
