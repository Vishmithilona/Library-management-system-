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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Librarian_System1
{
    public partial class Librarian_page : Form
    {
        private Librarian librarian;
        private string username, password, role;

        public Librarian_page(string Username, string password, string role)
        {
            InitializeComponent();

           // You can populate other fields here if needed
            txtLibrarianName.Text = "";
            txtAccountID.Text = "";
            txtHiredDate.Text = DateTime.Today.ToShortDateString();
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
        }

        private void btnAuthorizeBorrow_Click(object sender, EventArgs e)
        {
            // Code to authorize borrow requests
            MessageBox.Show("Borrow request authorization functionality would go here");
            DataTable table = new DataTable();
            table.Columns.Add("RequestID");
            table.Columns.Add("Member");
            table.Columns.Add("BookTitle");
            table.Columns.Add("Status");


        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            // Code to manage members
            MessageBox.Show("Member management functionality would go here");
        }

        private void btnManageBookCopies_Click(object sender, EventArgs e)
        {
            // Code to manage book copies
            MessageBox.Show("Book copy management functionality would go here");
        }
        // Declare these in your Designer file (Librarian_page.Designer.cs)
        private TextBox textBoxUsername;
        private TextBox textBoxRole;
        private TextBox textBoxLibrarianName;
        private TextBox textBoxAccountID;
        private TextBox textBoxHiredDate;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNo;
        private TextBox textBoxAddress;
        private Button buttonLogout;



        public class Librarian
        {
            public string AccountID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNo { get; set; }
            public string Address { get; set; }
            public string Username { get; set; }
            public string Role { get; set; }
            public string HiredDate { get; set; }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        public void LoadLibrarianData(string accountId)
        {
            string connectionString = "Data Source=DESKTOP-2DMF7KO\\SQLEXPRESS;Initial Catalog=vishmi;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Member WHERE UserName = @username AND Password = @password\r\n";


                //  Role-specific query
                if (role == "Librarian")
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
                    if (role == "Librarian")
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



        private void lblLibrarianName_Click(object sender, EventArgs e)
        {

        }

        private void Librarian_page_Load(object sender, EventArgs e)
        {

        }

        private void btnMemberPage_Click(object sender, EventArgs e)
        {
            Member_page loginForm = new Member_page("Username","Password", "Role");
            loginForm.Show();
            this.Close();
        }
    }

    
}
