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

namespace Librarian_System1
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            return new SqlConnection(connString);
        }
        private void btnWelcome_Click(object sender, EventArgs e)
        {
            Log_page loginForm = new Log_page();
            loginForm.Show();
            this.Hide();
        }
    }
}
