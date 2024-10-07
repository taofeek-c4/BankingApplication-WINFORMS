namespace Banka
{
    partial class Dashboard
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.dashboard_withdraw = new System.Windows.Forms.Button();
            this.dashboard_deposit = new System.Windows.Forms.Button();
            this.dashboard_checkbalance = new System.Windows.Forms.Button();
            this.dashboard_pagename = new System.Windows.Forms.Label();
            this.dashboard_eightbtn = new System.Windows.Forms.Button();
            this.dashboard_onebtn = new System.Windows.Forms.Button();
            this.dashboard_ninebtn = new System.Windows.Forms.Button();
            this.dashboard_sixbtn = new System.Windows.Forms.Button();
            this.dashboard_twobtn = new System.Windows.Forms.Button();
            this.dashboard_threebtn = new System.Windows.Forms.Button();
            this.dashboard_fivebtn = new System.Windows.Forms.Button();
            this.dashboard_sevenbtn = new System.Windows.Forms.Button();
            this.dashboard_fourbtn = new System.Windows.Forms.Button();
            this.dashboard_zerobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard_clear = new System.Windows.Forms.Button();
            this.dashboard_dot = new System.Windows.Forms.Button();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard_transfer = new System.Windows.Forms.Button();
            this.Dashboard_logOutBtn = new System.Windows.Forms.Button();
            this.Dashboard_CheckAccountNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(756, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtbox1
            // 
            this.txtbox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox1.Location = new System.Drawing.Point(249, 52);
            this.txtbox1.Multiline = true;
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.ReadOnly = true;
            this.txtbox1.Size = new System.Drawing.Size(512, 52);
            this.txtbox1.TabIndex = 0;
            this.txtbox1.Text = "0";
            this.txtbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // dashboard_withdraw
            // 
            this.dashboard_withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_withdraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_withdraw.Location = new System.Drawing.Point(33, 276);
            this.dashboard_withdraw.Name = "dashboard_withdraw";
            this.dashboard_withdraw.Size = new System.Drawing.Size(159, 48);
            this.dashboard_withdraw.TabIndex = 16;
            this.dashboard_withdraw.Text = "Withraw";
            this.dashboard_withdraw.UseVisualStyleBackColor = false;
            this.dashboard_withdraw.Click += new System.EventHandler(this.dashboard_withdraw_Click);
            // 
            // dashboard_deposit
            // 
            this.dashboard_deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_deposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_deposit.Location = new System.Drawing.Point(33, 207);
            this.dashboard_deposit.Name = "dashboard_deposit";
            this.dashboard_deposit.Size = new System.Drawing.Size(159, 48);
            this.dashboard_deposit.TabIndex = 17;
            this.dashboard_deposit.Text = "Deposit";
            this.dashboard_deposit.UseVisualStyleBackColor = false;
            this.dashboard_deposit.Click += new System.EventHandler(this.dashboard_deposit_Click);
            // 
            // dashboard_checkbalance
            // 
            this.dashboard_checkbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_checkbalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_checkbalance.Location = new System.Drawing.Point(33, 339);
            this.dashboard_checkbalance.Name = "dashboard_checkbalance";
            this.dashboard_checkbalance.Size = new System.Drawing.Size(159, 48);
            this.dashboard_checkbalance.TabIndex = 18;
            this.dashboard_checkbalance.Text = "Check Balance";
            this.dashboard_checkbalance.UseVisualStyleBackColor = false;
            this.dashboard_checkbalance.Click += new System.EventHandler(this.dashboard_checkbalance_Click);
            // 
            // dashboard_pagename
            // 
            this.dashboard_pagename.AutoSize = true;
            this.dashboard_pagename.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_pagename.ForeColor = System.Drawing.Color.Cornsilk;
            this.dashboard_pagename.Location = new System.Drawing.Point(12, 80);
            this.dashboard_pagename.Name = "dashboard_pagename";
            this.dashboard_pagename.Size = new System.Drawing.Size(203, 24);
            this.dashboard_pagename.TabIndex = 19;
            this.dashboard_pagename.Text = "Transaction Mode";
            this.dashboard_pagename.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboard_eightbtn
            // 
            this.dashboard_eightbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_eightbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_eightbtn.Location = new System.Drawing.Point(410, 359);
            this.dashboard_eightbtn.Name = "dashboard_eightbtn";
            this.dashboard_eightbtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_eightbtn.TabIndex = 20;
            this.dashboard_eightbtn.Text = "8";
            this.dashboard_eightbtn.UseVisualStyleBackColor = false;
            this.dashboard_eightbtn.Click += new System.EventHandler(this.dashboard_eightbtn_Click);
            // 
            // dashboard_onebtn
            // 
            this.dashboard_onebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_onebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_onebtn.Location = new System.Drawing.Point(293, 246);
            this.dashboard_onebtn.Name = "dashboard_onebtn";
            this.dashboard_onebtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_onebtn.TabIndex = 22;
            this.dashboard_onebtn.Text = "1";
            this.dashboard_onebtn.UseVisualStyleBackColor = false;
            this.dashboard_onebtn.Click += new System.EventHandler(this.dashboard_onebtn_Click_1);
            // 
            // dashboard_ninebtn
            // 
            this.dashboard_ninebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_ninebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_ninebtn.Location = new System.Drawing.Point(525, 359);
            this.dashboard_ninebtn.Name = "dashboard_ninebtn";
            this.dashboard_ninebtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_ninebtn.TabIndex = 23;
            this.dashboard_ninebtn.Text = "9";
            this.dashboard_ninebtn.UseVisualStyleBackColor = false;
            this.dashboard_ninebtn.Click += new System.EventHandler(this.dashboard_ninebtn_Click);
            // 
            // dashboard_sixbtn
            // 
            this.dashboard_sixbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_sixbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_sixbtn.Location = new System.Drawing.Point(525, 303);
            this.dashboard_sixbtn.Name = "dashboard_sixbtn";
            this.dashboard_sixbtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_sixbtn.TabIndex = 24;
            this.dashboard_sixbtn.Text = "6";
            this.dashboard_sixbtn.UseVisualStyleBackColor = false;
            this.dashboard_sixbtn.Click += new System.EventHandler(this.dashboard_sixbtn_Click);
            // 
            // dashboard_twobtn
            // 
            this.dashboard_twobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_twobtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_twobtn.Location = new System.Drawing.Point(410, 246);
            this.dashboard_twobtn.Name = "dashboard_twobtn";
            this.dashboard_twobtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_twobtn.TabIndex = 25;
            this.dashboard_twobtn.Text = "2";
            this.dashboard_twobtn.UseVisualStyleBackColor = false;
            this.dashboard_twobtn.Click += new System.EventHandler(this.dashboard_twobtn_Click);
            // 
            // dashboard_threebtn
            // 
            this.dashboard_threebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_threebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_threebtn.Location = new System.Drawing.Point(525, 246);
            this.dashboard_threebtn.Name = "dashboard_threebtn";
            this.dashboard_threebtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_threebtn.TabIndex = 26;
            this.dashboard_threebtn.Text = "3";
            this.dashboard_threebtn.UseVisualStyleBackColor = false;
            this.dashboard_threebtn.Click += new System.EventHandler(this.dashboard_threebtn_Click);
            // 
            // dashboard_fivebtn
            // 
            this.dashboard_fivebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_fivebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_fivebtn.Location = new System.Drawing.Point(410, 303);
            this.dashboard_fivebtn.Name = "dashboard_fivebtn";
            this.dashboard_fivebtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_fivebtn.TabIndex = 27;
            this.dashboard_fivebtn.Text = "5";
            this.dashboard_fivebtn.UseVisualStyleBackColor = false;
            this.dashboard_fivebtn.Click += new System.EventHandler(this.dashboard_fivebtn_Click);
            // 
            // dashboard_sevenbtn
            // 
            this.dashboard_sevenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_sevenbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_sevenbtn.Location = new System.Drawing.Point(293, 359);
            this.dashboard_sevenbtn.Name = "dashboard_sevenbtn";
            this.dashboard_sevenbtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_sevenbtn.TabIndex = 28;
            this.dashboard_sevenbtn.Text = "7";
            this.dashboard_sevenbtn.UseVisualStyleBackColor = false;
            this.dashboard_sevenbtn.Click += new System.EventHandler(this.dashboard_sevenbtn_Click);
            // 
            // dashboard_fourbtn
            // 
            this.dashboard_fourbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_fourbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_fourbtn.Location = new System.Drawing.Point(293, 303);
            this.dashboard_fourbtn.Name = "dashboard_fourbtn";
            this.dashboard_fourbtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_fourbtn.TabIndex = 29;
            this.dashboard_fourbtn.Text = "4";
            this.dashboard_fourbtn.UseVisualStyleBackColor = false;
            this.dashboard_fourbtn.Click += new System.EventHandler(this.dashboard_fourbtn_Click);
            // 
            // dashboard_zerobtn
            // 
            this.dashboard_zerobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_zerobtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_zerobtn.Location = new System.Drawing.Point(410, 407);
            this.dashboard_zerobtn.Name = "dashboard_zerobtn";
            this.dashboard_zerobtn.Size = new System.Drawing.Size(75, 36);
            this.dashboard_zerobtn.TabIndex = 30;
            this.dashboard_zerobtn.Text = "0";
            this.dashboard_zerobtn.UseVisualStyleBackColor = false;
            this.dashboard_zerobtn.Click += new System.EventHandler(this.dashboard_zerobtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Your Account Balance:";
            // 
            // dashboard_clear
            // 
            this.dashboard_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_clear.Location = new System.Drawing.Point(525, 407);
            this.dashboard_clear.Name = "dashboard_clear";
            this.dashboard_clear.Size = new System.Drawing.Size(75, 36);
            this.dashboard_clear.TabIndex = 32;
            this.dashboard_clear.Text = "Clear";
            this.dashboard_clear.UseVisualStyleBackColor = false;
            this.dashboard_clear.Click += new System.EventHandler(this.dashboard_clear_Click);
            // 
            // dashboard_dot
            // 
            this.dashboard_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_dot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_dot.Location = new System.Drawing.Point(293, 407);
            this.dashboard_dot.Name = "dashboard_dot";
            this.dashboard_dot.Size = new System.Drawing.Size(75, 36);
            this.dashboard_dot.TabIndex = 33;
            this.dashboard_dot.Text = ".";
            this.dashboard_dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboard_dot.UseVisualStyleBackColor = false;
            this.dashboard_dot.Click += new System.EventHandler(this.dashboard_dot_Click);
            // 
            // txtbox2
            // 
            this.txtbox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox2.Location = new System.Drawing.Point(293, 188);
            this.txtbox2.Multiline = true;
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.ReadOnly = true;
            this.txtbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbox2.Size = new System.Drawing.Size(401, 40);
            this.txtbox2.TabIndex = 34;
            this.txtbox2.Text = "0";
            this.txtbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox2.TextChanged += new System.EventHandler(this.txtbox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(291, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 35;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(631, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 197);
            this.button1.TabIndex = 36;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dashborad_enter_Click);
            // 
            // dashboard_transfer
            // 
            this.dashboard_transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboard_transfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboard_transfer.Location = new System.Drawing.Point(33, 134);
            this.dashboard_transfer.Name = "dashboard_transfer";
            this.dashboard_transfer.Size = new System.Drawing.Size(159, 48);
            this.dashboard_transfer.TabIndex = 37;
            this.dashboard_transfer.Text = "Transfer";
            this.dashboard_transfer.UseVisualStyleBackColor = false;
            this.dashboard_transfer.Click += new System.EventHandler(this.dashboard_transfer_Click);
            // 
            // Dashboard_logOutBtn
            // 
            this.Dashboard_logOutBtn.BackColor = System.Drawing.Color.Red;
            this.Dashboard_logOutBtn.ForeColor = System.Drawing.Color.Black;
            this.Dashboard_logOutBtn.Location = new System.Drawing.Point(0, -3);
            this.Dashboard_logOutBtn.Name = "Dashboard_logOutBtn";
            this.Dashboard_logOutBtn.Size = new System.Drawing.Size(75, 32);
            this.Dashboard_logOutBtn.TabIndex = 38;
            this.Dashboard_logOutBtn.Text = "Log out";
            this.Dashboard_logOutBtn.UseVisualStyleBackColor = false;
            this.Dashboard_logOutBtn.Click += new System.EventHandler(this.Dashboard_logOutBtn_Click);
            // 
            // Dashboard_CheckAccountNumber
            // 
            this.Dashboard_CheckAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dashboard_CheckAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.Dashboard_CheckAccountNumber.Location = new System.Drawing.Point(33, 397);
            this.Dashboard_CheckAccountNumber.Name = "Dashboard_CheckAccountNumber";
            this.Dashboard_CheckAccountNumber.Size = new System.Drawing.Size(159, 62);
            this.Dashboard_CheckAccountNumber.TabIndex = 39;
            this.Dashboard_CheckAccountNumber.Text = "Check Account \r\nNumber";
            this.Dashboard_CheckAccountNumber.UseVisualStyleBackColor = false;
            this.Dashboard_CheckAccountNumber.Click += new System.EventHandler(this.Dashboard_CheckAccountNumber_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.Dashboard_CheckAccountNumber);
            this.Controls.Add(this.Dashboard_logOutBtn);
            this.Controls.Add(this.dashboard_transfer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.dashboard_dot);
            this.Controls.Add(this.dashboard_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboard_zerobtn);
            this.Controls.Add(this.dashboard_fourbtn);
            this.Controls.Add(this.dashboard_sevenbtn);
            this.Controls.Add(this.dashboard_fivebtn);
            this.Controls.Add(this.dashboard_threebtn);
            this.Controls.Add(this.dashboard_twobtn);
            this.Controls.Add(this.dashboard_sixbtn);
            this.Controls.Add(this.dashboard_ninebtn);
            this.Controls.Add(this.dashboard_onebtn);
            this.Controls.Add(this.dashboard_eightbtn);
            this.Controls.Add(this.dashboard_pagename);
            this.Controls.Add(this.dashboard_checkbalance);
            this.Controls.Add(this.dashboard_deposit);
            this.Controls.Add(this.dashboard_withdraw);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button dashboard_withdraw;
        private System.Windows.Forms.Button dashboard_deposit;
        private System.Windows.Forms.Button dashboard_checkbalance;
        private System.Windows.Forms.Label dashboard_pagename;
        private System.Windows.Forms.Button dashboard_eightbtn;
        private System.Windows.Forms.Button dashboard_onebtn;
        private System.Windows.Forms.Button dashboard_ninebtn;
        private System.Windows.Forms.Button dashboard_sixbtn;
        private System.Windows.Forms.Button dashboard_twobtn;
        private System.Windows.Forms.Button dashboard_threebtn;
        private System.Windows.Forms.Button dashboard_fivebtn;
        private System.Windows.Forms.Button dashboard_sevenbtn;
        private System.Windows.Forms.Button dashboard_fourbtn;
        private System.Windows.Forms.Button dashboard_zerobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard_clear;
        private System.Windows.Forms.Button dashboard_dot;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dashboard_transfer;
        private System.Windows.Forms.Button Dashboard_logOutBtn;
        private System.Windows.Forms.Button Dashboard_CheckAccountNumber;
    }
}