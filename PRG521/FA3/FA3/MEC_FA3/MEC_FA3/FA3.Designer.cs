
namespace MEC_FA3
{
    partial class FA3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_gused = new System.Windows.Forms.Label();
            this.t_Dr = new System.Windows.Forms.TextBox();
            this.t_GU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.t_Fin = new System.Windows.Forms.TextBox();
            this.b_Calc = new System.Windows.Forms.Button();
            this.e_prov = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.e_prov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mileage Efficieny Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles Driven: ";
            // 
            // lbl_gused
            // 
            this.lbl_gused.AutoSize = true;
            this.lbl_gused.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gused.Location = new System.Drawing.Point(30, 125);
            this.lbl_gused.Name = "lbl_gused";
            this.lbl_gused.Size = new System.Drawing.Size(136, 16);
            this.lbl_gused.TabIndex = 2;
            this.lbl_gused.Text = "Gallons of gas used:";
            // 
            // t_Dr
            // 
            this.t_Dr.Location = new System.Drawing.Point(185, 85);
            this.t_Dr.Name = "t_Dr";
            this.t_Dr.Size = new System.Drawing.Size(158, 22);
            this.t_Dr.TabIndex = 3;
            // 
            // t_GU
            // 
            this.t_GU.Location = new System.Drawing.Point(185, 121);
            this.t_GU.Name = "t_GU";
            this.t_GU.Size = new System.Drawing.Size(158, 22);
            this.t_GU.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 3);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 3);
            this.label5.TabIndex = 6;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(2, 178);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(164, 16);
            this.lblMiles.TabIndex = 7;
            this.lblMiles.Text = "Efficiency (Miles/Gallon):";
            // 
            // t_Fin
            // 
            this.t_Fin.Location = new System.Drawing.Point(185, 175);
            this.t_Fin.Name = "t_Fin";
            this.t_Fin.Size = new System.Drawing.Size(158, 22);
            this.t_Fin.TabIndex = 8;
            // 
            // b_Calc
            // 
            this.b_Calc.Location = new System.Drawing.Point(108, 212);
            this.b_Calc.Name = "b_Calc";
            this.b_Calc.Size = new System.Drawing.Size(160, 23);
            this.b_Calc.TabIndex = 9;
            this.b_Calc.Text = "Calculate";
            this.b_Calc.UseVisualStyleBackColor = true;
            this.b_Calc.Click += new System.EventHandler(this.b_Calc_Click);
            // 
            // e_prov
            // 
            this.e_prov.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(380, 247);
            this.Controls.Add(this.b_Calc);
            this.Controls.Add(this.t_Fin);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_GU);
            this.Controls.Add(this.t_Dr);
            this.Controls.Add(this.lbl_gused);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.e_prov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_gused;
        private System.Windows.Forms.TextBox t_Dr;
        private System.Windows.Forms.TextBox t_GU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox t_Fin;
        private System.Windows.Forms.Button b_Calc;
        private System.Windows.Forms.ErrorProvider e_prov;
    }
}

