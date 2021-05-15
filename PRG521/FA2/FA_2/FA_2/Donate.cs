using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace FA_2
{
    public partial class Donate : Form
    {

        //Connection Stuff
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A9EC70F; Initial Catalog=FA2; Integrated Security=True"); // making connection

        public Donate()
        {
            InitializeComponent();
        }

        // Method to clear the text boxes after it's been used
        private void ClearTextBoxes()
        {
            custName.Text = "";
            custSurname.Text = "";
            custNumber.Text = "";
            custEmail.Text = "";
            custAmount.Text = "";
        }
        //Donation Button
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open(); //Opens Connection

            if(custName.Text != "" && custSurname.Text != "" && custNumber.Text != "" && custEmail.Text != "" && custAmount.Text != "") //Checks if All fields are filled in
            {
                SqlCommand fc = new SqlCommand("Insert into cust_data(cName, cSurname, cNumber, cEmail, cAmount, cDate) values (@Name, @Surname, @Number, @Email, @Amount, @Date)", con); //SQL Insert Query
                fc.Connection = con;

                fc.Parameters.AddWithValue("@Name", custName.Text); //SQL Parameter Vaule 1
                fc.Parameters.AddWithValue("@Surname", custSurname.Text); //SQL Parameter Vaule 2
                fc.Parameters.AddWithValue("@Number", custNumber.Text); //SQL Parameter Vaule 3
                fc.Parameters.AddWithValue("@Email", custEmail.Text); //SQL Parameter Vaule 4
                fc.Parameters.AddWithValue("@Amount", Convert.ToDecimal(custAmount.Text)); //SQL Parameter Vaule 5 (Also Converts To Decimal)
                fc.Parameters.AddWithValue("@Date", DateTime.Today); //SQL Parameter Vaule 6 (Auto Inserts Todays Date)

                fc.ExecuteNonQuery(); //Executes SQL Query
                con.Close(); //Closes Connection
                sendMail();
                MessageBox.Show("Thank you for your Donation!"); //Message for the Donator
                ClearTextBoxes(); //Clears Text Boxes
               
            } else
            {
                MessageBox.Show("Missing data from some or all fields."); // Message if one or two text fields are not filled in
                con.Close(); //Closes Connection
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Back Button
        private void custBack_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void Donate_Load(object sender, EventArgs e)
        {

        }

        public void sendMail()
        {
            try
            {
                SmtpClient cl = new SmtpClient(); // Smtp Client
                MailMessage msg = new MailMessage(); // Mail Message
                NetworkCredential nc = new NetworkCredential("No i do not consent", "No i do not consent"); // Network Credential thing so you can have access to send mails (This will be empty for the FA becuase i do not consent in giving my Personal Data to CTU.
                                                                                                               // But it will work for this FA you can see it working in a Screenshot that will be in a PDF)
                cl.Host = "smtp.live.com"; // Host for Microsoft Outlook Mail Server
                cl.Port = 587; // Port For Microsoft Outlook Mail Server
                cl.UseDefaultCredentials = false; // So it does not list as spam
                cl.Credentials = nc;
                cl.EnableSsl = true;

                MailAddress m_dest = new MailAddress("No i do not consent"); //(This will be empty for the FA becuase i do not consent in giving my Personal Data to CTU. But it will work for this FA you can see it working in a Screenshot that will be in a PDF)
                MailAddress m_source = new MailAddress("No i do not consent"); //(This will be empty for the FA becuase i do not consent in giving my Personal Data to CTU. But it will work for this FA you can see it working in a Screenshot that will be in a PDF)

                msg.Subject = "Donation Alert!";
                msg.Body = $"Donation Alert, Please, Check out Donation for MR.{custName.Text}";
                msg.From = m_source;
                msg.To.Add(m_dest);

                cl.Send(msg);
                MessageBox.Show("Donation Sent and Administration is notified");
            } catch(Exception ex)
            {
                MessageBox.Show("Error Code:" + ex);
            }

        }
    }
}
