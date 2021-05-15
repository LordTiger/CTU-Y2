namespace PRG521_SummativeAssessment
{
    partial class Status
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
            this.StatusInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusIDTxtbox = new System.Windows.Forms.TextBox();
            this.PickedUpLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DriverIDLabel = new System.Windows.Forms.Label();
            this.DriverIDTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.displayText = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusInfoLabel
            // 
            this.StatusInfoLabel.AutoSize = true;
            this.StatusInfoLabel.Location = new System.Drawing.Point(10, 11);
            this.StatusInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusInfoLabel.Name = "StatusInfoLabel";
            this.StatusInfoLabel.Size = new System.Drawing.Size(95, 13);
            this.StatusInfoLabel.TabIndex = 0;
            this.StatusInfoLabel.Text = "Status Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status ID:";
            // 
            // StatusIDTxtbox
            // 
            this.StatusIDTxtbox.Location = new System.Drawing.Point(87, 32);
            this.StatusIDTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusIDTxtbox.Name = "StatusIDTxtbox";
            this.StatusIDTxtbox.Size = new System.Drawing.Size(151, 20);
            this.StatusIDTxtbox.TabIndex = 2;
            // 
            // PickedUpLabel
            // 
            this.PickedUpLabel.AutoSize = true;
            this.PickedUpLabel.Location = new System.Drawing.Point(13, 61);
            this.PickedUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PickedUpLabel.Name = "PickedUpLabel";
            this.PickedUpLabel.Size = new System.Drawing.Size(58, 13);
            this.PickedUpLabel.TabIndex = 3;
            this.PickedUpLabel.Text = "Picked up:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY/MM/DD";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // DriverIDLabel
            // 
            this.DriverIDLabel.AutoSize = true;
            this.DriverIDLabel.Location = new System.Drawing.Point(290, 35);
            this.DriverIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DriverIDLabel.Name = "DriverIDLabel";
            this.DriverIDLabel.Size = new System.Drawing.Size(52, 13);
            this.DriverIDLabel.TabIndex = 5;
            this.DriverIDLabel.Text = "Driver ID:";
            // 
            // DriverIDTxtbox
            // 
            this.DriverIDTxtbox.Location = new System.Drawing.Point(356, 35);
            this.DriverIDTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DriverIDTxtbox.Name = "DriverIDTxtbox";
            this.DriverIDTxtbox.Size = new System.Drawing.Size(152, 20);
            this.DriverIDTxtbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delivered:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "YYYY/MM/DD";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(356, 60);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(15, 94);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(56, 21);
            this.CreateBtn.TabIndex = 9;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(94, 94);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(56, 20);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(260, 93);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(56, 21);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(173, 93);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(56, 21);
            this.ReadBtn.TabIndex = 12;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // displayText
            // 
            this.displayText.Location = new System.Drawing.Point(15, 131);
            this.displayText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(302, 255);
            this.displayText.TabIndex = 13;
            this.displayText.Text = "";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(356, 94);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(56, 21);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 395);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DriverIDTxtbox);
            this.Controls.Add(this.DriverIDLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PickedUpLabel);
            this.Controls.Add(this.StatusIDTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusInfoLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Status";
            this.Text = "FrmStatus";
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StatusIDTxtbox;
        private System.Windows.Forms.Label PickedUpLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DriverIDLabel;
        private System.Windows.Forms.TextBox DriverIDTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.RichTextBox displayText;
        private System.Windows.Forms.Button ExitBtn;
    }
}