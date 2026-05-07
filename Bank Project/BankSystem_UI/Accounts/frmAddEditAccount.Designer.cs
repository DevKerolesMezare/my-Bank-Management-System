namespace BankSystem_UI.Accounts
{
    partial class frmAddEditAccount
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
            this.components = new System.ComponentModel.Container();
            this.tcAccountInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardByCustomerID1 = new BankSystem_UI.Customer.ctrlPersonCardByCustomerID();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.txtConfirmPinCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcAccountInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAccountInfo
            // 
            this.tcAccountInfo.Controls.Add(this.tpPersonInfo);
            this.tcAccountInfo.Controls.Add(this.tpAccountInfo);
            this.tcAccountInfo.Location = new System.Drawing.Point(9, 119);
            this.tcAccountInfo.Name = "tcAccountInfo";
            this.tcAccountInfo.SelectedIndex = 0;
            this.tcAccountInfo.Size = new System.Drawing.Size(860, 488);
            this.tcAccountInfo.TabIndex = 17;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnPersonInfoNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardByCustomerID1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(852, 455);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.Image = global::BankSystem_UI.Properties.Resources.Next_32;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(719, 408);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 37);
            this.btnPersonInfoNext.TabIndex = 121;
            this.btnPersonInfoNext.Text = "Next";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // ctrlPersonCardByCustomerID1
            // 
            this.ctrlPersonCardByCustomerID1.FilterEnable = true;
            this.ctrlPersonCardByCustomerID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardByCustomerID1.Location = new System.Drawing.Point(8, 8);
            this.ctrlPersonCardByCustomerID1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonCardByCustomerID1.Name = "ctrlPersonCardByCustomerID1";
            this.ctrlPersonCardByCustomerID1.Size = new System.Drawing.Size(837, 390);
            this.ctrlPersonCardByCustomerID1.TabIndex = 0;
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.txtConfirmPinCode);
            this.tpAccountInfo.Controls.Add(this.label5);
            this.tpAccountInfo.Controls.Add(this.chkIsActive);
            this.tpAccountInfo.Controls.Add(this.cbAccountType);
            this.tpAccountInfo.Controls.Add(this.txtPinCode);
            this.tpAccountInfo.Controls.Add(this.txtAccountNumber);
            this.tpAccountInfo.Controls.Add(this.label4);
            this.tpAccountInfo.Controls.Add(this.label3);
            this.tpAccountInfo.Controls.Add(this.label2);
            this.tpAccountInfo.Controls.Add(this.lblAccountID);
            this.tpAccountInfo.Controls.Add(this.label1);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 29);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountInfo.Size = new System.Drawing.Size(852, 455);
            this.tpAccountInfo.TabIndex = 1;
            this.tpAccountInfo.Text = "Account Info";
            this.tpAccountInfo.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPinCode
            // 
            this.txtConfirmPinCode.Location = new System.Drawing.Point(370, 224);
            this.txtConfirmPinCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPinCode.MaxLength = 50;
            this.txtConfirmPinCode.Name = "txtConfirmPinCode";
            this.txtConfirmPinCode.PasswordChar = '*';
            this.txtConfirmPinCode.Size = new System.Drawing.Size(183, 26);
            this.txtConfirmPinCode.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(146, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 151;
            this.label5.Text = "Confirm PINCode:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.Location = new System.Drawing.Point(370, 337);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(107, 28);
            this.chkIsActive.TabIndex = 149;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cbAccountType
            // 
            this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(370, 275);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(183, 28);
            this.cbAccountType.TabIndex = 148;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(370, 173);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '*';
            this.txtPinCode.Size = new System.Drawing.Size(183, 26);
            this.txtPinCode.TabIndex = 147;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(370, 122);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(183, 26);
            this.txtAccountNumber.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 145;
            this.label4.Text = "Account Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 144;
            this.label3.Text = "PIN Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 143;
            this.label2.Text = "Account Number:";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccountID.Location = new System.Drawing.Point(218, 53);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(31, 21);
            this.lblAccountID.TabIndex = 142;
            this.lblAccountID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 141;
            this.label1.Text = "AccountID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::BankSystem_UI.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(605, 615);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::BankSystem_UI.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(739, 615);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Image = global::BankSystem_UI.Properties.Resources.Save_32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(739, 615);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 37);
            this.btnUpdate.TabIndex = 118;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmAddEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 661);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcAccountInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEdit Account";
            this.Activated += new System.EventHandler(this.frmAddEditAccount_Activated);
            this.Load += new System.EventHandler(this.frmAddEditAccount_Load);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.tcAccountInfo, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.tcAccountInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.tpAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAccountInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private Customer.ctrlPersonCardByCustomerID ctrlPersonCardByCustomerID1;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtConfirmPinCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label label1;
    }
}