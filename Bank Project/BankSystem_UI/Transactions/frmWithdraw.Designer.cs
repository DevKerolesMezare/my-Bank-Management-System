namespace BankSystem_UI.Transactions
{
    partial class frmWithdraw
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
            this.ctrlTransactions1 = new BankSystem_UI.Transactions.ctrlTransactions();
            this.SuspendLayout();
            // 
            // ctrlTransactions1
            // 
            this.ctrlTransactions1.AccountNumber = null;
            this.ctrlTransactions1.BackColor = System.Drawing.Color.White;
            this.ctrlTransactions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTransactions1.Location = new System.Drawing.Point(0, 99);
            this.ctrlTransactions1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlTransactions1.Name = "ctrlTransactions1";
            this.ctrlTransactions1.Size = new System.Drawing.Size(588, 488);
            this.ctrlTransactions1.TabIndex = 17;
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 590);
            this.Controls.Add(this.ctrlTransactions1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Controls.SetChildIndex(this.ctrlTransactions1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTransactions ctrlTransactions1;
    }
}