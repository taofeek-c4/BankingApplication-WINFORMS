namespace Banka
{
    partial class signupPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signupPage_RegisterHere = new System.Windows.Forms.Button();
            this.signupPage_closeBtn = new System.Windows.Forms.Button();
            this.signupPage_checkbox = new System.Windows.Forms.CheckBox();
            this.signupPage_loginlink = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.signupPage_showPassword = new System.Windows.Forms.CheckBox();
            this.signupPage_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signupPage_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signupPage_password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 474);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // signupPage_RegisterHere
            // 
            this.signupPage_RegisterHere.BackColor = System.Drawing.Color.DarkOrchid;
            this.signupPage_RegisterHere.ForeColor = System.Drawing.Color.White;
            this.signupPage_RegisterHere.Location = new System.Drawing.Point(427, 351);
            this.signupPage_RegisterHere.Name = "signupPage_RegisterHere";
            this.signupPage_RegisterHere.Size = new System.Drawing.Size(111, 39);
            this.signupPage_RegisterHere.TabIndex = 10;
            this.signupPage_RegisterHere.Text = "Sign Up";
            this.signupPage_RegisterHere.UseVisualStyleBackColor = false;
            this.signupPage_RegisterHere.Click += new System.EventHandler(this.signupPage_RegisterHere_Click);
            // 
            // signupPage_closeBtn
            // 
            this.signupPage_closeBtn.BackColor = System.Drawing.Color.Red;
            this.signupPage_closeBtn.Location = new System.Drawing.Point(756, -3);
            this.signupPage_closeBtn.Name = "signupPage_closeBtn";
            this.signupPage_closeBtn.Size = new System.Drawing.Size(29, 28);
            this.signupPage_closeBtn.TabIndex = 11;
            this.signupPage_closeBtn.Text = "X";
            this.signupPage_closeBtn.UseVisualStyleBackColor = false;
            this.signupPage_closeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // signupPage_checkbox
            // 
            this.signupPage_checkbox.AutoSize = true;
            this.signupPage_checkbox.Location = new System.Drawing.Point(427, 321);
            this.signupPage_checkbox.Name = "signupPage_checkbox";
            this.signupPage_checkbox.Size = new System.Drawing.Size(316, 24);
            this.signupPage_checkbox.TabIndex = 12;
            this.signupPage_checkbox.Text = "Click to accept the terms and conditions";
            this.signupPage_checkbox.UseVisualStyleBackColor = true;
            this.signupPage_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // signupPage_loginlink
            // 
            this.signupPage_loginlink.AutoSize = true;
            this.signupPage_loginlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.signupPage_loginlink.LinkColor = System.Drawing.Color.Blue;
            this.signupPage_loginlink.Location = new System.Drawing.Point(633, 402);
            this.signupPage_loginlink.Name = "signupPage_loginlink";
            this.signupPage_loginlink.Size = new System.Drawing.Size(133, 20);
            this.signupPage_loginlink.TabIndex = 13;
            this.signupPage_loginlink.TabStop = true;
            this.signupPage_loginlink.Text = "Click here to login";
            this.signupPage_loginlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_loginlink_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Already Have An Account?";
            // 
            // signupPage_showPassword
            // 
            this.signupPage_showPassword.AutoSize = true;
            this.signupPage_showPassword.Location = new System.Drawing.Point(599, 283);
            this.signupPage_showPassword.Name = "signupPage_showPassword";
            this.signupPage_showPassword.Size = new System.Drawing.Size(148, 24);
            this.signupPage_showPassword.TabIndex = 17;
            this.signupPage_showPassword.Text = "Show Password";
            this.signupPage_showPassword.UseVisualStyleBackColor = true;
            this.signupPage_showPassword.CheckedChanged += new System.EventHandler(this.signup_showPassword_CheckedChanged);
            // 
            // signupPage_email
            // 
            this.signupPage_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupPage_email.Location = new System.Drawing.Point(427, 117);
            this.signupPage_email.Name = "signupPage_email";
            this.signupPage_email.Size = new System.Drawing.Size(319, 26);
            this.signupPage_email.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email:";
            // 
            // signupPage_username
            // 
            this.signupPage_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupPage_username.Location = new System.Drawing.Point(427, 185);
            this.signupPage_username.Name = "signupPage_username";
            this.signupPage_username.Size = new System.Drawing.Size(319, 26);
            this.signupPage_username.TabIndex = 23;
            this.signupPage_username.TextChanged += new System.EventHandler(this.signupPage_username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Username:";
            // 
            // signupPage_password
            // 
            this.signupPage_password.Location = new System.Drawing.Point(428, 251);
            this.signupPage_password.Name = "signupPage_password";
            this.signupPage_password.PasswordChar = '*';
            this.signupPage_password.Size = new System.Drawing.Size(319, 26);
            this.signupPage_password.TabIndex = 24;
            // 
            // signupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.signupPage_password);
            this.Controls.Add(this.signupPage_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signupPage_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.signupPage_showPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signupPage_loginlink);
            this.Controls.Add(this.signupPage_checkbox);
            this.Controls.Add(this.signupPage_closeBtn);
            this.Controls.Add(this.signupPage_RegisterHere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.signupPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signupPage_RegisterHere;
        private System.Windows.Forms.Button signupPage_closeBtn;
        private System.Windows.Forms.CheckBox signupPage_checkbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel signupPage_loginlink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox signupPage_showPassword;
        private System.Windows.Forms.TextBox signupPage_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox signupPage_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signupPage_password;
    }
}

