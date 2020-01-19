using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentC.Presentation
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }
       


        private void registerNewCarRentButton_Click(object sender, EventArgs e)
        {
            Hide();
            var registerNewCarRent = new RegisterNewCarRentForm();
            registerNewCarRent.Show();
        }

        private void updateCarRentButton_Click(object sender, EventArgs e)
        {
            Hide();
            var updateCarRent = new UpdateCarRentForm();
            updateCarRent.Show();
        }

        private void listRentsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var listRents = new ListRentsForm();
            listRents.Show();
        }

        private void listAvailableCarsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var listAvailableCars = new ListAvailableCars();
            listAvailableCars.Show();

        }

        private void registerNewCustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            var registerNewCustomer = new RegisterNewCustomerForm();
            registerNewCustomer.Show();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            var updateCustomer = new UpdateCustomerForm();
            updateCustomer.Show();
        }

        private void listCustomersButton_Click(object sender, EventArgs e)
        {
            Hide();
            var listCustomers = new ListCustomersForm();
            listCustomers.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Hide();
            var reports = new Reports();
            reports.Show();
        }
    }
}
