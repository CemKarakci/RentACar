using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentC.DTO;

namespace RentC.Presentation
{
    public partial class RegisterNewCustomerForm : Form
    {
        public RegisterNewCustomerForm()
        {
            InitializeComponent();
        }

        private void registerNewCustomerToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();

        }

        private void registerNewCustomerQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newCutomerSubmitButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new DTO.CustomersDTO();
            var customer = Domain.CustomersManager.ListCustomers();

            if (clientIdTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Client ID is a Mandatory Field");
                return;
            }

           
            else if(IsInteger(clientIdTextBox.Text) == false)
            {
                MessageBox.Show("Please Enter an Integer");
                return;
            }

            else if (IDTaken(customer, clientIdTextBox.Text) == false)
            {
                MessageBox.Show("ID is Taken. Please Choose a New One");
                return;
            }

            else if (clientNametextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Client Name is a mandatory field");
                return;
            }

            else if (birthDateTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Birth Date is a Mandatory Field");
                return;
            }


            else if (validateBirthDate(birthDateTextBox.Text) == false)
            {
                MessageBox.Show("Please Enter Date in the form dd/MM/yyyy");
                return;
            }

            else if (zipCodeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Location is a Mandatory Field");
                return;
            }
            else
            {
                newCustomer.CostumerID = Convert.ToInt32(clientIdTextBox.Text);
                newCustomer.Name = clientNametextBox.Text;
                newCustomer.BirthDate = DateTime.Parse(birthDateTextBox.Text);
                newCustomer.Location = zipCodeTextBox.Text;

                Domain.CustomersManager.RegisterNewCustomer(newCustomer);

                MessageBox.Show("Customer Added Succesfully!");
            }

        }

        private bool IsInteger(string text)
        {
            int integer = 0;
            if (int.TryParse(text, out integer))
            {
                return true;
            }

            else
                return false;

        }

        private bool IDTaken(List<CustomersDTO> customer, string text)
        {
            var result = customer.Where(p => p.CostumerID == Convert.ToInt32(text));
            if (result.Count() == 0)
                return true;
            else
                return false;
        }

        private bool validateBirthDate(string text)
        {
            DateTime dDate;
            if (DateTime.TryParse(text, out dDate))
            {
                String.Format("{0:yyyy-MM-d}", dDate);
                return true;
            }
            else
            {
                return false;               
            }
        }
    }
}
