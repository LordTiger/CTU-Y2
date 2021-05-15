
namespace FA_2
{
    partial class Dashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.cust_btn = new System.Windows.Forms.Button();
            this.admin_login = new System.Windows.Forms.Button();
            this.a_name = new System.Windows.Forms.TextBox();
            this.a_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "6854 Brandon de Bruyn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cust_btn
            // 
            this.cust_btn.Location = new System.Drawing.Point(157, 87);
            this.cust_btn.Name = "cust_btn";
            this.cust_btn.Size = new System.Drawing.Size(119, 55);
            this.cust_btn.TabIndex = 5;
            this.cust_btn.Text = "Donate";
            this.cust_btn.UseVisualStyleBackColor = true;
            this.cust_btn.Click += new System.EventHandler(this.cust_btn_Click);
            // 
            // admin_login
            // 
            this.admin_login.Location = new System.Drawing.Point(9, 87);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(119, 55);
            this.admin_login.TabIndex = 6;
            this.admin_login.Text = "Login";
            this.admin_login.UseVisualStyleBackColor = true;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click);
            // 
            // a_name
            // 
            this.a_name.Location = new System.Drawing.Point(100, 20);
            this.a_name.Name = "a_name";
            this.a_name.Size = new System.Drawing.Size(140, 20);
            this.a_name.TabIndex = 7;
            this.a_name.TextChanged += new System.EventHandler(this.a_name_TextChanged);
            // 
            // a_password
            // 
            this.a_password.Location = new System.Drawing.Point(100, 51);
            this.a_password.Name = "a_password";
            this.a_password.Size = new System.Drawing.Size(140, 20);
            this.a_password.TabIndex = 8;
            this.a_password.UseSystemPasswordChar = true;
            this.a_password.TextChanged += new System.EventHandler(this.a_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Email: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "If you are a donator please click the Donate Button";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(289, 190);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a_password);
            this.Controls.Add(this.a_name);
            this.Controls.Add(this.admin_login);
            this.Controls.Add(this.cust_btn);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "NGO";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cust_btn;
        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.TextBox a_name;
        private System.Windows.Forms.TextBox a_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

