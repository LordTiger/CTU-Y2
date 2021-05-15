
namespace FA_2
{
    partial class Admin
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
            this.aCheckBox = new System.Windows.Forms.CheckBox();
            this.aCID = new System.Windows.Forms.TextBox();
            this.cid = new System.Windows.Forms.Label();
            this.aDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.aCreate = new System.Windows.Forms.Button();
            this.aRead = new System.Windows.Forms.Button();
            this.aUpdate = new System.Windows.Forms.Button();
            this.aDelete = new System.Windows.Forms.Button();
            this.aName = new System.Windows.Forms.TextBox();
            this.aSurname = new System.Windows.Forms.TextBox();
            this.aNumber = new System.Windows.Forms.TextBox();
            this.aEmail = new System.Windows.Forms.TextBox();
            this.aAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.aInfo = new System.Windows.Forms.Label();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fA2DataSet = new FA_2.FA2DataSet();
            this.cust_dataTableAdapter = new FA_2.FA2DataSetTableAdapters.cust_dataTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fA2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // aCheckBox
            // 
            this.aCheckBox.AutoSize = true;
            this.aCheckBox.Location = new System.Drawing.Point(206, 23);
            this.aCheckBox.Name = "aCheckBox";
            this.aCheckBox.Size = new System.Drawing.Size(113, 18);
            this.aCheckBox.TabIndex = 0;
            this.aCheckBox.Text = "Approve Donation";
            this.aCheckBox.UseVisualStyleBackColor = true;
            this.aCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // aCID
            // 
            this.aCID.Location = new System.Drawing.Point(100, 20);
            this.aCID.Name = "aCID";
            this.aCID.Size = new System.Drawing.Size(100, 20);
            this.aCID.TabIndex = 2;
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Location = new System.Drawing.Point(14, 24);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(68, 14);
            this.cid.TabIndex = 1;
            this.cid.Text = "Customer ID:";
            this.cid.Click += new System.EventHandler(this.label1_Click);
            // 
            // aDataGrid
            // 
            this.aDataGrid.AllowUserToAddRows = false;
            this.aDataGrid.AllowUserToDeleteRows = false;
            this.aDataGrid.AutoGenerateColumns = false;
            this.aDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cSurnameDataGridViewTextBoxColumn,
            this.cNumberDataGridViewTextBoxColumn,
            this.cEmailDataGridViewTextBoxColumn,
            this.cAmountDataGridViewTextBoxColumn,
            this.cDateDataGridViewTextBoxColumn,
            this.approvedDataGridViewTextBoxColumn});
            this.aDataGrid.DataSource = this.custdataBindingSource;
            this.aDataGrid.Location = new System.Drawing.Point(17, 172);
            this.aDataGrid.Name = "aDataGrid";
            this.aDataGrid.ReadOnly = true;
            this.aDataGrid.Size = new System.Drawing.Size(844, 208);
            this.aDataGrid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "6854 Brandon de Bruyn";
            // 
            // aCreate
            // 
            this.aCreate.Location = new System.Drawing.Point(17, 141);
            this.aCreate.Name = "aCreate";
            this.aCreate.Size = new System.Drawing.Size(75, 25);
            this.aCreate.TabIndex = 6;
            this.aCreate.Text = "Create";
            this.aCreate.UseVisualStyleBackColor = true;
            this.aCreate.Click += new System.EventHandler(this.aCreate_Click);
            // 
            // aRead
            // 
            this.aRead.Location = new System.Drawing.Point(100, 141);
            this.aRead.Name = "aRead";
            this.aRead.Size = new System.Drawing.Size(75, 25);
            this.aRead.TabIndex = 7;
            this.aRead.Text = "Read";
            this.aRead.UseVisualStyleBackColor = true;
            this.aRead.Click += new System.EventHandler(this.aRead_Click);
            // 
            // aUpdate
            // 
            this.aUpdate.Location = new System.Drawing.Point(181, 141);
            this.aUpdate.Name = "aUpdate";
            this.aUpdate.Size = new System.Drawing.Size(75, 25);
            this.aUpdate.TabIndex = 8;
            this.aUpdate.Text = "Update";
            this.aUpdate.UseVisualStyleBackColor = true;
            this.aUpdate.Click += new System.EventHandler(this.aUpdate_Click);
            // 
            // aDelete
            // 
            this.aDelete.Location = new System.Drawing.Point(262, 141);
            this.aDelete.Name = "aDelete";
            this.aDelete.Size = new System.Drawing.Size(75, 25);
            this.aDelete.TabIndex = 9;
            this.aDelete.Text = "Delete";
            this.aDelete.UseVisualStyleBackColor = true;
            this.aDelete.Click += new System.EventHandler(this.aDelete_Click);
            // 
            // aName
            // 
            this.aName.Location = new System.Drawing.Point(99, 52);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(100, 20);
            this.aName.TabIndex = 10;
            // 
            // aSurname
            // 
            this.aSurname.Location = new System.Drawing.Point(99, 81);
            this.aSurname.Name = "aSurname";
            this.aSurname.Size = new System.Drawing.Size(100, 20);
            this.aSurname.TabIndex = 11;
            // 
            // aNumber
            // 
            this.aNumber.Location = new System.Drawing.Point(296, 52);
            this.aNumber.Name = "aNumber";
            this.aNumber.Size = new System.Drawing.Size(100, 20);
            this.aNumber.TabIndex = 12;
            // 
            // aEmail
            // 
            this.aEmail.Location = new System.Drawing.Point(297, 82);
            this.aEmail.Name = "aEmail";
            this.aEmail.Size = new System.Drawing.Size(100, 20);
            this.aEmail.TabIndex = 13;
            // 
            // aAmount
            // 
            this.aAmount.Location = new System.Drawing.Point(99, 110);
            this.aAmount.Name = "aAmount";
            this.aAmount.Size = new System.Drawing.Size(100, 20);
            this.aAmount.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 14);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(14, 84);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(50, 14);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Surname";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(212, 55);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 14);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(212, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 14);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(14, 113);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 14);
            this.lblAmount.TabIndex = 19;
            this.lblAmount.Text = "Amount";
            // 
            // aInfo
            // 
            this.aInfo.AutoSize = true;
            this.aInfo.Location = new System.Drawing.Point(604, 146);
            this.aInfo.Name = "aInfo";
            this.aInfo.Size = new System.Drawing.Size(261, 14);
            this.aInfo.TabIndex = 20;
            this.aInfo.Text = "Please Enter a CID if you want to approve a donation";
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "cid";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "cName";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cSurnameDataGridViewTextBoxColumn
            // 
            this.cSurnameDataGridViewTextBoxColumn.DataPropertyName = "cSurname";
            this.cSurnameDataGridViewTextBoxColumn.HeaderText = "cSurname";
            this.cSurnameDataGridViewTextBoxColumn.Name = "cSurnameDataGridViewTextBoxColumn";
            this.cSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNumberDataGridViewTextBoxColumn
            // 
            this.cNumberDataGridViewTextBoxColumn.DataPropertyName = "cNumber";
            this.cNumberDataGridViewTextBoxColumn.HeaderText = "cNumber";
            this.cNumberDataGridViewTextBoxColumn.Name = "cNumberDataGridViewTextBoxColumn";
            this.cNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEmailDataGridViewTextBoxColumn
            // 
            this.cEmailDataGridViewTextBoxColumn.DataPropertyName = "cEmail";
            this.cEmailDataGridViewTextBoxColumn.HeaderText = "cEmail";
            this.cEmailDataGridViewTextBoxColumn.Name = "cEmailDataGridViewTextBoxColumn";
            this.cEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cAmountDataGridViewTextBoxColumn
            // 
            this.cAmountDataGridViewTextBoxColumn.DataPropertyName = "cAmount";
            this.cAmountDataGridViewTextBoxColumn.HeaderText = "cAmount";
            this.cAmountDataGridViewTextBoxColumn.Name = "cAmountDataGridViewTextBoxColumn";
            this.cAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDateDataGridViewTextBoxColumn
            // 
            this.cDateDataGridViewTextBoxColumn.DataPropertyName = "cDate";
            this.cDateDataGridViewTextBoxColumn.HeaderText = "cDate";
            this.cDateDataGridViewTextBoxColumn.Name = "cDateDataGridViewTextBoxColumn";
            this.cDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvedDataGridViewTextBoxColumn
            // 
            this.approvedDataGridViewTextBoxColumn.DataPropertyName = "approved";
            this.approvedDataGridViewTextBoxColumn.HeaderText = "approved";
            this.approvedDataGridViewTextBoxColumn.Name = "approvedDataGridViewTextBoxColumn";
            this.approvedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custdataBindingSource
            // 
            this.custdataBindingSource.DataMember = "cust_data";
            this.custdataBindingSource.DataSource = this.fA2DataSet;
            // 
            // fA2DataSet
            // 
            this.fA2DataSet.DataSetName = "FA2DataSet";
            this.fA2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cust_dataTableAdapter
            // 
            this.cust_dataTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please Enter a CID if you want to Delete a Donator";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(873, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aInfo);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.aAmount);
            this.Controls.Add(this.aEmail);
            this.Controls.Add(this.aNumber);
            this.Controls.Add(this.aSurname);
            this.Controls.Add(this.aName);
            this.Controls.Add(this.aDelete);
            this.Controls.Add(this.aUpdate);
            this.Controls.Add(this.aRead);
            this.Controls.Add(this.aCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aDataGrid);
            this.Controls.Add(this.aCID);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.aCheckBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fA2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aCheckBox;
        private System.Windows.Forms.TextBox aCID;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.DataGridView aDataGrid;
        private FA2DataSet fA2DataSet;
        private System.Windows.Forms.BindingSource custdataBindingSource;
        private FA2DataSetTableAdapters.cust_dataTableAdapter cust_dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aCreate;
        private System.Windows.Forms.Button aRead;
        private System.Windows.Forms.Button aUpdate;
        private System.Windows.Forms.Button aDelete;
        private System.Windows.Forms.TextBox aName;
        private System.Windows.Forms.TextBox aSurname;
        private System.Windows.Forms.TextBox aNumber;
        private System.Windows.Forms.TextBox aEmail;
        private System.Windows.Forms.TextBox aAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label aInfo;
        private System.Windows.Forms.Label label1;
    }
}