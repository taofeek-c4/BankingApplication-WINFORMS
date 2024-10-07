namespace Banka
{
    partial class forgetPassword
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
            this.forgetPassword_closebtn = new System.Windows.Forms.Button();
            this.forgetEmail_textBox1 = new System.Windows.Forms.TextBox();
            this.forgetPassword_textBox2 = new System.Windows.Forms.TextBox();
            this.forgetpassword_usernamelabel = new System.Windows.Forms.Label();
            this.forgetpassword_emailLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgetPassword_submitBtn = new System.Windows.Forms.Button();
            this.forgetPassword_backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forgetPassword_closebtn
            // 
            this.forgetPassword_closebtn.BackColor = System.Drawing.Color.Red;
            this.forgetPassword_closebtn.ForeColor = System.Drawing.Color.Black;
            this.forgetPassword_closebtn.Location = new System.Drawing.Point(756, -3);
            this.forgetPassword_closebtn.Name = "forgetPassword_closebtn";
            this.forgetPassword_closebtn.Size = new System.Drawing.Size(29, 30);
            this.forgetPassword_closebtn.TabIndex = 13;
            this.forgetPassword_closebtn.Text = "X";
            this.forgetPassword_closebtn.UseVisualStyleBackColor = false;
            this.forgetPassword_closebtn.Click += new System.EventHandler(this.forgetpassword_closebtn_Click);
            // 
            // forgetEmail_textBox1
            // 
            this.forgetEmail_textBox1.BackColor = System.Drawing.Color.White;
            this.forgetEmail_textBox1.Location = new System.Drawing.Point(193, 182);
            this.forgetEmail_textBox1.Name = "forgetEmail_textBox1";
            this.forgetEmail_textBox1.Size = new System.Drawing.Size(403, 29);
            this.forgetEmail_textBox1.TabIndex = 14;
            this.forgetEmail_textBox1.TextChanged += new System.EventHandler(this.forgetpassword_textBox1_TextChanged);
            // 
            // forgetPassword_textBox2
            // 
            this.forgetPassword_textBox2.BackColor = System.Drawing.Color.White;
            this.forgetPassword_textBox2.Location = new System.Drawing.Point(192, 243);
            this.forgetPassword_textBox2.Name = "forgetPassword_textBox2";
            this.forgetPassword_textBox2.Size = new System.Drawing.Size(403, 29);
            this.forgetPassword_textBox2.TabIndex = 15;
            this.forgetPassword_textBox2.TextChanged += new System.EventHandler(this.forgetPassword_textBox2_TextChanged);
            // 
            // forgetpassword_usernamelabel
            // 
            this.forgetpassword_usernamelabel.AutoSize = true;
            this.forgetpassword_usernamelabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassword_usernamelabel.ForeColor = System.Drawing.Color.Black;
            this.forgetpassword_usernamelabel.Location = new System.Drawing.Point(187, 213);
            this.forgetpassword_usernamelabel.Name = "forgetpassword_usernamelabel";
            this.forgetpassword_usernamelabel.Size = new System.Drawing.Size(103, 27);
            this.forgetpassword_usernamelabel.TabIndex = 16;
            this.forgetpassword_usernamelabel.Text = "Username:";
            // 
            // forgetpassword_emailLabel
            // 
            this.forgetpassword_emailLabel.AutoSize = true;
            this.forgetpassword_emailLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassword_emailLabel.ForeColor = System.Drawing.Color.Black;
            this.forgetpassword_emailLabel.Location = new System.Drawing.Point(188, 152);
            this.forgetpassword_emailLabel.Name = "forgetpassword_emailLabel";
            this.forgetpassword_emailLabel.Size = new System.Drawing.Size(63, 27);
            this.forgetpassword_emailLabel.TabIndex = 17;
            this.forgetpassword_emailLabel.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(255, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Forget Password?";
            // 
            // forgetPassword_submitBtn
            // 
            this.forgetPassword_submitBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.forgetPassword_submitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.forgetPassword_submitBtn.Location = new System.Drawing.Point(192, 291);
            this.forgetPassword_submitBtn.Name = "forgetPassword_submitBtn";
            this.forgetPassword_submitBtn.Size = new System.Drawing.Size(97, 39);
            this.forgetPassword_submitBtn.TabIndex = 19;
            this.forgetPassword_submitBtn.Text = "Submit";
            this.forgetPassword_submitBtn.UseVisualStyleBackColor = false;
            this.forgetPassword_submitBtn.Click += new System.EventHandler(this.forgetPassword_submitBtn_Click);
            // 
            // forgetPassword_backBtn
            // 
            this.forgetPassword_backBtn.BackColor = System.Drawing.Color.Red;
            this.forgetPassword_backBtn.ForeColor = System.Drawing.Color.Black;
            this.forgetPassword_backBtn.Location = new System.Drawing.Point(-1, 0);
            this.forgetPassword_backBtn.Name = "forgetPassword_backBtn";
            this.forgetPassword_backBtn.Size = new System.Drawing.Size(55, 27);
            this.forgetPassword_backBtn.TabIndex = 24;
            this.forgetPassword_backBtn.Text = "Back";
            this.forgetPassword_backBtn.UseVisualStyleBackColor = false;
            this.forgetPassword_backBtn.Click += new System.EventHandler(this.forgetPassword_backBtn_Click);
            // 
            // forgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.forgetPassword_backBtn);
            this.Controls.Add(this.forgetPassword_submitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgetpassword_emailLabel);
            this.Controls.Add(this.forgetpassword_usernamelabel);
            this.Controls.Add(this.forgetPassword_textBox2);
            this.Controls.Add(this.forgetEmail_textBox1);
            this.Controls.Add(this.forgetPassword_closebtn);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgetPassword_closebtn;
        private System.Windows.Forms.TextBox forgetEmail_textBox1;
        private System.Windows.Forms.TextBox forgetPassword_textBox2;
        private System.Windows.Forms.Label forgetpassword_usernamelabel;
        private System.Windows.Forms.Label forgetpassword_emailLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button forgetPassword_submitBtn;
        private System.Windows.Forms.Button forgetPassword_backBtn;
    }
}