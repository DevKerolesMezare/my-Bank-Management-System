namespace BankSystem_UI.Accounts
{
    partial class ctrlAccountInfoFilterByAccountNumber
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAccountConfirm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAccountNumber = new BankSystem_UI.Custom_Controls.ccTextBoxcs();
            this.llReset = new System.Windows.Forms.LinkLabel();
            this.btnGoTransaction = new System.Windows.Forms.Button();
            this.ctrlAccountInfo1 = new BankSystem_UI.Accounts.ctrlAccountInfo();
            this.pnlAccountConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccountConfirm
            // 
            this.pnlAccountConfirm.Controls.Add(this.label1);
            this.pnlAccountConfirm.Controls.Add(this.btnFind);
            this.pnlAccountConfirm.Controls.Add(this.txtAccountNumber);
            this.pnlAccountConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountConfirm.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountConfirm.Name = "pnlAccountConfirm";
            this.pnlAccountConfirm.Size = new System.Drawing.Size(388, 127);
            this.pnlAccountConfirm.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(116, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(127, 67);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 50);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.IsRequired = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(76, 34);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(223, 26);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // llReset
            // 
            this.llReset.AutoSize = true;
            this.llReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llReset.Location = new System.Drawing.Point(338, 130);
            this.llReset.Name = "llReset";
            this.llReset.Size = new System.Drawing.Size(47, 21);
            this.llReset.TabIndex = 10;
            this.llReset.TabStop = true;
            this.llReset.Text = "reset";
            this.llReset.Visible = false;
            this.llReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llReset_LinkClicked);
            // 
            // btnGoTransaction
            // 
            this.btnGoTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoTransaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGoTransaction.Enabled = false;
            this.btnGoTransaction.FlatAppearance.BorderSize = 3;
            this.btnGoTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGoTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGoTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTransaction.Location = new System.Drawing.Point(0, 298);
            this.btnGoTransaction.Name = "btnGoTransaction";
            this.btnGoTransaction.Size = new System.Drawing.Size(388, 56);
            this.btnGoTransaction.TabIndex = 19;
            this.btnGoTransaction.Text = "Click Go To Transaction Main Menu";
            this.btnGoTransaction.UseVisualStyleBackColor = false;
            this.btnGoTransaction.Click += new System.EventHandler(this.btnGoTransaction_Click);
            // 
            // ctrlAccountInfo1
            // 
            this.ctrlAccountInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.ctrlAccountInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlAccountInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAccountInfo1.Location = new System.Drawing.Point(0, 127);
            this.ctrlAccountInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlAccountInfo1.Name = "ctrlAccountInfo1";
            this.ctrlAccountInfo1.Size = new System.Drawing.Size(388, 227);
            this.ctrlAccountInfo1.TabIndex = 9;
            // 
            // ctrlAccountInfoFilterByAccountNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnGoTransaction);
            this.Controls.Add(this.llReset);
            this.Controls.Add(this.ctrlAccountInfo1);
            this.Controls.Add(this.pnlAccountConfirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlAccountInfoFilterByAccountNumber";
            this.Size = new System.Drawing.Size(388, 354);
            this.Load += new System.EventHandler(this.ctrlAccountInfoFilterByAccountNumber_Load);
            this.pnlAccountConfirm.ResumeLayout(false);
            this.pnlAccountConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccountConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private Custom_Controls.ccTextBoxcs txtAccountNumber;
        private ctrlAccountInfo ctrlAccountInfo1;
        private System.Windows.Forms.LinkLabel llReset;
        private System.Windows.Forms.Button btnGoTransaction;
    }
}
