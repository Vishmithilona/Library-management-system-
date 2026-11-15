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

namespace Librarian_System1
{
    public partial class Return_page : Form
    {
        private string bookTitle;
        private object dataGridView1;

        public Return_page()
        {
            InitializeComponent();
            txtTitle.Text = bookTitle; // Pre-fill the book title textbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtDueDate.Text) ||
                string.IsNullOrWhiteSpace(txtReturnDate.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            DateTime dueDate, returnDate;

            // Validate dates
            if (!DateTime.TryParse(txtDueDate.Text, out dueDate) ||
                !DateTime.TryParse(txtReturnDate.Text, out returnDate))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.");
                return;
            }

            // Calculate fine if applicable
            if (returnDate > dueDate)
            {
                int daysLate = (returnDate - dueDate).Days;
                decimal fine = daysLate * 50; // Rs.50 per day
                txtFine.Text = fine.ToString();
                MessageBox.Show($"Book returned late.\nFine: Rs.{fine}", "Late Return");
            }
            else
            {
                txtFine.Text = "0";
                MessageBox.Show("Book returned on time. No fine.", "Return Successful");
            }

            // Simulate marking the return complete
            MessageBox.Show("Return confirmed and logged into the system.");

            ClearFields();

            string selectedBookTitle = "";

            
            Return_page returnPage = new Return_page();
            returnPage.Show();
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFine.Text))
            {
                MessageBox.Show("No fine to pay.");
                return;
            }
            decimal fineAmount;
            if (decimal.TryParse(txtFine.Text, out fineAmount) && fineAmount > 0)
            {
                MessageBox.Show($"Fine of {fineAmount:C} has been paid successfully.", "Fine Paid");
                txtFine.Text = "0"; // Reset the fine after payment
            }
            else
            {
                MessageBox.Show("Invalid fine amount.", "Error");
            }
        }

        private void btnReturnPage_Click(object sender, EventArgs e)
        {
            
            DataGridView grid = this.Controls["dataGridView1"] as DataGridView;

            if (grid != null && grid.SelectedRows.Count > 0)
            {
                string selectedBookTitle = grid.SelectedRows[0].Cells["Title"].Value.ToString();
                Return_page returnPage = new Return_page();
                returnPage.Show();
            }
            else
            {
                MessageBox.Show("Please select a book first.");
            }

            string connectionString = "Data Source=DESKTOP-2DMF7KO\\SQLEXPRESS;Initial Catalog=vishmi;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString)) ;


        }
        private void ClearFields()
        {
            txtTitle.Text = "";
            txtDueDate.Text = "";
            txtReturnDate.Text = "";
            txtFine.Text = "";
        }
    }
    
}
