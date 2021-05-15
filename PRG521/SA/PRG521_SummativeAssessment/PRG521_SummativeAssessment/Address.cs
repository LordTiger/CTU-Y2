using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PRG521_SummativeAssessment
{
    public partial class Address : Form
    {
        int ComplexNumber = 0;

        // Connection String established here for later use
        public string connectionString = @"Data Source=DESKTOP-A9EC70F; Initial Catalog=DBCtuLogistics;Integrated Security=True";
        SqlCommand formCommand = new SqlCommand();
        SqlDataAdapter adapt;

        public Address()
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
                adapt = new SqlDataAdapter("SELECT * FROM [DBCtuLogistics].[dbo].[Address]", connect);
                adapt.Fill(Table);
                dataGridView1.DataSource = Table;
                connect.Close();

            }
        }
        // Method to clear the text boxes after it's been used in the create, update or delete button
        private void ClearTextBoxes()
        {
            ComplexNmbrTxtbox.Text = "";
            ComplexNameTxtbox.Text = "";
            StreetTxtbox.Text = "";
            SuburbTxtbox.Text = "";
            CityTxtbox.Text = "";
            ProvinceTxtbox.Text = "";
            CountryTxtbox.Text = "";
            PostalCodeTxtbox.Text = "";
        }
        // Displays the content to string on data grid view
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ComplexNmbrTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ComplexNameTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            StreetTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SuburbTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CityTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            ProvinceTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            CountryTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            PostalCodeTxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        // Create button created here
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            if (ComplexNmbrTxtbox.Text != "" && ComplexNameTxtbox.Text != "" && StreetTxtbox.Text != "" && SuburbTxtbox.Text != "" && CityTxtbox.Text != "" && ProvinceTxtbox.Text != "" && CountryTxtbox.Text != "" && PostalCodeTxtbox.Text != "")
            {
                SqlCommand formCommand = new SqlCommand("Insert into Address(CNumber, CName, Street, Suburb, City, Province, Country, PostalCode) values (@ComplexNumber, @ComplexName, @Street, @Suburb, @City, @Province, @Country, @PostalCode)", connect);

                formCommand.Connection = connect;

                formCommand.Parameters.AddWithValue("@ComplexNumber", ComplexNmbrTxtbox.Text);
                formCommand.Parameters.AddWithValue("@ComplexName", ComplexNameTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Street", StreetTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Suburb", SuburbTxtbox.Text);
                formCommand.Parameters.AddWithValue("@City", CityTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Province", ProvinceTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Country", CountryTxtbox.Text);
                formCommand.Parameters.AddWithValue("@PostalCode", PostalCodeTxtbox.Text);

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

            if (ComplexNmbrTxtbox.Text != "")
            {
                int Find = Convert.ToInt32(ComplexNmbrTxtbox.Text);
                formCommand = new SqlCommand("Select CNumber, CName, Street, Suburb, City, Province, Country, PostalCode from Address where ComplexNumber =" + Find);
                formCommand.CommandType = CommandType.Text;
                formCommand.Connection = connect;
                connect.Open();

                SqlDataReader reader = formCommand.ExecuteReader();
                reader.Read();

                ComplexNmbrTxtbox.Text = reader["ComplexNumber"].ToString();
                ComplexNameTxtbox.Text = reader["ComplexName"].ToString();
                StreetTxtbox.Text = reader["Street"].ToString();
                SuburbTxtbox.Text = reader["Suburb"].ToString();
                CityTxtbox.Text = reader["City"].ToString();
                ProvinceTxtbox.Text = reader["Province"].ToString();
                CountryTxtbox.Text = reader["Country"].ToString();
                PostalCodeTxtbox.Text = reader["PostalCode"].ToString();

                connect.Close();
            }
            else
            {
                MessageBox.Show("No Complex Number entered. Please enter Complex Number.");
            }
        }

        // Update button created
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            if (ComplexNmbrTxtbox.Text != "" && ComplexNameTxtbox.Text != "" && StreetTxtbox.Text != "" && SuburbTxtbox.Text != "" && CityTxtbox.Text != "" && ProvinceTxtbox.Text != "" && CountryTxtbox.Text != "" && PostalCodeTxtbox.Text != "")
            {
                formCommand = new SqlCommand("update Address set CNumber=@ComplexNumber, CName=@ComplexName, Street=@Street, Suburb=@Suburb, City=@City, Province=@Province, Country=@Country, PostalCode=@PostalCode where ComplexNumber=@ComplexNumber AND ComplexName=@ComplexName", connect);
                formCommand.Connection = connect;
                connect.Open();

                formCommand.Parameters.AddWithValue("@ComplexNumber", ComplexNmbrTxtbox.Text);
                formCommand.Parameters.AddWithValue("@ComplexName", ComplexNameTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Street", StreetTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Suburb", SuburbTxtbox.Text);
                formCommand.Parameters.AddWithValue("@City", CityTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Province", ProvinceTxtbox.Text);
                formCommand.Parameters.AddWithValue("@Country", CountryTxtbox.Text);
                formCommand.Parameters.AddWithValue("@PostalCode", PostalCodeTxtbox.Text);
                formCommand.ExecuteNonQuery();
                MessageBox.Show("Your record has been updated");
                connect.Close();
                showData();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("No record selected. Insert a record you with to update with Complex Number and Complex Name.");
            }
}
        // Delete button created
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            formCommand.Connection = connect;

            ComplexNumber = Convert.ToInt32(ComplexNmbrTxtbox.Text);
            if (ComplexNumber != 0)
            {
                formCommand = new SqlCommand("delete Address where CNumber = @ComplexNumber AND CName=@ComplexName", connect);
                connect.Open();
                formCommand.Parameters.AddWithValue("@ComplexNumber", ComplexNumber);
                formCommand.Parameters.AddWithValue("@ComplexName", ComplexNameTxtbox.Text);
                formCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Record has been deleted.");
                showData();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("No Complex Number or Complex Name filled in. Please fill in a Complex Number and Complex Name.");
            }
        }

        // Exit button created here
        // Returns user to main menu
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Address_Load(object sender, EventArgs e)
        {

        }
    }
}
