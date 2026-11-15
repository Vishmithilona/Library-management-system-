namespace Librarian_System1
{
    partial class Return_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfimReturn = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReturnbook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfimReturn
            // 
            this.btnConfimReturn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfimReturn.Location = new System.Drawing.Point(251, 317);
            this.btnConfimReturn.Name = "btnConfimReturn";
            this.btnConfimReturn.Size = new System.Drawing.Size(155, 42);
            this.btnConfimReturn.TabIndex = 24;
            this.btnConfimReturn.Text = "Confim Return";
            this.btnConfimReturn.UseVisualStyleBackColor = true;
            this.btnConfimReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFine
            // 
            this.btnFine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFine.Location = new System.Drawing.Point(31, 317);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(107, 42);
            this.btnFine.TabIndex = 23;
            this.btnFine.Text = "Pay Fine";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(176, 245);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(230, 20);
            this.txtFine.TabIndex = 22;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Location = new System.Drawing.Point(176, 195);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(230, 20);
            this.txtReturnDate.TabIndex = 21;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(176, 146);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(230, 20);
            this.txtDueDate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Due Date";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(238, 78);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(168, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search by Book Title";
            // 
            // lblReturnbook
            // 
            this.lblReturnbook.AutoSize = true;
            this.lblReturnbook.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnbook.Location = new System.Drawing.Point(47, 27);
            this.lblReturnbook.Name = "lblReturnbook";
            this.lblReturnbook.Size = new System.Drawing.Size(332, 32);
            this.lblReturnbook.TabIndex = 14;
            this.lblReturnbook.Text = "Return Book and Pay fine";
            // 
            // Return_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 380);
            this.Controls.Add(this.btnConfimReturn);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReturnbook);
            this.Name = "Return_page";
            this.Text = "Return_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfimReturn;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReturnbook;
    }
}