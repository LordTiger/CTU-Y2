namespace PRG521_SummativeAssessment
{
    partial class Driver
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.LicenseTypeLabel = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.FullNameTxtbox = new System.Windows.Forms.TextBox();
            this.LicenseTypeCombox = new System.Windows.Forms.ComboBox();
            this.YesRadioBtn = new System.Windows.Forms.RadioButton();
            this.NoRadioBtn = new System.Windows.Forms.RadioButton();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Information:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(13, 43);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(73, 17);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full name:";
            // 
            // LicenseTypeLabel
            // 
            this.LicenseTypeLabel.AutoSize = true;
            this.LicenseTypeLabel.Location = new System.Drawing.Point(13, 72);
            this.LicenseTypeLabel.Name = "LicenseTypeLabel";
            this.LicenseTypeLabel.Size = new System.Drawing.Size(97, 17);
            this.LicenseTypeLabel.TabIndex = 2;
            this.LicenseTypeLabel.Text = "License Type:";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(13, 103);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(53, 17);
            this.OwnerLabel.TabIndex = 3;
            this.OwnerLabel.Text = "Owner:";
            // 
            // FullNameTxtbox
            // 
            this.FullNameTxtbox.Location = new System.Drawing.Point(135, 43);
            this.FullNameTxtbox.Name = "FullNameTxtbox";
            this.FullNameTxtbox.Size = new System.Drawing.Size(163, 22);
            this.FullNameTxtbox.TabIndex = 4;
            // 
            // LicenseTypeCombox
            // 
            this.LicenseTypeCombox.FormattingEnabled = true;
            this.LicenseTypeCombox.Location = new System.Drawing.Point(135, 72);
            this.LicenseTypeCombox.Name = "LicenseTypeCombox";
            this.LicenseTypeCombox.Size = new System.Drawing.Size(163, 24);
            this.LicenseTypeCombox.TabIndex = 5;
            // 
            // YesRadioBtn
            // 
            this.YesRadioBtn.AutoSize = true;
            this.YesRadioBtn.Location = new System.Drawing.Point(135, 103);
            this.YesRadioBtn.Name = "YesRadioBtn";
            this.YesRadioBtn.Size = new System.Drawing.Size(53, 21);
            this.YesRadioBtn.TabIndex = 6;
            this.YesRadioBtn.TabStop = true;
            this.YesRadioBtn.Text = "Yes";
            this.YesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // NoRadioBtn
            // 
            this.NoRadioBtn.AutoSize = true;
            this.NoRadioBtn.Location = new System.Drawing.Point(232, 103);
            this.NoRadioBtn.Name = "NoRadioBtn";
            this.NoRadioBtn.Size = new System.Drawing.Size(47, 21);
            this.NoRadioBtn.TabIndex = 7;
            this.NoRadioBtn.TabStop = true;
            this.NoRadioBtn.Text = "No";
            this.NoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(16, 145);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 27);
            this.CreateBtn.TabIndex = 8;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(113, 145);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 27);
            this.ReadBtn.TabIndex = 9;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(206, 144);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 28);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(298, 144);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 28);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(389, 144);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 28);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 272);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.NoRadioBtn);
            this.Controls.Add(this.YesRadioBtn);
            this.Controls.Add(this.LicenseTypeCombox);
            this.Controls.Add(this.FullNameTxtbox);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.LicenseTypeLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Driver";
            this.Text = "FrmDriver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label LicenseTypeLabel;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.TextBox FullNameTxtbox;
        private System.Windows.Forms.ComboBox LicenseTypeCombox;
        private System.Windows.Forms.RadioButton YesRadioBtn;
        private System.Windows.Forms.RadioButton NoRadioBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}