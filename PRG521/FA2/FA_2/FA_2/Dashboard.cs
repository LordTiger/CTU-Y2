using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FA_2
{
    public partial class Dashboard : Form
    {


        public Dashboard()
        {
            InitializeComponent();
        }

        //Admin Login Name Textbox
        private void a_name_TextChanged(object sender, EventArgs e)
        {

        }
        //Admin Login Password Textbox
        private void a_password_TextChanged(object sender, EventArgs e)
        {

        }
        //Admin login Button
        private void admin_login_Click(object sender, EventArgs e)
        {
            //Connection Stuff
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A9EC70F; Initial Catalog=FA2; Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin_data WHERE aEmail='" + a_name.Text + "' AND aPassword='" + a_password.Text + "'", con);
            DataTable dt = new DataTable(); //this is creating a virtual table
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Admin().Show();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
            }
 
        }
        //Donation Button
        private void cust_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Donate().Show();
        }


        //Dont Delete This
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
