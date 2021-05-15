namespace PRG521_SummativeAssessment
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddressBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.FreightBtn = new System.Windows.Forms.Button();
            this.DriversBtn = new System.Windows.Forms.Button();
            this.StatusBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddressBtn
            // 
            this.AddressBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddressBtn.ImageIndex = 0;
            this.AddressBtn.ImageList = this.imageList1;
            this.AddressBtn.Location = new System.Drawing.Point(9, 84);
            this.AddressBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressBtn.Name = "AddressBtn";
            this.AddressBtn.Size = new System.Drawing.Size(112, 50);
            this.AddressBtn.TabIndex = 0;
            this.AddressBtn.Text = "Manage Addresses";
            this.AddressBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddressBtn.UseVisualStyleBackColor = true;
            this.AddressBtn.Click += new System.EventHandler(this.AddressBtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Address.png");
            this.imageList1.Images.SetKeyName(1, "Customer.png");
            this.imageList1.Images.SetKeyName(2, "Driver.png");
            this.imageList1.Images.SetKeyName(3, "Exit.png");
            this.imageList1.Images.SetKeyName(4, "Status.png");
            this.imageList1.Images.SetKeyName(5, "Freight.png");
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CustomerBtn.ImageIndex = 1;
            this.CustomerBtn.ImageList = this.imageList1;
            this.CustomerBtn.Location = new System.Drawing.Point(156, 84);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(111, 50);
            this.CustomerBtn.TabIndex = 1;
            this.CustomerBtn.Text = "Manage Customers";
            this.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // FreightBtn
            // 
            this.FreightBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FreightBtn.ImageIndex = 5;
            this.FreightBtn.ImageList = this.imageList1;
            this.FreightBtn.Location = new System.Drawing.Point(297, 84);
            this.FreightBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FreightBtn.Name = "FreightBtn";
            this.FreightBtn.Size = new System.Drawing.Size(116, 50);
            this.FreightBtn.TabIndex = 2;
            this.FreightBtn.Text = "Manage Freight";
            this.FreightBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FreightBtn.UseVisualStyleBackColor = true;
            this.FreightBtn.Click += new System.EventHandler(this.FreightBtn_Click);
            // 
            // DriversBtn
            // 
            this.DriversBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DriversBtn.ImageIndex = 2;
            this.DriversBtn.ImageList = this.imageList1;
            this.DriversBtn.Location = new System.Drawing.Point(9, 184);
            this.DriversBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DriversBtn.Name = "DriversBtn";
            this.DriversBtn.Size = new System.Drawing.Size(112, 53);
            this.DriversBtn.TabIndex = 3;
            this.DriversBtn.Text = "Manage Drivers";
            this.DriversBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DriversBtn.UseVisualStyleBackColor = true;
            this.DriversBtn.Click += new System.EventHandler(this.DriversBtn_Click);
            // 
            // StatusBtn
            // 
            this.StatusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusBtn.ImageIndex = 4;
            this.StatusBtn.ImageList = this.imageList1;
            this.StatusBtn.Location = new System.Drawing.Point(156, 184);
            this.StatusBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusBtn.Name = "StatusBtn";
            this.StatusBtn.Size = new System.Drawing.Size(111, 53);
            this.StatusBtn.TabIndex = 4;
            this.StatusBtn.Text = "Manage Statusses";
            this.StatusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StatusBtn.UseVisualStyleBackColor = true;
            this.StatusBtn.Click += new System.EventHandler(this.StatusBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitBtn.ImageKey = "Exit.png";
            this.ExitBtn.ImageList = this.imageList1;
            this.ExitBtn.Location = new System.Drawing.Point(297, 184);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(116, 53);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 294);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StatusBtn);
            this.Controls.Add(this.DriversBtn);
            this.Controls.Add(this.FreightBtn);
            this.Controls.Add(this.CustomerBtn);
            this.Controls.Add(this.AddressBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Ctu Logistics";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddressBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Button FreightBtn;
        private System.Windows.Forms.Button DriversBtn;
        private System.Windows.Forms.Button StatusBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

