namespace BankSystem_UI.Customer
{
    partial class frmPersonCardByCustomerID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonCardByCustomerID1 = new BankSystem_UI.Customer.ctrlPersonCardByCustomerID();
            this.SuspendLayout();
            // 
            // ctrlPersonCardByCustomerID1
            // 
            this.ctrlPersonCardByCustomerID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardByCustomerID1.Location = new System.Drawing.Point(5, 3);
            this.ctrlPersonCardByCustomerID1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonCardByCustomerID1.Name = "ctrlPersonCardByCustomerID1";
            this.ctrlPersonCardByCustomerID1.Size = new System.Drawing.Size(837, 390);
            this.ctrlPersonCardByCustomerID1.TabIndex = 0;
            // 
            // frmPersonCardByCustomerID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 390);
            this.Controls.Add(this.ctrlPersonCardByCustomerID1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPersonCardByCustomerID";
            this.Text = "frmPersonCardByCustomerID";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCardByCustomerID ctrlPersonCardByCustomerID1;
    }
}