using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG521_SummativeAssessment
{
    public partial class Driver : Form
    {
        string RadioButtonTest;
        
        // Connection String established here for later use
        public string connectionString = @"Data Source=DESKTOP-A9EC70F; Initial Catalog=DBCtuLogistics;Integrated Security=True";
        SqlCommand formCommand = new SqlCommand();
        SqlDataAdapter adapt;

        public Driver()
        {
            InitializeComponent();
            ComboBoxItems();
            showData();
        }
        // Method to display the data on the data grid view
        private void showData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                DataTable Table = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM [DBCtuLogistics].[dbo].[Driver]", connect);
                adapt.Fill(Table);
                dataGridView1.DataSource = Table;
                connect.Close();

            }
        }
        // Method to clear the text boxes after it's been used in the create, update or delete button
        private void ClearTextBoxes()
        {
            FullNameTxtbox.Text = "";
            LicenseTypeCombox.Text = "";
            YesRadioBtn.Checked = false;
            NoRadioBtn.Checked = false;
        }
        // Method to add combo box items to combo box
        private void ComboBoxItems()
        {
            LicenseTypeCombox.Items.Add("Code 1");
            LicenseTypeCombox.Items.Add("Code 2");
            LicenseTypeCombox.Items.Add("Code 3");
        }

        // // Displays the content to string on data grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FullNameTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LicenseTypeCombox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        // Create button created here
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            if (FullNameTxtbox.Text != "" && LicenseTypeCombox.Text != "")
            {
                SqlCommand formCommand = new SqlCommand("Insert into Driver(FullName, LicenseType, Owner) values (@Fullname, @LicenseType, @Owner)", connect);

                formCommand.Connection = connect;

                formCommand.Parameters.AddWithValue("@FullName", FullNameTxtbox.Text);
                formCommand.Parameters.AddWithValue("@LicenseType", LicenseTypeCombox.GetItemText(LicenseTypeCombox.SelectedItem));

                if (YesRadioBtn.Checked)
                    formCommand.Parameters.AddWithValue("@Owner", "Yes");
                else
                    formCommand.Parameters.AddWithValue("@Owner", "No");

                formCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Your record has been saved.");

                showData();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("Missing some or all fields. Please fill in all the fields");
            }

        }

        // Read button created here
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            if (FullNameTxtbox.Text != "")
            {
                formCommand = new SqlCommand("Select FullName, LicenseType, Owner from Driver where FullName=@FullName", connect);

                formCommand.CommandType = CommandType.Text;
                formCommand.Connection = connect;
                connect.Open();

                formCommand.Parameters.AddWithValue("@FullName", FullNameTxtbox.Text);

                SqlDataReader reader = formCommand.ExecuteReader();
                reader.Read();

                FullNameTxtbox.Text = reader["FullName"].ToString();
                LicenseTypeCombox.Text = reader["LicenseType"].ToString();
                RadioButtonTest = reader["Owner"].ToString();

                if (RadioButtonTest == "Yes")
                {
                    YesRadioBtn.Checked = true;
                }
                else
                {
                    NoRadioBtn.Checked = true;
                }

                connect.Close();
            }
            else
            {
                MessageBox.Show("No Full Name entered. Please enter a Full Name.");
            }
        }

        // Update button created here
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            if (FullNameTxtbox.Text != "" && LicenseTypeCombox.Text != "")
            {
                formCommand = new SqlCommand("update Driver set FullName=@FullName, LicenseType=@LicenseType, Owner=@Owner where FullName=@FullName", connect);
                formCommand.Connection = connect;
                connect.Open();

                formCommand.Parameters.AddWithValue("@FullName", FullNameTxtbox.Text);
                formCommand.Parameters.AddWithValue("@LicenseType", LicenseTypeCombox.Text);

                if (YesRadioBtn.Checked)
                    formCommand.Parameters.AddWithValue("@Owner", "Yes");
                else
                    formCommand.Parameters.AddWithValue("@Owner", "No");

                formCommand.ExecuteNonQuery();
                MessageBox.Show("Your record has been updated");
                connect.Close();
                showData();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("No record selected. Please select a record update with Full Name.");
            }
        }

        // Delete button created here
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            if (FullNameTxtbox.Text != "")
            {
                formCommand = new SqlCommand("delete Driver where FullName = @FullName", connect);
                connect.Open();
                formCommand.Parameters.AddWithValue("@FullName", FullNameTxtbox.Text);
                formCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record has been deleted.");
                showData();
                ClearTextBoxes();         
            }
            else
            {
                MessageBox.Show("No Full Name entered. Enter a Full Name to delete a row.");
            }
        }

        // Exit button created here
        // Returns user to main menu
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Driver_Load(object sender, EventArgs e)
        {

        }
    }
}
    

