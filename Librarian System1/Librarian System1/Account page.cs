using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Librarian_System1.Log_page;

namespace Librarian_System1
{
    public partial class Account_page : Form
    {

        private string username, password, role;
        private object cmd;
        public Account_page(string Username, string password, string role)
        {
            InitializeComponent();

            this.username = username;
            this.password = password;
            this.role = role;

            this.Text = "Account Manager";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            Label welcomeLabel = new Label();
            welcomeLabel.Text = $"Welcome, {username} (Role: {role})";
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new System.Drawing.Point(20, 20);

            this.Controls.Add(welcomeLabel);

            // Display data on the form
            txtUsername1.Text = Username;
            txtPassword.Text = password;
            txtRole1.Text = role;

            // You can populate other fields here if needed
            txtAccountID.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
        }

        
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            return new SqlConnection(connString);
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            // Read values from form controls
            string accountId = txtAccountID.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNo.Text;
            string address = txtAddress.Text;

            // Connection string to your database
            string connectionString = "Data Source=DESKTOP-2DMF7KO\\SQLEXPRESS;Initial Catalog=vishmi;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Librarians SET Name=@Name, Email=@Email, PhoneNo=@PhoneNo, Address=@Address WHERE AccountID=@AccountID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", accountId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNo", phone);
                    cmd.Parameters.AddWithValue("@Address", address);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Information updated successfully.");

                            // Open the Librarian Page
                            Librarian_page librarianForm = new Librarian_page("Username","Password", "Role");
                            librarianForm.LoadLibrarianData(accountId); // Custom method to populate form
                            librarianForm.Show();
                            this.Hide(); // Optionally hide the Account_page
                        }
                        else
                        {
                            MessageBox.Show("Update failed. AccountID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // When form is closing (either via logout button or X button)
            // Show the login form again
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Log_page loginForm = new Log_page();
                loginForm.Show();
            }
        }
        public void LoadLibrarianData(string accountId)
        {
            string connectionString = "Data Source=DESKTOP-2DMF7KO\\SQLEXPRESS;Initial Catalog=vishmi;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Member WHERE UserName = @username AND Password = @password\r\n";


                //  Role-specific query
                if (role == "Member")
                {
                    query = "SELECT COUNT(*) FROM Member WHERE username = @username AND password = @password";
                }
                else if (role == "Librarian")
                {
                    query = "SELECT COUNT(*) FROM Librarian WHERE username = @username AND password = @password";
                }
                else if (role == "Account Manager")
                {
                    query = "SELECT COUNT(*) FROM AccountManager WHERE username = @username AND password = @password";
                }


                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);



                    // Open respective page
                    this.Hide();
                    if (role == "Member")
                        new Member_page(username, password, role).Show();
                    else if (role == "Librarian")
                        new Librarian_page(username, password, role).Show();
                    else if (role == "Account Manager")
                        new Account_page(username, password, role).Show();


                    else
                    {
                        MessageBox.Show("Invalid credentials!", "Login ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }   
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password reset functionality not implemented.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
