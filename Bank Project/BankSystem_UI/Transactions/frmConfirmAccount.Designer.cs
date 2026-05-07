namespace BankSystem_UI.Transactions
{
    partial class frmConfirmAccount
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
            this.ctrlAccountInfoFilterByAccountNumber1 = new BankSystem_UI.Accounts.ctrlAccountInfoFilterByAccountNumber();
            this.SuspendLayout();
            // 
            // ctrlAccountInfoFilterByAccountNumber1
            // 
            this.ctrlAccountInfoFilterByAccountNumber1.BackColor = System.Drawing.Color.Gainsboro;
            this.ctrlAccountInfoFilterByAccountNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAccountInfoFilterByAccountNumber1.Location = new System.Drawing.Point(8, 101);
            this.ctrlAccountInfoFilterByAccountNumber1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAccountInfoFilterByAccountNumber1.Name = "ctrlAccountInfoFilterByAccountNumber1";
            this.ctrlAccountInfoFilterByAccountNumber1.Size = new System.Drawing.Size(388, 354);
            this.ctrlAccountInfoFilterByAccountNumber1.TabIndex = 17;
            this.ctrlAccountInfoFilterByAccountNumber1.Load += new System.EventHandler(this.ctrlAccountInfoFilterByAccountNumber1_Load);
            // 
            // frmConfirmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(403, 457);
            this.Controls.Add(this.ctrlAccountInfoFilterByAccountNumber1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmConfirmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.ctrlAccountInfoFilterByAccountNumber1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Accounts.ctrlAccountInfoFilterByAccountNumber ctrlAccountInfoFilterByAccountNumber1;
    }
}