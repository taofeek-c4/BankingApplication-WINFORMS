using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banka
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            login_username.KeyDown += new KeyEventHandler(textBox_KeyDown);
            login_password.KeyDown += new KeyEventHandler(textBox_KeyDown);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=FCMBDIG-LT17323\SQLEXPRESS;Initial Catalog=BankaDB;Integrated Security=True;");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupPage signupPage = new signupPage();
            signupPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Check if username and password fields are filled
            if (string.IsNullOrWhiteSpace(login_username.Text))
            {
                MessageBox.Show("Username must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Password must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string verifiedUsername = login_username.Text;
                string password = login_password.Text;

                string query = "SELECT Account_Number, Password FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", verifiedUsername);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["Password"].ToString();

                            // Verify the provided password against the stored hash
                            if (VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show("Logged in successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Store the account number and verified username for further use
                                UserSession.VerifiedUsername = verifiedUsername;
                                UserSession.SenderAccountNumber = reader["Account_Number"].ToString(); 

                                Dashboard dboard = new Dashboard(verifiedUsername, UserSession.SenderAccountNumber);
                                dboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username/Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username/Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPassword.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
            login_username.MaxLength = 50;
            if(login_username.Text.Length > 50)
            {
                MessageBox.Show("The lenth exceeded!");
                login_username.Text = login_username.Text.Substring(0, 50);
            }
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.MaxLength = 50;
            if (login_password.Text.Length > 50)
            {
                MessageBox.Show("The lenth exceeded!");
                login_password.Text = login_password.Text.Substring(0, 50);
            }
        }

        private void login_forgetPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPassword forgetPassword = new forgetPassword();
            forgetPassword.Show();
            this.Hide();
            MessageBox.Show("Enter your Email and Username ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void login_forgetPasswordLink_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
