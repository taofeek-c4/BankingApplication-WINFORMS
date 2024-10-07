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

namespace Banka
{
    public partial class forgetPassword : Form
    {
        public forgetPassword()
        {
            InitializeComponent();
            forgetEmail_textBox1.KeyDown += new KeyEventHandler(textBox_KeyDown);
            forgetPassword_textBox2.KeyDown += new KeyEventHandler(textBox_KeyDown);
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

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
        }

        private void forgetpassword_closebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void forgetPassword_submitBtn_Click(object sender, EventArgs e)
        {
            if (forgetEmail_textBox1.Text == "" || forgetPassword_textBox2.Text == "")
            {
                MessageBox.Show("Username and Password must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string verifiedUsername = forgetPassword_textBox2.Text;
                    string query = "SELECT Password FROM Users WHERE Email = @Email AND Username = @Username";

                    using (SqlCommand CheckUser = new SqlCommand(query, conn))
                    {
                        CheckUser.Parameters.AddWithValue("@Email", forgetEmail_textBox1.Text.Trim());
                        CheckUser.Parameters.AddWithValue("@Username", forgetPassword_textBox2.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(CheckUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Almost there!!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            createNewPassword_page createNewPassword = new createNewPassword_page(verifiedUsername);
                            createNewPassword.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("This record doesnt exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Connecting.." + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void forgetpassword_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgetPassword_backBtn_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.Show();
            this.Show();
        }

        private void forgetPassword_textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
