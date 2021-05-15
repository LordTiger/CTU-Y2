
namespace GA6
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_RBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_Browse = new System.Windows.Forms.Button();
            this.b_Search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_R = new System.Windows.Forms.Label();
            this.t_SBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_SBox);
            this.groupBox1.Controls.Add(this.b_Search);
            this.groupBox1.Controls.Add(this.b_Browse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_RBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyword Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the file where keywords are stored:";
            // 
            // t_RBox
            // 
            this.t_RBox.Location = new System.Drawing.Point(10, 44);
            this.t_RBox.Name = "t_RBox";
            this.t_RBox.ReadOnly = true;
            this.t_RBox.Size = new System.Drawing.Size(217, 26);
            this.t_RBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Keyword to search:";
            // 
            // b_Browse
            // 
            this.b_Browse.Location = new System.Drawing.Point(233, 45);
            this.b_Browse.Name = "b_Browse";
            this.b_Browse.Size = new System.Drawing.Size(75, 23);
            this.b_Browse.TabIndex = 4;
            this.b_Browse.Text = "Browse...";
            this.b_Browse.UseVisualStyleBackColor = true;
            this.b_Browse.Click += new System.EventHandler(this.b_Browse_Click);
            // 
            // b_Search
            // 
            this.b_Search.Location = new System.Drawing.Point(233, 111);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(75, 23);
            this.b_Search.TabIndex = 5;
            this.b_Search.Text = "Search";
            this.b_Search.UseVisualStyleBackColor = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l_R);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 97);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // l_R
            // 
            this.l_R.AutoSize = true;
            this.l_R.Location = new System.Drawing.Point(30, 46);
            this.l_R.Name = "l_R";
            this.l_R.Size = new System.Drawing.Size(260, 18);
            this.l_R.TabIndex = 0;
            this.l_R.Text = "Search results will be displayed here";
            // 
            // t_SBox
            // 
            this.t_SBox.Location = new System.Drawing.Point(10, 108);
            this.t_SBox.Name = "t_SBox";
            this.t_SBox.Size = new System.Drawing.Size(217, 26);
            this.t_SBox.TabIndex = 6;
            this.t_SBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_Search;
        private System.Windows.Forms.Button b_Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_RBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l_R;
        private System.Windows.Forms.RichTextBox t_SBox;
    }
}

