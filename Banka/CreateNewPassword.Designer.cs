namespace Banka
{
    partial class createNewPassword_page
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
            this.createNewPassword_closebtn = new System.Windows.Forms.Button();
            this.createNewPassword_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createNewPassword_submitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewPassword_backBtn = new System.Windows.Forms.Button();
            this.createNewPassword_showPasswordBtn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // createNewPassword_closebtn
            // 
            this.createNewPassword_closebtn.BackColor = System.Drawing.Color.Red;
            this.createNewPassword_closebtn.ForeColor = System.Drawing.Color.Black;
            this.createNewPassword_closebtn.Location = new System.Drawing.Point(756, -3);
            this.createNewPassword_closebtn.Name = "createNewPassword_closebtn";
            this.createNewPassword_closebtn.Size = new System.Drawing.Size(29, 30);
            this.createNewPassword_closebtn.TabIndex = 15;
            this.createNewPassword_closebtn.Text = "X";
            this.createNewPassword_closebtn.UseVisualStyleBackColor = false;
            this.createNewPassword_closebtn.Click += new System.EventHandler(this.createnewpassword_closebtn_Click);
            // 
            // createNewPassword_textBox1
            // 
            this.createNewPassword_textBox1.BackColor = System.Drawing.Color.White;
            this.createNewPassword_textBox1.Location = new System.Drawing.Point(183, 229);
            this.createNewPassword_textBox1.Name = "createNewPassword_textBox1";
            this.createNewPassword_textBox1.PasswordChar = '*';
            this.createNewPassword_textBox1.Size = new System.Drawing.Size(388, 29);
            this.createNewPassword_textBox1.TabIndex = 16;
            this.createNewPassword_textBox1.TextChanged += new System.EventHandler(this.createnewpassword_textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(178, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "New Password:";
            // 
            // createNewPassword_submitbtn
            // 
            this.createNewPassword_submitbtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.createNewPassword_submitbtn.ForeColor = System.Drawing.Color.White;
            this.createNewPassword_submitbtn.Location = new System.Drawing.Point(297, 307);
            this.createNewPassword_submitbtn.Name = "createNewPassword_submitbtn";
            this.createNewPassword_submitbtn.Size = new System.Drawing.Size(116, 47);
            this.createNewPassword_submitbtn.TabIndex = 18;
            this.createNewPassword_submitbtn.Text = "Change ";
            this.createNewPassword_submitbtn.UseVisualStyleBackColor = false;
            this.createNewPassword_submitbtn.Click += new System.EventHandler(this.createnewpassword_submitbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(218, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Create A New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // createNewPassword_backBtn
            // 
            this.createNewPassword_backBtn.BackColor = System.Drawing.Color.Red;
            this.createNewPassword_backBtn.ForeColor = System.Drawing.Color.Black;
            this.createNewPassword_backBtn.Location = new System.Drawing.Point(-2, -1);
            this.createNewPassword_backBtn.Name = "createNewPassword_backBtn";
            this.createNewPassword_backBtn.Size = new System.Drawing.Size(55, 27);
            this.createNewPassword_backBtn.TabIndex = 24;
            this.createNewPassword_backBtn.Text = "Back";
            this.createNewPassword_backBtn.UseVisualStyleBackColor = false;
            this.createNewPassword_backBtn.Click += new System.EventHandler(this.createNewPassword_backBtn_Click);
            // 
            // createNewPassword_showPasswordBtn
            // 
            this.createNewPassword_showPasswordBtn.AutoSize = true;
            this.createNewPassword_showPasswordBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewPassword_showPasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.createNewPassword_showPasswordBtn.Location = new System.Drawing.Point(183, 264);
            this.createNewPassword_showPasswordBtn.Name = "createNewPassword_showPasswordBtn";
            this.createNewPassword_showPasswordBtn.Size = new System.Drawing.Size(165, 25);
            this.createNewPassword_showPasswordBtn.TabIndex = 25;
            this.createNewPassword_showPasswordBtn.Text = "Show Password";
            this.createNewPassword_showPasswordBtn.UseVisualStyleBackColor = true;
            this.createNewPassword_showPasswordBtn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // createNewPassword_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 471);
            this.Controls.Add(this.createNewPassword_showPasswordBtn);
            this.Controls.Add(this.createNewPassword_backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createNewPassword_submitbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createNewPassword_textBox1);
            this.Controls.Add(this.createNewPassword_closebtn);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createNewPassword_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewPassword";
            this.Load += new System.EventHandler(this.CreateNewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createNewPassword_closebtn;
        private System.Windows.Forms.TextBox createNewPassword_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createNewPassword_submitbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createNewPassword_backBtn;
        private System.Windows.Forms.CheckBox createNewPassword_showPasswordBtn;
    }
}