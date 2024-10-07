using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Banka
{
    public partial class Dashboard : Form
    {
        private string  verifiedUsername;
        private string  accountNumber;
        public Dashboard(string Username, string accountNumber)   
        {
            InitializeComponent();
            this.verifiedUsername = Username;
            this.accountNumber = accountNumber;    
        }

        SqlConnection conn = new SqlConnection(@"Data Source=FCMBDIG-LT17323\SQLEXPRESS;Initial Catalog=BankaDB;Integrated Security=True;");

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txtbox1.Enabled = false;
            txtbox2.Enabled = false;

            try
            {
                conn.Open();
                string query = "SELECT Account_Balance FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", verifiedUsername); 
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        decimal currentBalance = Convert.ToDecimal(result);
                        txtbox1.Text = currentBalance.ToString();
                        Account.UserDefaultBalance = currentBalance; 
                    }
                    else
                    {
                        MessageBox.Show("Could not retrieve balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading account balance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_onebtn_Click_1(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "1";
            }
            else
            {
                txtbox2.Text += "1";
            }
        }

        private void dashboard_twobtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "2";
            }
            else
            {
                txtbox2.Text += "2";
            }
        }

        private void dashboard_threebtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "3";
            }
            else
            {
                txtbox2.Text += "3";
            }
        }

        private void dashboard_fourbtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "4";
            }
            else
            {
                txtbox2.Text += "4";
            }
        }

        private void dashboard_fivebtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "5";
            }
            else
            {
                txtbox2.Text += "5";
            }
        }

        private void dashboard_sixbtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "6";
            }
            else
            {
                txtbox2.Text += "6";
            }
        }

        private void dashboard_sevenbtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "7";
            }
            else
            {
                txtbox2.Text += "7";
            }
        }

        private void dashboard_eightbtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "8";
            }
            else
            {
                txtbox2.Text += "8";
            }
        }

        private void dashboard_ninebtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "9";
            }
            else
            {
                txtbox2.Text += "9";
            }
        }

        private void dashboard_zerobtn_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "0")
            {
                txtbox2.Text = "0";
            }
            else
            {
                txtbox2.Text += "0";
            }
        }

        private void dashboard_clear_Click(object sender, EventArgs e)
        {
            txtbox2.Clear();
        }

        private void dashboard_dot_Click(object sender, EventArgs e)
        {
            if (!txtbox2.Text.Contains("."))
            {
                txtbox2.Text += ".";
            }
        }

        private void dashboard_checkbalance_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Your Balance is {txtbox1.Text}", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         
        }

        private void dashboard_deposit_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Enter The Amount to Deposit", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                Account.ActionStatus = "D";
                txtbox2.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dashboard_withdraw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter The Amount to Withdraw", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                Account.ActionStatus = "W";
                txtbox2.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {
            txtbox2.MaxLength = 10;
            if (txtbox2.Text.Length > 10)
            {
                MessageBox.Show("Maximum 10 characters allowed!");
                txtbox2.Text = txtbox2.Text.Substring(0, 10);
            }
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            txtbox1.MaxLength = 15;
            if (txtbox1.Text.Length > 15)
            {
                MessageBox.Show("Your Account has Exceeded the Limit!");
                txtbox1.Text = txtbox2.Text.Substring(0, 15);
            }
        }

        private void UpdateBalanceInDatabase(string verifiedUsername, decimal currentBalance)
        {
            try
            {
                conn.Open();
                string updateQuery = "UPDATE Users SET Account_Balance = @currentBalance WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@currentBalance", currentBalance);
                    cmd.Parameters.AddWithValue("@Username", verifiedUsername);
                    MessageBox.Show("wjewhhd");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account balance updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update account balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating balance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dashborad_enter_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(txtbox2.Text); 
                decimal currentBalance = Account.UserDefaultBalance;

                switch (Account.ActionStatus)
                {
                    case "D": 
                        currentBalance += amount;
                        Account.UserDefaultBalance = currentBalance;
                        txtbox1.Text = Account.UserDefaultBalance.ToString();
                        MessageBox.Show($"You have deposited {txtbox2.Text}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "W":  
                        if (amount > currentBalance)
                        {
                            MessageBox.Show("Insufficient Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtbox2.Clear();
                            return;
                        }
                        else
                        {
                            currentBalance -= amount;
                            Account.UserDefaultBalance = currentBalance;
                            txtbox1.Text = Account.UserDefaultBalance.ToString();
                            MessageBox.Show($"You have withdrawn {txtbox2.Text} from your account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    default:
                        MessageBox.Show("Select Transaction Mode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }
                UpdateBalanceInDatabase(verifiedUsername, currentBalance);
                txtbox2.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void dashboard_transfer_Click(object sender, EventArgs e)
        {
            string senderAccountNumber = UserSession.SenderAccountNumber;

            TransferPage transferPage = new TransferPage(UserSession.VerifiedUsername, senderAccountNumber);
            transferPage.Show();
            this.Hide();
        }


        private void Dashboard_logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Log out", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            loginPage loginPage = new loginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Dashboard_CheckAccountNumber_Click(object sender, EventArgs e)
        {
            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Account_Number FROM Users WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", verifiedUsername);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string accountNumber = result.ToString();
                            MessageBox.Show("Your Account Number is: " + accountNumber, "Account Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving account number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_onebtn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
