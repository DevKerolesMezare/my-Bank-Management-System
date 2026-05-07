namespace BankSystem_UI.Accounts.Account_Types
{
    partial class frmUpdateAccountType
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountTypeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "AccountTypeID:";
            // 
            // lblAccountTypeID
            // 
            this.lblAccountTypeID.AutoSize = true;
            this.lblAccountTypeID.ForeColor = System.Drawing.Color.Red;
            this.lblAccountTypeID.Location = new System.Drawing.Point(155, 113);
            this.lblAccountTypeID.Name = "lblAccountTypeID";
            this.lblAccountTypeID.Size = new System.Drawing.Size(39, 20);
            this.lblAccountTypeID.TabIndex = 18;
            this.lblAccountTypeID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type Name:";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(134, 177);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(249, 26);
            this.txtTypeName.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BankSystem_UI.Properties.Resources.Save_322;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(342, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 64);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 348);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccountTypeID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmUpdateAccountType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUpdateAccountType_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblAccountTypeID, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTypeName, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnSave;
    }
}