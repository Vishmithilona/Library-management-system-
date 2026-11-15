using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Librarian_System1
{
    public partial class Log_page : Form
    {

        public Log_page() => InitializeComponent();            /* // Masking the password for security
      // Masking the password for security
      txtPassword.UseSystemPasswordChar = true;
  

          this.StartPosition = FormStartPosition.CenterScreen;
          this.Text = "Librarian System - Login";
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.MaximizeBox = false;

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.BtnForgotPassword = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 26);
            this.lblTitle.TabIndex = 0;

            // Role Label
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(50, 70);
            this.lblRole.Text = "Role";

            // Role ComboBox
            this.cmbRole.Location = new System.Drawing.Point(150, 67);
            this.cmbRole.Size = new System.Drawing.Size(150, 21);

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;

            // Optionally add roles to the ComboBox at runtime
            cmbRole.Items.Add("Librarian");
            cmbRole.Items.Add("Account manager");
            cmbRole.SelectedItem = 0; // default selection

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(120, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 1;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(120, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 2;


            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(120, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // btnForgotPassword
            this.BtnForgotPassword.AutoSize = true;
            this.BtnForgotPassword.Location = new System.Drawing.Point(120, 200);
            this.BtnForgotPassword.Name = "btnForgotPassword";
            this.BtnForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.BtnForgotPassword.TabIndex = 5;
            this.BtnForgotPassword.TabStop = true;
            this.BtnForgotPassword.Click += new System.EventHandler(this.BtnForgotPassword_Click);

            // pictureBox1
            this.picBox2.Image = global::Librarian_System1.Properties.Resources.library_management;
            this.picBox2.Location = new System.Drawing.Point(20, 20);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(60, 60);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 6;
            this.picBox2.TabStop = false;

            // LoginForm
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoginForm";
            this.Text = "Librarian Login";
            this.Text = "Account Manager Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }*/
        // This method is essential because it's connected to the designer
        /*  private void txtUsername_textChanged(object sender, EventArgs e)
          {
              // Leaving it blank to avoid errors */
        private void txtUsername_textChanged(object sender, EventArgs e)
        {
            // Leaving it blank to avoid errors 
        }

        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            return new SqlConnection(connString);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open new form or system dashboard here
                // Example: new Dashboard().Show(); this.Hide();
            }



            string connectionString = "Data Source=DESKTOP-2DMF7KO\\SQLEXPRESS;Initial Catalog=vishmi;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Librarian WHERE UserName = @username AND Password = @password\r\n";


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
    private void LblUsername_Click(object sender, EventArgs e)
        {
            // Empty method for label click
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Add roles to combo box
            cmbRole.Items.Add("Librarian");
            cmbRole.Items.Add("Account Manager"); // Corrected spelling
        }
        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the system administrator to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
