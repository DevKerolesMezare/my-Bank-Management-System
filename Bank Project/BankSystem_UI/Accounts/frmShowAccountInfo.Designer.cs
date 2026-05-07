namespace BankSystem_UI.Accounts
{
    partial class frmShowAccountInfo
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
            this.ctrlAccountDetailsCard1 = new BankSystem_UI.Accounts.ctrlAccountDetailsCard();
            this.SuspendLayout();
            // 
            // ctrlAccountDetailsCard1
            // 
            this.ctrlAccountDetailsCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAccountDetailsCard1.Location = new System.Drawing.Point(0, 103);
            this.ctrlAccountDetailsCard1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAccountDetailsCard1.Name = "ctrlAccountDetailsCard1";
            this.ctrlAccountDetailsCard1.Size = new System.Drawing.Size(841, 456);
            this.ctrlAccountDetailsCard1.TabIndex = 17;
            // 
            // frmShowAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 558);
            this.Controls.Add(this.ctrlAccountDetailsCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmShowAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Account Info";
            this.Load += new System.EventHandler(this.frmShowAccountInfo_Load);
            this.Controls.SetChildIndex(this.ctrlAccountDetailsCard1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAccountDetailsCard ctrlAccountDetailsCard1;
    }
}