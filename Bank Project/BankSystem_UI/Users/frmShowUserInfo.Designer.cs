namespace BankSystem_UI.Users
{
    partial class frmShowUserInfo
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
            this.ctrlUserCardcs1 = new BankSystem_UI.Users.ctrlUserCardcs();
            this.SuspendLayout();
            // 
            // ctrlUserCardcs1
            // 
            this.ctrlUserCardcs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlUserCardcs1.Location = new System.Drawing.Point(8, 104);
            this.ctrlUserCardcs1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlUserCardcs1.Name = "ctrlUserCardcs1";
            this.ctrlUserCardcs1.Size = new System.Drawing.Size(839, 404);
            this.ctrlUserCardcs1.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 522);
            this.Controls.Add(this.ctrlUserCardcs1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserCardcs ctrlUserCardcs1;
    }
}