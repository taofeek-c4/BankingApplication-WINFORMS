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
using System.Security.Cryptography;
using Banka;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Banka
{
    public partial class createNewPassword_page : Form
    {
        private string verifiedUsername;
        public createNewPassword_page(string Username)
        {
            InitializeComponent();
            createNewPassword_textBox1.KeyDown += new KeyEventHandler(textBox_KeyDown);
            verifiedUsername = Username;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=FCMBDIG-LT17323\SQLEXPRESS;Initial Catalog=BankaDB;Integrated Security=True;");

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void CreateNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void createnewpassword_closebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            Application.Exit();
        }

        public static string HashPassword(string password)
        {
            // Generate a salt

            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Hash the password with the salt using PBKDF2

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20); // Hashing the password

            // Combine salt and hash for storage
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16); // Store the salt first
            Array.Copy(hash, 0, hashBytes, 16, 20); // Then the password hash

            // Convert to a base64 string for easy storage
            return Convert.ToBase64String(hashBytes);
        }

        private void createnewpassword_submitbtn_Click(object sender, EventArgs e)
        {
            // Check if password field is empty
            if (createNewPassword_textBox1.Text == "")
            {
                MessageBox.Show("Password must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the new password
            string hashedPassword = HashPassword(createNewPassword_textBox1.Text);

            // Proceed with updating the password in the database
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    // Use the stored verified username for the update query
                    string updateQuery = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Username", verifiedUsername); // Use the verified username

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("You have successfully changed your password!\nNow proceed to login",
                                            "Success Message",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // Navigate to login page
                            loginPage loginPage = new loginPage();
                            loginPage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: Username not found or password change failed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void createnewpassword_textBox1_TextChanged(object sender, EventArgs e)
        {
            createNewPassword_textBox1.MaxLength = 50;
            if (createNewPassword_textBox1.Text.Length > 50)
            {
                MessageBox.Show("The lenth exceeded!");
                createNewPassword_textBox1.Text = createNewPassword_textBox1.Text.Substring(0, 50);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createNewPassword_backBtn_Click(object sender, EventArgs e)
        {
            forgetPassword forgetPassword = new forgetPassword();
            forgetPassword.Show();
            this.Hide();
        }

        private void forgetpassword_closebtn_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (createNewPassword_showPasswordBtn.Checked)
            {
                createNewPassword_textBox1.PasswordChar = '\0';
            }
            else
            {
                createNewPassword_textBox1.PasswordChar = '*';
            }
        }
    }
}
