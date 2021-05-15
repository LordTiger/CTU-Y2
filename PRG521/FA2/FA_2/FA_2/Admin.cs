using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FA_2
{
    public partial class Admin : Form
    {

        //Connection Stuff
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A9EC70F; Initial Catalog=FA2; Integrated Security=True"); // making connection

        public Admin()
        {
            InitializeComponent();
        }

        // Method to clear the text boxes after it's been used in the create, update or delete button
        private void ClearTextBoxes()
        {
            aName.Text = "";
            aSurname.Text = "";
            aNumber.Text = "";
            aEmail.Text = "";
            aAmount.Text = "";
            aCID.Text = "";
        }

        private void DatasetUpdate()
        {
            // TODO: This line of code loads data into the 'fA2DataSet.cust_data' table. You can move, or remove it, as needed.
            this.cust_dataTableAdapter.Fill(this.fA2DataSet.cust_data);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Create Button
        private void aCreate_Click(object sender, EventArgs e)
        {
            con.Open(); //Opens Connection

            if (aName.Text != "" && aSurname.Text != "" && aNumber.Text != "" && aEmail.Text != "" && aAmount.Text != "") //Checks if All fields are filled in
            {
                SqlCommand fc = new SqlCommand("Insert into cust_data(cName, cSurname, cNumber, cEmail, cAmount, cDate, approved) values (@Name, @Surname, @Number, @Email, @Amount, @Date, @Approved)", con); //SQL Insert Query
                fc.Connection = con;

                fc.Parameters.AddWithValue("@Name", aName.Text); //SQL Parameter Vaule 1
                fc.Parameters.AddWithValue("@Surname", aSurname.Text); //SQL Parameter Vaule 2
                fc.Parameters.AddWithValue("@Number", aNumber.Text); //SQL Parameter Vaule 3
                fc.Parameters.AddWithValue("@Email", aEmail.Text); //SQL Parameter Vaule 4
                fc.Parameters.AddWithValue("@Amount", Convert.ToDecimal(aAmount.Text)); //SQL Parameter Vaule 5
                fc.Parameters.AddWithValue("@Date", DateTime.Today); //SQL Parameter Vaule 6 (Auto Inserts Todays Date)
                if(aCheckBox.CheckState == CheckState.Checked) // Check if the check box is checked
                {
                    fc.Parameters.AddWithValue("@Approved", 'Y'); //SQL Parameter Vaule 7 (Approved Thingy)
                }else
                {
                    fc.Parameters.AddWithValue("@Approved", 'N'); //SQL Parameter Vaule 7 (Approved Thingy)
                }

                fc.ExecuteNonQuery(); //Executes SQL Query
                con.Close(); //Closes Connection
                MessageBox.Show("Donator Added!"); //Message for the Donator
                ClearTextBoxes(); //Clears Text Boxes
                DatasetUpdate(); //Updates the Dataset
            }
            else
            {
                MessageBox.Show("Missing data from some or all fields."); // Message if one or two text fields are not filled in
            }
        }

        //Read Button
        private void aRead_Click(object sender, EventArgs e)
        {
            DatasetUpdate(); //Updates the Dataset
        }

        //Update Button
        private void aUpdate_Click(object sender, EventArgs e)
        {
            con.Open(); //Opens Connection

            if (aCID.Text != "") //Checks if Customer ID is filled in
            {
                SqlCommand fc = new SqlCommand("UPDATE cust_data SET approved = @Approved WHERE cid = @cid", con); //SQL Update Query
                fc.Connection = con;

                fc.Parameters.AddWithValue("@cid", Convert.ToInt32(aCID.Text)); //SQL Parameter Vaule 1
                if (aCheckBox.CheckState == CheckState.Checked)
                {
                    fc.Parameters.AddWithValue("@Approved", 'Y'); //SQL Parameter Vaule 2 (Approved Thingy)
                } else
                {
                    fc.Parameters.AddWithValue("@Approved", 'N'); //SQL Parameter Vaule 2 (Approved Thingy)
                }
                
                fc.ExecuteNonQuery(); //Executes SQL Query
                con.Close(); //Closes Connection
                MessageBox.Show("Donator Approved!"); //Message for the Donator
                ClearTextBoxes(); //Clears Text Boxes
                DatasetUpdate(); //Updates the Dataset
            }
            else
            {
                MessageBox.Show("Missing data from Customer ID Field."); // Message if Customer ID is Empty
            }
        }

        //Delete Button
        private void aDelete_Click(object sender, EventArgs e)
        {
            con.Open(); //Opens Connection

            if (aCID.Text != "") //Checks if Customer ID is filled in
            {
                SqlCommand fc = new SqlCommand("DELETE FROM cust_data WHERE cid = @cid", con); //SQL Update Query
                fc.Connection = con;
                fc.Parameters.AddWithValue("@cid", Convert.ToInt32(aCID.Text)); //SQL Parameter Vaule 1
               
                fc.ExecuteNonQuery(); //Executes SQL Query
                con.Close(); //Closes Connection
                MessageBox.Show("Donator Deleted!"); //Message for the Donator
                ClearTextBoxes(); //Clears Text Boxes
                DatasetUpdate(); //Updates the Dataset
            }
            else
            {
                MessageBox.Show("Missing data from Customer ID Field."); // Message if Customer ID is Empty
            }
        }
    }
}
