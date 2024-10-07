namespace Banka
{
    partial class loginPage
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
            this.login_btn = new System.Windows.Forms.Button();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_signupLink = new System.Windows.Forms.LinkLabel();
            this.login_closeBtn = new System.Windows.Forms.Button();
            this.login_showPassword = new System.Windows.Forms.CheckBox();
            this.login_forgetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkOrchid;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(426, 304);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(121, 45);
            this.login_btn.TabIndex = 22;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(426, 220);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(319, 30);
            this.login_password.TabIndex = 17;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(426, 153);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(319, 30);
            this.login_username.TabIndex = 16;
            this.login_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome Back!";
            this.label1.Click += new System.EventHandler(this.login_forgetPasswordLink_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Don\'t Have An Account?";
            // 
            // login_signupLink
            // 
            this.login_signupLink.AutoSize = true;
            this.login_signupLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.login_signupLink.Location = new System.Drawing.Point(615, 379);
            this.login_signupLink.Name = "login_signupLink";
            this.login_signupLink.Size = new System.Drawing.Size(108, 20);
            this.login_signupLink.TabIndex = 24;
            this.login_signupLink.TabStop = true;
            this.login_signupLink.Text = "Register Here";
            this.login_signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login_closeBtn
            // 
            this.login_closeBtn.BackColor = System.Drawing.Color.Red;
            this.login_closeBtn.Location = new System.Drawing.Point(756, -3);
            this.login_closeBtn.Name = "login_closeBtn";
            this.login_closeBtn.Size = new System.Drawing.Size(29, 28);
            this.login_closeBtn.TabIndex = 25;
            this.login_closeBtn.Text = "X";
            this.login_closeBtn.UseVisualStyleBackColor = false;
            this.login_closeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_showPassword
            // 
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.Location = new System.Drawing.Point(426, 260);
            this.login_showPassword.Name = "login_showPassword";
            this.login_showPassword.Size = new System.Drawing.Size(148, 24);
            this.login_showPassword.TabIndex = 26;
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.UseVisualStyleBackColor = true;
            this.login_showPassword.CheckedChanged += new System.EventHandler(this.login_showPassword_CheckedChanged);
            // 
            // login_forgetPasswordLink
            // 
            this.login_forgetPasswordLink.AutoSize = true;
            this.login_forgetPasswordLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.login_forgetPasswordLink.Location = new System.Drawing.Point(615, 261);
            this.login_forgetPasswordLink.Name = "login_forgetPasswordLink";
            this.login_forgetPasswordLink.Size = new System.Drawing.Size(138, 20);
            this.login_forgetPasswordLink.TabIndex = 27;
            this.login_forgetPasswordLink.TabStop = true;
            this.login_forgetPasswordLink.Text = "Forget Password?";
            this.login_forgetPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_forgetPasswordLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(112, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 46);
            this.label5.TabIndex = 2;
            this.label5.Text = "Banka ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 473);
            this.panel1.TabIndex = 1;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.login_forgetPasswordLink);
            this.Controls.Add(this.login_showPassword);
            this.Controls.Add(this.login_closeBtn);
            this.Controls.Add(this.login_signupLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel login_signupLink;
        private System.Windows.Forms.Button login_closeBtn;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.LinkLabel login_forgetPasswordLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}