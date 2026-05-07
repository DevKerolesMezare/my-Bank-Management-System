namespace BankSystem_UI.People
{
    partial class frmShowPersonInfocs
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
            this.ctrlPersonCard1 = new BankSystem_UI.People.Control.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(8, 96);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(839, 300);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.UseWaitCursor = true;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // frmShowPersonInfocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 417);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShowPersonInfocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.Controls.SetChildIndex(this.ctrlPersonCard1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.ctrlPersonCard ctrlPersonCard1;
    }
}