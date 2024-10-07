using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class TransferPage : Form
    {
        string recipientAccountName;
        private string verifiedUsername;    
        private string accountNumber;    

        SqlConnection conn = new SqlConnection(@"Data Source=FCMBDIG-LT17323\SQLEXPRESS;Initial Catalog=BankaDB;Integrated Security=True;");
        public TransferPage(string Username, string accNumber)
        {
            InitializeComponent();
            transferPage_textBox1.KeyDown += new KeyEventHandler(textBox_KeyDown);
            transferPage_textBox2.KeyDown += new KeyEventHandler(textBox_KeyDown);
            this.verifiedUsername = Username;
            this.accountNumber = accNumber;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
        private void transferPage_closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            Application.Exit();
        }

        private void transfer_backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard  = new Dashboard(verifiedUsername , accountNumber);
            dashboard.Show();
            this.Hide();
        }

        private void transfer_sendMoneyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(transferPage_textBox2.Text))
            {
                MessageBox.Show("Account number must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(transferPage_textBox2.Text))
            {
                MessageBox.Show("Amount must be filled!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try parsing the entered amount to a decimal
            decimal amount;
            if (!Decimal.TryParse(transferPage_textBox2.Text, out amount))
            {
                MessageBox.Show("Please enter a valid numeric amount!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal transferAmount = decimal.Parse(transferPage_textBox2.Text);

            string recieverAccountNumber = transferPage_textBox1.Text;
            string senderAccountNumber = UserSession.SenderAccountNumber;

            if (!decimal.TryParse(transferPage_textBox2.Text, out transferAmount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(recieverAccountNumber))
            {
                MessageBox.Show("Please enter a valid account number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(recipientAccountName))
            {
                MessageBox.Show("Please verify the recipient's account before sending money.", "Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (senderAccountNumber == recieverAccountNumber)
            {
                MessageBox.Show("Sender and receiver accounts cannot be the same.", "Invalid Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlTransaction transaction = conn.BeginTransaction();

                SqlCommand senderCommand = new SqlCommand("SELECT Account_Balance FROM Users WHERE Account_Number = @senderAccountNumber", conn, transaction);
                senderCommand.Parameters.AddWithValue("@senderAccountNumber", senderAccountNumber);

                object senderBalanceObj = senderCommand.ExecuteScalar();

                if (senderBalanceObj == null)
                {
                    MessageBox.Show("Sender account does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    return;
                }

                decimal senderBalance = Convert.ToDecimal(senderBalanceObj);

                if (senderBalance < transferAmount)
                {
                    MessageBox.Show("Insufficient balance for this transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    return;
                }

                // Here is where the transfer is beign carried out 
                SqlCommand updateSenderBalance = new SqlCommand(
                    "UPDATE Users SET Account_Balance = Account_Balance - @transferAmount WHERE Account_Number = @senderAccountNumber", conn, transaction);
                updateSenderBalance.Parameters.AddWithValue("@transferAmount", transferAmount);
                updateSenderBalance.Parameters.AddWithValue("@senderAccountNumber", senderAccountNumber);

                SqlCommand updateReceiverBalance = new SqlCommand(
                    "UPDATE Users SET Account_Balance = Account_Balance + @transferAmount WHERE Account_Number = @receiverAccountNumber", conn, transaction);
                updateReceiverBalance.Parameters.AddWithValue("@transferAmount", transferAmount);
                updateReceiverBalance.Parameters.AddWithValue("@receiverAccountNumber", recieverAccountNumber); 

                updateSenderBalance.ExecuteNonQuery();
                updateReceiverBalance.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Transfer completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during transfer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TransferPage_Load(object sender, EventArgs e)
        {

        }

        private void transferPage_textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void transferPage_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferPage_verifyAccountNumber_Click(object sender, EventArgs e)
        {
            string receiverAccountNumber = transferPage_textBox1.Text;
            if (string.IsNullOrWhiteSpace(receiverAccountNumber))
            {
                MessageBox.Show("Please enter a valid account number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Verify the recipient's account number and retrieve the account holder's name
                SqlCommand verifyReciever = new SqlCommand("SELECT Username FROM Users WHERE Account_Number = @receiverAccountNumber", conn);
                verifyReciever.Parameters.AddWithValue("@receiverAccountNumber", receiverAccountNumber);

                object result = verifyReciever.ExecuteScalar();

                if (result != null)
                {
                    recipientAccountName = result.ToString();
                    MessageBox.Show($"Receipient Name is: \n {recipientAccountName}", "Verify Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Recipient account number does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred during account verification: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
