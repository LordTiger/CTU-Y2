using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG521_SummativeAssessment
{
    public partial class Freight : Form
    {
        int CustomerNumber = 0;

        // Connecton string established here for later use
        public string connectionString = @"Data Source=DESKTOP-A9EC70F; Initial Catalog=DBCtuLogistics;Integrated Security=True";
        SqlCommand formCommand = new SqlCommand();
        SqlDataAdapter adapt;

        public Freight()
        {
            InitializeComponent();
            ComboBoxItems();
            showData();
        }

        // Method to add items to combo box
        private void ComboBoxItems()
        {
            StatusCombox.Items.Add("Delivered");
            StatusCombox.Items.Add("Not Delivered");
            StatusCombox.Items.Add("En Route");
        }

        // Method to show data from database in data grid view
        private void showData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                DataTable Table = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM [DBCtuLogistics].[dbo].[Freight]", connect);
                adapt.Fill(Table);
                dataGridView1.DataSource = Table;
                connect.Close();

            }
        }
        // Method to clear all text boxes after use
        private void ClearTextBoxes()
        {
            CustomerNmbrTxtbox.Text = "";
            HeightTxtbox.Text = "";
            LengthTxtbox.Text = "";
            WeightTxtbox.Text = "";
            DestinationTxtbox.Text = "";
            OriginAddressTxtbox.Text = "";
            StatusCombox.Text = "Status:";
        }

        // Displays the content to string on data grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerNmbrTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            HeightTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            LengthTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            WeightTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            DestinationTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            StatusCombox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            OriginAddressTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            DatePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        // Create button created here
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            if (CustomerNmbrTxtbox.Text != "" && HeightTxtbox.Text != "" && LengthTxtbox.Text != "" && WeightTxtbox.Text != "" && DestinationTxtbox.Text != "" && OriginAddressTxtbox.Text != "")
            {
                SqlCommand formCommand = new SqlCommand("Insert into Freight(CustomerNumber, Height, Weight, Lenght, DestinationAddressId, StatusId, OriginAddressId, Date) values (@CustomerNumber, @Height, @Weight, @Length, @DestinationAddressId, @StatusId, @OriginAddressId, @Date)", connect);

                formCommand.Connection = connect;

                formCommand.Parameters.AddWithValue("@CustomerNumber", CustomerNmbrTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Height", HeightTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Length", LengthTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Weight", WeightTxtbox.Text);
                formCommand.Parameters.AddWithValue("@DestinationAddressId", DestinationTxtbox.Text);
                formCommand.Parameters.AddWithValue("@StatusId", StatusCombox.GetItemText(StatusCombox.SelectedItem));
                formCommand.Parameters.AddWithValue("@OriginAddressId", OriginAddressTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Date", DatePicker.Text);

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

            if (CustomerNmbrTxtbox.Text != "")
            {
                int Find = Convert.ToInt32(CustomerNmbrTxtbox.Text);
                formCommand = new SqlCommand("Select CustomerNumber, Height, Weight, Lenght, DestinationAddressId, StatusId, OriginAddressId, Date from Freight where CustomerNumber =" + Find);

                formCommand.CommandType = CommandType.Text;
                formCommand.Connection = connect;
                connect.Open();
                
                SqlDataReader reader = formCommand.ExecuteReader();
                reader.Read();

                CustomerNmbrTxtbox.Text = reader["CustomerNumber"].ToString();
                HeightTxtbox.Text = reader["Height"].ToString();
                LengthTxtbox.Text = reader["Length"].ToString();
                WeightTxtbox.Text = reader["Weight"].ToString();
                DestinationTxtbox.Text = reader["DestinationAddressId"].ToString();
                StatusCombox.Text = reader["StatusId"].ToString();
                OriginAddressTxtbox.Text = reader["OriginAddressId"].ToString();
                DatePicker.Text = reader["Date"].ToString();

                connect.Close();

            }
            else
            {
                MessageBox.Show("No Customer Number entered. Please enter a Customer Number.");
            }
        }
        
        // Update button created here
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            if (CustomerNmbrTxtbox.Text != "" && HeightTxtbox.Text != "" && LengthTxtbox.Text != "" && WeightTxtbox.Text != "" && DestinationTxtbox.Text != "" && OriginAddressTxtbox.Text != "")
            {
                formCommand = new SqlCommand("update Freight set CustomerNumber=@CustomerNumber, Height=@Height, Lenght=@Length, Weight=@Weight, DestinationAddressId=@DestinationAddressId, StatusId=@StatusId, OriginAddressId=@OriginAddressId, Date=@Date where CustomerNumber=@CustomerNumber", connect);
                formCommand.Connection = connect;
                connect.Open();

                formCommand.Parameters.AddWithValue("@CustomerNumber", CustomerNmbrTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Height", HeightTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Length", LengthTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Weight", WeightTxtbox.Text);
                formCommand.Parameters.AddWithValue("@DestinationAddressId", DestinationTxtbox.Text);
                formCommand.Parameters.AddWithValue("@StatusId", StatusCombox.GetItemText(StatusCombox.SelectedItem));
                formCommand.Parameters.AddWithValue("@OriginAddressId", OriginAddressTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Date", DatePicker.Text);


                formCommand.ExecuteNonQuery();
                MessageBox.Show("Your record has been updated");
                connect.Close();
                showData();
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("No record selected. Please select a record update with Customer Number.");
            }
        }
    
        // Delete button created here
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            CustomerNumber = Convert.ToInt32(CustomerNmbrTxtbox.Text);

            if (CustomerNumber != 0)
            {
                formCommand = new SqlCommand("delete Freight where CustomerNumber = @CustomerNumber", connect);
                connect.Open();
                formCommand.Parameters.AddWithValue("@CustomerNumber", CustomerNumber);
                formCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record has been deleted.");
                showData();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("No record selected. Select a record to delete with Customer Number.");
            }
        }
    
        // Exit button created here
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Freight_Load(object sender, EventArgs e)
        {

        }
    }
}
