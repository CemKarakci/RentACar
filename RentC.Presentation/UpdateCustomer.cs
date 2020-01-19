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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void updateCustomerToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void updateCustomerQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateCutomerButton_Click(object sender, EventArgs e)
        {
            var updateCustomer = new DTO.CustomersDTO();
            var customer = Domain.CustomersManager.ListCustomers();

            if (updateClientIdTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Client ID is a mandatory field");
                return;
            }

            else if (IsInteger(updateClientIdTextBox.Text) == false)
            {
                MessageBox.Show("Please Enter an Integer");
                return;
            }

            else if(IsIDExist(updateClientIdTextBox.Text, customer) == false)
            {
                MessageBox.Show("Please Enter a Valid ID");
            }

            else if (updateClientNametextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Client Name is a mandatory field");
                return;
            }


            else if (updateBirthDateTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Birth Date is a mandatory field");
                return;
            }


            else if (validateBirthDate(updateBirthDateTextBox.Text) == false)
            {
                MessageBox.Show("Please enter date in the form dd/MM/yyyy");
                return;
            }

            else if (updateZipCodeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Location is a mandatory field");
                return;
            }
            else
            {
                updateCustomer.CostumerID = Convert.ToInt32(updateClientIdTextBox.Text);
                updateCustomer.Name = updateClientNametextBox.Text;
                updateCustomer.BirthDate = DateTime.Parse(updateBirthDateTextBox.Text);
                updateCustomer.Location = updateZipCodeTextBox.Text;

                Domain.CustomersManager.UpdateCustomer(updateCustomer);

                MessageBox.Show("Updated Succesfully!");

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

        private bool IsIDExist(string text, List<CustomersDTO> customer)
        {
            var Ids = customer.Where(p => p.CostumerID == Convert.ToInt32(text));
            if (Ids.Count() == 0)
                return false;
            else
                return true;
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
