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
    public partial class Customer : Form
    {
        int ContactNumber = 0;
        
        // Connection String established here for later use
        public string connectionString = @"Data Source=DESKTOP-A9EC70F; Initial Catalog=DBCtuLogistics;Integrated Security=True";
        SqlCommand formCommand = new SqlCommand();
        SqlDataAdapter adapt;

        public Customer()
        {
            InitializeComponent();
            showData();
        }

        // Method to display the data on the data grid view
        private void showData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                DataTable Table = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM [DBCtuLogistics].[dbo].[Customer]", connect);
                adapt.Fill(Table);
                dataGridView1.DataSource = Table;
                connect.Close();

            }
        }
        // Method to clear the text boxes after it's been used in the create, update or delete button
        private void ClearTextBoxes()
        {
            FullNameTxtbox.Text = "";
            ContactNumberTxtBox.Text = "";
            EmailTxtbox.Text = "";
        }
        // Displays the content to string on data grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FullNameTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ContactNumberTxtBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmailTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        // Create button created here
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            if (FullNameTxtbox.Text != "" && ContactNumberTxtBox.Text != "" && EmailTxtbox.Text != "")
            {
                SqlCommand formCommand = new SqlCommand("Insert into Customer(FullName, ContactNumber, Email) values (@Fullname, @ContactNumber, @Email)", connect);

                formCommand.Connection = connect;

                formCommand.Parameters.AddWithValue("@FullName", FullNameTxtbox.Text);
                formCommand.Parameters.AddWithValue("@ContactNumber", ContactNumberTxtBox.Text);
                formCommand.Parameters.AddWithValue("@Email", EmailTxtbox.Text);

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

            if (ContactNumberTxtBox.Text != "")
            {
                int Find = Convert.ToInt32(ContactNumberTxtBox.Text);
                formCommand = new SqlCommand("Select FullName, ContactNumber, Email from Customer where ContactNumber =" + Find);

                formCommand.CommandType = CommandType.Text;
                formCommand.Connection = connect;
                connect.Open();

                SqlDataReader reader = formCommand.ExecuteReader();
                reader.Read();

                FullNameTxtbox.Text = reader["FullName"].ToString();
                ContactNumberTxtBox.Text = reader["ContactNumber"].ToString();
                EmailTxtbox.Text = reader["Email"].ToString();

                connect.Close();
            }
            else
            {
                MessageBox.Show("No Contact Number entered. Please enter a Contact Number.");
            }
        }
        // Update button created
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            if (FullNameTxtbox.Text != "" && ContactNumberTxtBox.Text != "" && EmailTxtbox.Text != "")
            {
                formCommand = new SqlCommand("update Customer set FullName=@FullName, ContactNumber=@ContactNumber, Email=@Email where ContactNumber=@ContactNumber", connect);
                formCommand.Connection = connect;
                connect.Open();

                formCommand.Parameters.AddWithValue("@FullName", FullNameTxtbox.Text);
                formCommand.Parameters.AddWithValue("@ContactNumber", ContactNumberTxtBox.Text);
                formCommand.Parameters.AddWithValue("@Email", EmailTxtbox.Text);
                formCommand.ExecuteNonQuery();
                MessageBox.Show("Your record has been updated");
                connect.Close();
                showData();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("No record selected. Please select a record update with Contact Number.");
            }
        }
        // Delete button created
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            ContactNumber = Convert.ToInt32(ContactNumberTxtBox.Text);
            if (ContactNumber != 0)
            {
                formCommand = new SqlCommand("delete Customer where ContactNumber = @ContactNumber", connect);
                connect.Open();
                formCommand.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                formCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record has been deleted.");
                showData();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("No record selected. Select a record to delete with Contact Number.");
            }
        }
        
        // Exit button created here
        // Returns user to main menu
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
