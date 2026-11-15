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
    public partial class Book_page : Form
    {
        private DataTable bookTable = new DataTable();

        public Book_page()
        {
            InitializeComponent();
            InitializeBookTable();
        }

        private void InitializeBookTable()
        {
            bookTable = new DataTable();
            bookTable.Columns.Add("Title");
            bookTable.Columns.Add("ISBN");
            bookTable.Columns.Add("Genre");
            bookTable.Columns.Add("PublishedDate");
            bookTable.Columns.Add("BookID");

            dataGridView1.DataSource = bookTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text) ||
                string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                string.IsNullOrWhiteSpace(txtPublishedDate.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            dataGridView1.Rows.Add(
            txtTitle.Text,
            txtISBN.Text,
            txtGenre.Text,
            txtPublishedDate.Text,
            txtTitle.Text
            );

            ClearFields();

            bookTable.Rows.Add(
            txtTitle.Text,
            txtISBN.Text,
            txtGenre.Text,
            txtPublishedDate.Text,
            txtBookID.Text
            );

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ClearFields()
        {
            txtBookID.Text = "";
            txtTitle.Text = "";
            txtISBN.Text = "";
            txtGenre.Text = "";
            txtPublishedDate.Text = "";
        }

        // Optional: Search logic (simple filter)
        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearchTitle.Text.Trim();
            if (!string.IsNullOrEmpty(filter))
            {
                DataView dv = new DataView(bookTable);
                dv.RowFilter = $"Title LIKE '%{filter}%'";
                dataGridView1.DataSource = dv;
            }
            else
            {
                dataGridView1.DataSource = bookTable;
            }
        }

        private void btnReturnPage_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-2DMF7KO\\SQLEXPRESS;Initial Catalog=vishmi;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))

                // Add this to Book_page.Designer.cs inside InitializeComponent()
                this.btnReturnPage = new System.Windows.Forms.Button();
            this.btnReturnPage.Text = "Go to Return Page";
            this.btnReturnPage.Click += new System.EventHandler(this.btnReturnPage_Click);
            // Add to form controls
            this.Controls.Add(this.btnReturnPage);


            Return_page returnPage = new Return_page();
            returnPage.Show();
            this.Hide(); // Optional: hide current form
        }
    }
    

}
