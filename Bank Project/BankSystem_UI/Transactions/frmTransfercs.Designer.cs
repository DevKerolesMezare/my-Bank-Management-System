namespace BankSystem_UI.Transactions
{
    partial class frmTransfer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTransferID = new System.Windows.Forms.Label();
            this.txtFromAccount = new System.Windows.Forms.TextBox();
            this.txtToAccount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "From Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "To Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(437, 365);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(164, 48);
            this.btnTransfer.TabIndex = 20;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(267, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 48);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(31, 419);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(570, 106);
            this.txtNote.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "TrancferID:";
            // 
            // lblTransferID
            // 
            this.lblTransferID.AutoSize = true;
            this.lblTransferID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferID.ForeColor = System.Drawing.Color.Red;
            this.lblTransferID.Location = new System.Drawing.Point(238, 131);
            this.lblTransferID.Name = "lblTransferID";
            this.lblTransferID.Size = new System.Drawing.Size(43, 24);
            this.lblTransferID.TabIndex = 24;
            this.lblTransferID.Text = "???";
            // 
            // txtFromAccount
            // 
            this.txtFromAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromAccount.Location = new System.Drawing.Point(181, 191);
            this.txtFromAccount.Name = "txtFromAccount";
            this.txtFromAccount.Size = new System.Drawing.Size(195, 31);
            this.txtFromAccount.TabIndex = 25;
            // 
            // txtToAccount
            // 
            this.txtToAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.txtToAccount.Location = new System.Drawing.Point(181, 240);
            this.txtToAccount.Name = "txtToAccount";
            this.txtToAccount.Size = new System.Drawing.Size(195, 32);
            this.txtToAccount.TabIndex = 26;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(181, 295);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(195, 32);
            this.txtAmount.TabIndex = 27;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 535);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtToAccount);
            this.Controls.Add(this.txtFromAccount);
            this.Controls.Add(this.lblTransferID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfercs";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnTransfer, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblTransferID, 0);
            this.Controls.SetChildIndex(this.txtFromAccount, 0);
            this.Controls.SetChildIndex(this.txtToAccount, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTransferID;
        private System.Windows.Forms.TextBox txtFromAccount;
        private System.Windows.Forms.TextBox txtToAccount;
        private System.Windows.Forms.TextBox txtAmount;
    }
}