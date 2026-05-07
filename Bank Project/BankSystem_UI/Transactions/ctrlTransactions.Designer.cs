namespace BankSystem_UI.Transactions
{
    partial class ctrlTransactions
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCurrentBalance = new System.Windows.Forms.Panel();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlisSuccess = new System.Windows.Forms.Panel();
            this.lblNewTransactionID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNewBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAccountNumber = new System.Windows.Forms.Panel();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.pnlCurrentBalance.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlisSuccess.SuspendLayout();
            this.pnlAccountNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTransaction);
            this.panel1.Controls.Add(this.pnlCurrentBalance);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlAccountNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 464);
            this.panel1.TabIndex = 0;
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTransaction.Controls.Add(this.pictureBox2);
            this.pnlTransaction.Controls.Add(this.pictureBox1);
            this.pnlTransaction.Controls.Add(this.btnConfirm);
            this.pnlTransaction.Controls.Add(this.btnCancel);
            this.pnlTransaction.Controls.Add(this.nudAmount);
            this.pnlTransaction.Controls.Add(this.txtNote);
            this.pnlTransaction.Controls.Add(this.label4);
            this.pnlTransaction.Controls.Add(this.label3);
            this.pnlTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransaction.Enabled = false;
            this.pnlTransaction.Location = new System.Drawing.Point(0, 150);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(609, 225);
            this.pnlTransaction.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BankSystem_UI.Properties.Resources.Designcontest_Ecommerce_Business_Dollar_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(96, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 35);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankSystem_UI.Properties.Resources.Zakar_Shining_Z_Bloc_Notes_SZ_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(96, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(429, 170);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(157, 34);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.Location = new System.Drawing.Point(156, 117);
            this.nudAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(92, 26);
            this.nudAmount.TabIndex = 10;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(156, 6);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(412, 80);
            this.txtNote.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // pnlCurrentBalance
            // 
            this.pnlCurrentBalance.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCurrentBalance.Controls.Add(this.lblCurrentBalance);
            this.pnlCurrentBalance.Controls.Add(this.label7);
            this.pnlCurrentBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrentBalance.Location = new System.Drawing.Point(0, 81);
            this.pnlCurrentBalance.Name = "pnlCurrentBalance";
            this.pnlCurrentBalance.Size = new System.Drawing.Size(609, 69);
            this.pnlCurrentBalance.TabIndex = 7;
            this.pnlCurrentBalance.Visible = false;
            this.pnlCurrentBalance.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCurrentBalance_Paint);
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentBalance.Location = new System.Drawing.Point(180, 24);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(39, 20);
            this.lblCurrentBalance.TabIndex = 6;
            this.lblCurrentBalance.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Current Balance:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlisSuccess);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 89);
            this.panel3.TabIndex = 6;
            // 
            // pnlisSuccess
            // 
            this.pnlisSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.pnlisSuccess.Controls.Add(this.lblNewTransactionID);
            this.pnlisSuccess.Controls.Add(this.label2);
            this.pnlisSuccess.Controls.Add(this.lblNewBalance);
            this.pnlisSuccess.Controls.Add(this.label6);
            this.pnlisSuccess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlisSuccess.Location = new System.Drawing.Point(0, 0);
            this.pnlisSuccess.Name = "pnlisSuccess";
            this.pnlisSuccess.Size = new System.Drawing.Size(609, 89);
            this.pnlisSuccess.TabIndex = 7;
            // 
            // lblNewTransactionID
            // 
            this.lblNewTransactionID.AutoSize = true;
            this.lblNewTransactionID.ForeColor = System.Drawing.Color.Red;
            this.lblNewTransactionID.Location = new System.Drawing.Point(481, 29);
            this.lblNewTransactionID.Name = "lblNewTransactionID";
            this.lblNewTransactionID.Size = new System.Drawing.Size(39, 20);
            this.lblNewTransactionID.TabIndex = 7;
            this.lblNewTransactionID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New TransactionID:";
            // 
            // lblNewBalance
            // 
            this.lblNewBalance.AutoSize = true;
            this.lblNewBalance.ForeColor = System.Drawing.Color.Red;
            this.lblNewBalance.Location = new System.Drawing.Point(154, 29);
            this.lblNewBalance.Name = "lblNewBalance";
            this.lblNewBalance.Size = new System.Drawing.Size(39, 20);
            this.lblNewBalance.TabIndex = 5;
            this.lblNewBalance.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "New Balance:";
            // 
            // pnlAccountNumber
            // 
            this.pnlAccountNumber.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAccountNumber.Controls.Add(this.lblAccountNumber);
            this.pnlAccountNumber.Controls.Add(this.btnFind);
            this.pnlAccountNumber.Controls.Add(this.txtAccountNumber);
            this.pnlAccountNumber.Controls.Add(this.label1);
            this.pnlAccountNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountNumber.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountNumber.Name = "pnlAccountNumber";
            this.pnlAccountNumber.Size = new System.Drawing.Size(609, 81);
            this.pnlAccountNumber.TabIndex = 5;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNumber.Location = new System.Drawing.Point(193, 36);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(39, 20);
            this.lblAccountNumber.TabIndex = 8;
            this.lblAccountNumber.Text = "???";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::BankSystem_UI.Properties.Resources.SearchPerson;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(355, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 37);
            this.btnFind.TabIndex = 19;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(182, 33);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(163, 26);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Numnber:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ctrlTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlTransactions";
            this.Size = new System.Drawing.Size(609, 464);
            this.Load += new System.EventHandler(this.ctrlTransactions_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.pnlCurrentBalance.ResumeLayout(false);
            this.pnlCurrentBalance.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlisSuccess.ResumeLayout(false);
            this.pnlisSuccess.PerformLayout();
            this.pnlAccountNumber.ResumeLayout(false);
            this.pnlAccountNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCurrentBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlisSuccess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNewBalance;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblNewTransactionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}
