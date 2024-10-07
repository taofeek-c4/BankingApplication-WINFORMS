namespace Banka
{
    partial class TransferPage
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
            this.transferPage_closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transferPage_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transfer_sendMoneyBtn = new System.Windows.Forms.Button();
            this.transferPage_textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transfer_backBtn = new System.Windows.Forms.Button();
            this.transferPage_verifyAccountNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferPage_closeBtn
            // 
            this.transferPage_closeBtn.BackColor = System.Drawing.Color.Red;
            this.transferPage_closeBtn.ForeColor = System.Drawing.Color.Black;
            this.transferPage_closeBtn.Location = new System.Drawing.Point(735, -3);
            this.transferPage_closeBtn.Name = "transferPage_closeBtn";
            this.transferPage_closeBtn.Size = new System.Drawing.Size(51, 42);
            this.transferPage_closeBtn.TabIndex = 16;
            this.transferPage_closeBtn.Text = "X";
            this.transferPage_closeBtn.UseVisualStyleBackColor = false;
            this.transferPage_closeBtn.Click += new System.EventHandler(this.transferPage_closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Transfer Funds";
            // 
            // transferPage_textBox1
            // 
            this.transferPage_textBox1.BackColor = System.Drawing.Color.White;
            this.transferPage_textBox1.Location = new System.Drawing.Point(216, 203);
            this.transferPage_textBox1.Multiline = true;
            this.transferPage_textBox1.Name = "transferPage_textBox1";
            this.transferPage_textBox1.Size = new System.Drawing.Size(324, 30);
            this.transferPage_textBox1.TabIndex = 18;
            this.transferPage_textBox1.TextChanged += new System.EventHandler(this.transferPage_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(212, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Account Number:";
            // 
            // transfer_sendMoneyBtn
            // 
            this.transfer_sendMoneyBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.transfer_sendMoneyBtn.ForeColor = System.Drawing.Color.White;
            this.transfer_sendMoneyBtn.Location = new System.Drawing.Point(407, 315);
            this.transfer_sendMoneyBtn.Name = "transfer_sendMoneyBtn";
            this.transfer_sendMoneyBtn.Size = new System.Drawing.Size(117, 42);
            this.transfer_sendMoneyBtn.TabIndex = 20;
            this.transfer_sendMoneyBtn.Text = "Send Money";
            this.transfer_sendMoneyBtn.UseVisualStyleBackColor = false;
            this.transfer_sendMoneyBtn.Click += new System.EventHandler(this.transfer_sendMoneyBtn_Click);
            // 
            // transferPage_textBox2
            // 
            this.transferPage_textBox2.BackColor = System.Drawing.Color.White;
            this.transferPage_textBox2.Location = new System.Drawing.Point(216, 260);
            this.transferPage_textBox2.Multiline = true;
            this.transferPage_textBox2.Name = "transferPage_textBox2";
            this.transferPage_textBox2.Size = new System.Drawing.Size(324, 30);
            this.transferPage_textBox2.TabIndex = 21;
            this.transferPage_textBox2.TextChanged += new System.EventHandler(this.transferPage_textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(212, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter Amount:";
            // 
            // transfer_backBtn
            // 
            this.transfer_backBtn.BackColor = System.Drawing.Color.Red;
            this.transfer_backBtn.ForeColor = System.Drawing.Color.Black;
            this.transfer_backBtn.Location = new System.Drawing.Point(-1, -1);
            this.transfer_backBtn.Name = "transfer_backBtn";
            this.transfer_backBtn.Size = new System.Drawing.Size(88, 40);
            this.transfer_backBtn.TabIndex = 23;
            this.transfer_backBtn.Text = "Back";
            this.transfer_backBtn.UseVisualStyleBackColor = false;
            this.transfer_backBtn.Click += new System.EventHandler(this.transfer_backBtn_Click);
            // 
            // transferPage_verifyAccountNumber
            // 
            this.transferPage_verifyAccountNumber.BackColor = System.Drawing.Color.DarkOrchid;
            this.transferPage_verifyAccountNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferPage_verifyAccountNumber.ForeColor = System.Drawing.Color.White;
            this.transferPage_verifyAccountNumber.Location = new System.Drawing.Point(221, 316);
            this.transferPage_verifyAccountNumber.Name = "transferPage_verifyAccountNumber";
            this.transferPage_verifyAccountNumber.Size = new System.Drawing.Size(140, 40);
            this.transferPage_verifyAccountNumber.TabIndex = 24;
            this.transferPage_verifyAccountNumber.Text = "Verify Account";
            this.transferPage_verifyAccountNumber.UseVisualStyleBackColor = false;
            this.transferPage_verifyAccountNumber.Click += new System.EventHandler(this.transferPage_verifyAccountNumber_Click);
            // 
            // TransferPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.transferPage_verifyAccountNumber);
            this.Controls.Add(this.transfer_backBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transferPage_textBox2);
            this.Controls.Add(this.transfer_sendMoneyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transferPage_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transferPage_closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferPage";
            this.Load += new System.EventHandler(this.TransferPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferPage_closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transferPage_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transfer_sendMoneyBtn;
        private System.Windows.Forms.TextBox transferPage_textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button transfer_backBtn;
        private System.Windows.Forms.Button transferPage_verifyAccountNumber;
    }
}