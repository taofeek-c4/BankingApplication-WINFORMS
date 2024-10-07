using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace Banka
{
    public partial class signupPage : Form
    {
        public signupPage()
        {
            InitializeComponent();
            signupPage_email.KeyDown    += new KeyEventHandler(textBox_KeyDown);
            signupPage_username.KeyDown += new KeyEventHandler(textBox_KeyDown);
            signupPage_password.KeyDown += new KeyEventHandler(textBox_KeyDown);
        }

        SqlConnection conn = new SqlConnection(@"Data Source=FCMBDIG-LT17323\SQLEXPRESS;Initial Catalog=BankaDB;Integrated Security=True;");

        private void signupPage_Load(object sender, EventArgs e)
        {
            signupPage_RegisterHere.Enabled = false;
            signupPage_email.Focus();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool AccountNumberExistsInDB(string accountNumber)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM Users WHERE Account_Number = @AccountNumber";

            using (SqlConnection conn = new SqlConnection(@"Data Source=FCMBDIG-LT17323\SQLEXPRESS;Initial Catalog=BankaDB;Integrated Security=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            exists = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return exists;
        }

        public string GenerateUniqueAccountNumber()
        {
            string accountNumber = "";
            bool isUnique = false;

            while (!isUnique)
            {
                Random random = new Random();
                accountNumber = random.Next(000001, 99999).ToString() + random.Next(000001, 99999).ToString();
                if (!AccountNumberExistsInDB(accountNumber))
                {
                    isUnique = true;
                }
            }
            return accountNumber;
        }

        private void signupPage_RegisterHere_Click(object sender, EventArgs e)
        {
            string emailPattern    = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string usernamePattern = @"^[a-zA-Z0-9]+$";
            string passwordPattern = @"^[a-zA-Z0-9@\#\$\-]+$";

            if (!Regex.IsMatch(signupPage_email.Text, emailPattern))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(!Regex.IsMatch(signupPage_username.Text, usernamePattern))
            {
                MessageBox.Show("Invalid username format, Just Alphanumeric Allowed", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(!Regex.IsMatch(signupPage_password.Text, passwordPattern))
            {
                MessageBox.Show("Invalid password. Only letters, digits, and special characters '@', '#', '$', '-' are allowed.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (signupPage_email.Text == "")
            {
                MessageBox.Show("Email must be filled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (signupPage_username.Text == "")
            {
                MessageBox.Show("Username must be filled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (signupPage_password.Text == "")
            {
                MessageBox.Show("Password must be filled!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (conn.State != ConnectionState.Open)
            {
                try
                {   
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Username = '" + signupPage_username.Text.Trim() + "'";
                    
                    using (SqlCommand CheckUser = new SqlCommand(query,conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(CheckUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show(signupPage_username.Text + "\nThis record already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            string accountNumber = GenerateUniqueAccountNumber();
                            string hashedPassword = HashPassword(signupPage_password.Text.Trim());
                            string insertData = "INSERT INTO Users (Email, Username, Password, Date_created, Account_Number)" +
                                                "VALUES(@Email, @Username,@Password, @Date_created, @Account_Number)";
                           
                            DateTime date = DateTime.Now;  
                           
                            using (SqlCommand cmd = new SqlCommand(insertData , conn))
                            {
                                cmd.Parameters.AddWithValue("@Email",    signupPage_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@Username", signupPage_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                                cmd.Parameters.AddWithValue("@Account_Number", accountNumber);
                                cmd.Parameters.AddWithValue("@Date_created", date);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered Successfully","Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loginPage login = new loginPage();
                                login.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting to the database" + ex, "Error message",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static string HashPassword(string password)
        {
           byte[] salt = new byte[16];
           using (var rng = new RNGCryptoServiceProvider())
           {
             rng.GetBytes(salt);
           }
           var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
           byte[] hash = pbkdf2.GetBytes(20);
           byte[] hashBytes = new byte[36];
           Array.Copy(salt, 0, hashBytes, 0, 16); 
           Array.Copy(hash, 0, hashBytes, 16, 20); 
           return Convert.ToBase64String(hashBytes);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            signupPage_RegisterHere.Enabled = signupPage_checkbox.Checked;
            if (!signupPage_checkbox.Checked)
            {
                MessageBox.Show("Please agree to the terms and conditions.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void signup_loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPage Form2 = new loginPage();
            Form2.Show();
            this.Hide();
        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (signupPage_showPassword.Checked)
            {
                signupPage_password.PasswordChar = '\0';
            }
            else
            {
                signupPage_password.PasswordChar = '*';
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void signup_email_TextChanged(object sender, EventArgs e)
        {
            signupPage_email.MaxLength = 255;
            if (signupPage_email.Text.Length > 255)
            {
                MessageBox.Show("Maximum 255 characters allowed!");
                signupPage_email.Text = signupPage_email.Text.Substring(0, 255);
            }
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {
            signupPage_username.MaxLength = 50;
            if (signupPage_username.Text.Length > 50)
            {
                MessageBox.Show("Maximum 50 characters allowed!");
                signupPage_username.Text = signupPage_username.Text.Substring(0, 50);
            }
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            signupPage_password.MaxLength = 50;
            if (signupPage_password.Text.Length > 50)
            {
                MessageBox.Show("Maximum 50 characters allowed!");
                signupPage_password.Text = signupPage_password.Text.Substring(0, 50);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signupPage_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
