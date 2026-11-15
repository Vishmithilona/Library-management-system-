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
    public partial class Member_page : Form
    {
        
        public Member_page(string Username,string Password, string role)
        {

            InitializeComponent();
          
        
        }
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            return new SqlConnection(connString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            string role = cmbRle.SelectedItem?.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            // Implement reservation logic
            MessageBox.Show("Book reservation functionality would be implemented here",
                "Reserve Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnGotoBookpage_Click(object sender, EventArgs e)
        {
            Book_page BookPage = new Book_page();
            BookPage.Show();
            this.Hide();  // Optional: hides current form
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }   

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}