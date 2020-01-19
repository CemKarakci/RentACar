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
    public partial class ListCustomersForm : Form
    {
        public ListCustomersForm()
        {
            InitializeComponent();
        }

        private void listCustomersToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void listCustomersQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listCustomersButton_Click(object sender, EventArgs e)
        {
            listCustomersDataGridView.AutoGenerateColumns = true;
            listCustomersDataGridView.DataSource = null;

            var customers = Domain.CustomersManager.ListCustomers();

            ConstructGridView(customers);

            return;
        }

        private void ConstructGridView(List<DTO.CustomersDTO> customers)
        {
            var bind = new BindingList<DTO.CustomersDTO>(customers);
            var source = new BindingSource(bind, null);
            listCustomersDataGridView.DataSource = source;

        }

        int NumberOfClick = 0;
        private void SortByIDbutton_Click(object sender, EventArgs e)
        {
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    listCustomersDataGridView.AutoGenerateColumns = true;
                    listCustomersDataGridView.DataSource = null;

                    var customers = Domain.CustomersManager.ListCustomers();

                    var list = customers.OrderByDescending(p => p.CostumerID);

                    ConstructGridView(list.ToList());
                    break;

                case 2:
                    listCustomersDataGridView.AutoGenerateColumns = true;
                    listCustomersDataGridView.DataSource = null;

                    var customer = Domain.CustomersManager.ListCustomers();

                    var lists = customer.OrderBy(p => p.CostumerID);

                    ConstructGridView(lists.ToList());
                    break;

                default:
                    listCustomersDataGridView.AutoGenerateColumns = true;
                    listCustomersDataGridView.DataSource = null;

                    var customer1 = Domain.CustomersManager.ListCustomers();

                    var lists1 = customer1.OrderBy(p => p.CostumerID);

                    ConstructGridView(lists1.ToList());
                    break;
            }
            return;
        }

        private void sortByNamebutton_Click(object sender, EventArgs e)
        {
            listCustomersDataGridView.AutoGenerateColumns = true;
            listCustomersDataGridView.DataSource = null;

            var customers = Domain.CustomersManager.ListCustomers();


            var list = customers.OrderBy(p => p.Name);

            ConstructGridView(list.ToList());
            return;
        }

        private void sortByBirthDatebutton_Click(object sender, EventArgs e)
        {
            listCustomersDataGridView.AutoGenerateColumns = true;
            listCustomersDataGridView.DataSource = null;

            var customers = Domain.CustomersManager.ListCustomers();


            var list = customers.OrderBy(p => p.BirthDate);

            ConstructGridView(list.ToList());
            return;
        }

        private void sortByLocationbutton_Click(object sender, EventArgs e)
        {
            listCustomersDataGridView.AutoGenerateColumns = true;
            listCustomersDataGridView.DataSource = null;

            var customers = Domain.CustomersManager.ListCustomers();


            var list = customers.OrderBy(p => p.Location);

            ConstructGridView(list.ToList());
            return;

        }

    }
}

