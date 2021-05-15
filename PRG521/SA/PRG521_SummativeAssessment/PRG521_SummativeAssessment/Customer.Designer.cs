namespace PRG521_SummativeAssessment
{
    partial class Customer
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
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTxtbox = new System.Windows.Forms.TextBox();
            this.ContactNumberTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtbox = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(10, 11);
            this.CustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(54, 13);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer:";
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(13, 37);
            this.FullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullnameLabel.TabIndex = 1;
            this.FullnameLabel.Text = "Full Name:";
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Location = new System.Drawing.Point(13, 61);
            this.ContactNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.ContactNumberLabel.TabIndex = 2;
            this.ContactNumberLabel.Text = "Contact Number:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(13, 85);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email:";
            // 
            // FullNameTxtbox
            // 
            this.FullNameTxtbox.Location = new System.Drawing.Point(110, 37);
            this.FullNameTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullNameTxtbox.Name = "FullNameTxtbox";
            this.FullNameTxtbox.Size = new System.Drawing.Size(140, 20);
            this.FullNameTxtbox.TabIndex = 4;
            // 
            // ContactNumberTxtBox
            // 
            this.ContactNumberTxtBox.Location = new System.Drawing.Point(110, 61);
            this.ContactNumberTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactNumberTxtBox.Name = "ContactNumberTxtBox";
            this.ContactNumberTxtBox.Size = new System.Drawing.Size(140, 20);
            this.ContactNumberTxtBox.TabIndex = 5;
            // 
            // EmailTxtbox
            // 
            this.EmailTxtbox.Location = new System.Drawing.Point(110, 85);
            this.EmailTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTxtbox.Name = "EmailTxtbox";
            this.EmailTxtbox.Size = new System.Drawing.Size(140, 20);
            this.EmailTxtbox.TabIndex = 6;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(325, 83);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(56, 27);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(386, 83);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(56, 27);
            this.ReadBtn.TabIndex = 8;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(447, 83);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(56, 27);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(508, 82);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(56, 28);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(570, 83);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(56, 27);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 237);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.EmailTxtbox);
            this.Controls.Add(this.ContactNumberTxtBox);
            this.Controls.Add(this.FullNameTxtbox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ContactNumberLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTxtbox;
        private System.Windows.Forms.TextBox ContactNumberTxtBox;
        private System.Windows.Forms.TextBox EmailTxtbox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}