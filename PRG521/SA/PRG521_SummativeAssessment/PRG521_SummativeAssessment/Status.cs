using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG521_SummativeAssessment
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        // Create button created here in order to
        // Create a new text file
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string TextFile = "status.txt";
            using (StreamWriter write = File.CreateText(TextFile))
            {
                write.WriteLine("Status ID: " + StatusIDTxtbox.Text);
                write.WriteLine("Driver ID: " + DriverIDTxtbox.Text);
                write.WriteLine("Picked up: " + dateTimePicker1.Text);
                write.WriteLine("Delivered: " + dateTimePicker2.Text);
                MessageBox.Show("File created successfully.");
            }
        }
        // Read button created here to read the text
        // File in a textbox
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            string TextFile = "status.txt";
            if (File.Exists(TextFile))
            {
                using (StreamReader read = File.OpenText(TextFile))
                {
                    string FullText = File.ReadAllText(TextFile);
                    displayText.Text = FullText;
                }
            }
            else
            {
                MessageBox.Show("File not found or not created yet!");
            }
        }

        // Update button created here which updates all
        // Information inside of the text file
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string TextFile = "status.txt";
            if (File.Exists(TextFile))
            {
                using (StreamWriter write = File.CreateText(TextFile))
                {
                    write.WriteLine("Status ID: " + StatusIDTxtbox.Text);
                    write.WriteLine("Driver ID: " + DriverIDTxtbox.Text);
                    write.WriteLine("Picked up: " + dateTimePicker1.Text);
                    write.WriteLine("Delivered: " + dateTimePicker2.Text);
                    MessageBox.Show("File updated sucessfully.");
                }
            }
            else
            {
                MessageBox.Show("No file to update. Create a file first.");
            }
        }

        // Delete button created here that deletes all information
        // Insides of the text file, but it does not delete the
        // The text file itself
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string TextFile = "status.txt";
            if (File.Exists(TextFile))
            {
                using (StreamWriter write = File.CreateText(TextFile))
                {
                    write.WriteLine("");
                    MessageBox.Show("Text deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("No file to delete. Create a file first.");
            }
        }

        // Exit button created here that returns the user to the
        // Main Menu
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Status_Load(object sender, EventArgs e)
        {

        }
    }
}

