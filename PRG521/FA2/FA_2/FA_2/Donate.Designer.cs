
namespace FA_2
{
    partial class Donate
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
            this.custTip_btn = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.TextBox();
            this.custSurname = new System.Windows.Forms.TextBox();
            this.custNumber = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custAmount = new System.Windows.Forms.TextBox();
            this.custBack_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // custTip_btn
            // 
            this.custTip_btn.Location = new System.Drawing.Point(220, 104);
            this.custTip_btn.Name = "custTip_btn";
            this.custTip_btn.Size = new System.Drawing.Size(170, 58);
            this.custTip_btn.TabIndex = 0;
            this.custTip_btn.Text = "Donate";
            this.custTip_btn.UseVisualStyleBackColor = true;
            this.custTip_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(33, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(37, 14);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(94, 28);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(100, 20);
            this.custName.TabIndex = 6;
            this.custName.Text = "Insert Name";
            // 
            // custSurname
            // 
            this.custSurname.Location = new System.Drawing.Point(94, 57);
            this.custSurname.Name = "custSurname";
            this.custSurname.Size = new System.Drawing.Size(100, 20);
            this.custSurname.TabIndex = 7;
            this.custSurname.Text = "Insert Surname";
            // 
            // custNumber
            // 
            this.custNumber.Location = new System.Drawing.Point(94, 85);
            this.custNumber.Name = "custNumber";
            this.custNumber.Size = new System.Drawing.Size(100, 20);
            this.custNumber.TabIndex = 8;
            this.custNumber.Text = "Insert Number";
            // 
            // custEmail
            // 
            this.custEmail.Location = new System.Drawing.Point(94, 113);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(100, 20);
            this.custEmail.TabIndex = 9;
            this.custEmail.Text = "Insert Email";
            // 
            // custAmount
            // 
            this.custAmount.Location = new System.Drawing.Point(94, 141);
            this.custAmount.Name = "custAmount";
            this.custAmount.Size = new System.Drawing.Size(100, 20);
            this.custAmount.TabIndex = 10;
            this.custAmount.Text = "Insert Amount";
            // 
            // custBack_btn
            // 
            this.custBack_btn.Location = new System.Drawing.Point(220, 28);
            this.custBack_btn.Name = "custBack_btn";
            this.custBack_btn.Size = new System.Drawing.Size(170, 58);
            this.custBack_btn.TabIndex = 11;
            this.custBack_btn.Text = "Back";
            this.custBack_btn.UseVisualStyleBackColor = true;
            this.custBack_btn.Click += new System.EventHandler(this.custBack_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "6854 Brandon de Bruyn";
            // 
            // Donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(411, 209);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.custBack_btn);
            this.Controls.Add(this.custAmount);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.custNumber);
            this.Controls.Add(this.custSurname);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.custTip_btn);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Donate";
            this.ShowIcon = false;
            this.Text = "Donor";
            this.Load += new System.EventHandler(this.Donate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button custTip_btn;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox custSurname;
        private System.Windows.Forms.TextBox custNumber;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.TextBox custAmount;
        private System.Windows.Forms.Button custBack_btn;
        private System.Windows.Forms.Label label5;
    }
}