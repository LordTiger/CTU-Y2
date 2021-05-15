using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG521_SummativeAssessment
{
    // This form acts as the portal between
    // All the other forms
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // Methods to link to other forms created here
        private void LinkToAdresses()
        {
            Address address = new Address();
            address.ShowDialog();
        }

        private void LinkToCustomers()
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void LinkToFreight()
        {
            Freight freight = new Freight();
            freight.ShowDialog();
        }
        
        private void LinkToDrivers()
        {
            Driver driver = new Driver();
            driver.ShowDialog();
        }

        private void LinkToStatus()
        {
            Status status = new Status();
            status.ShowDialog();
        }

        private void AppExit()
        {
            Environment.Exit(0);
        }
        
        // Methods then used in each button
        private void AddressBtn_Click(object sender, EventArgs e)
        {
            LinkToAdresses();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            LinkToCustomers();
        }

        private void FreightBtn_Click(object sender, EventArgs e)
        {
            LinkToFreight();
        }

        private void DriversBtn_Click(object sender, EventArgs e)
        {
            LinkToDrivers();
        }

        private void StatusBtn_Click(object sender, EventArgs e)
        {
            LinkToStatus();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            AppExit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
