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

    public partial class Reports : Form
    {

        public Reports()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goldMembersButton_Click(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;

            var customers = Domain.CustomersManager.ListCustomers();
            var reservations = Domain.ReservationsManager.ListReservations();

            var newList = reservations.GroupBy(x => x.CostumerID).Where(y => y.Count() > 3).Select(y => y.Key);

            var goldMembers = customers.FindAll(x => newList.Contains(x.CostumerID));

            var bind = new BindingList<CustomersDTO>(goldMembers);
            var source = new BindingSource(bind, null);
            dataGridView1.DataSource = source;

        }

        private void recentRentsButton_Click(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();
            var recentRents = reservations.FindAll(p => p.StartDate >= DateTime.Now.Date.AddDays(-5));

            var bind = new BindingList<ReservationsDTO>(recentRents);
            var source = new BindingSource(bind, null);
            dataGridView1.DataSource = source;

        }

      

        private void silverCustomersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;

            var customers = Domain.CustomersManager.ListCustomers();
            var reservations = Domain.ReservationsManager.ListReservations();
            var newList = reservations.GroupBy(x => x.CostumerID).
                Where(y => y.Count() > 1 && y.Count() < 4).Select(y => y.Key);

            var silverMembers = customers.FindAll(x => newList.Contains(x.CostumerID));

           
            var bind = new BindingList<CustomersDTO>(silverMembers);
            var source = new BindingSource(bind, null);
            dataGridView1.DataSource = source;

          

        }

        private void mostRentedButton_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;

            var cars = Domain.CarsManager.ListCars();
            var reservations = Domain.ReservationsManager.ListReservations();
            var rezList = reservations.Where(p => p.StartDate > dateTimePicker1.Value.Date
            && p.EndDate < dateTimePicker2.Value.Date);

            var newList = rezList.GroupBy(x => x.CarID).OrderByDescending(y => y.Count()).Select(y => y.Key).Take(1).ToList();


            var mostRented = cars.FindAll(x => newList.Contains(x.CarID));

            var bind = new BindingList<CarsDTO>(mostRented);
            var source = new BindingSource(bind, null);
            dataGridView1.DataSource = source;

            

        }

        private void leastRentedButtonbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;

            var cars = Domain.CarsManager.ListCars();
            var reservations = Domain.ReservationsManager.ListReservations();
            var reserved = reservations.Select(p => p.CarID).ToList();

            var carList = cars.RemoveAll(x => reserved.Contains(x.CarID));

 
            if (cars.Count > 0)
            {
                var bind1 = new BindingList<CarsDTO>(cars);
                var source1 = new BindingSource(bind1, null);
                dataGridView1.DataSource = source1;
            }
            else
            {
                var cars1 = Domain.CarsManager.ListCars();
                var reservations1 = Domain.ReservationsManager.ListReservations();

                var rezList = reservations1.Where(p => p.StartDate > dateTimePicker1.Value.Date
                && p.EndDate < dateTimePicker2.Value.Date);

                var newList = rezList.GroupBy(x => x.CarID).OrderBy(y => y.Count()).Select(y => y.Key).Take(1).ToList();


                var leastRented = cars1.FindAll(x => newList.Contains(x.CarID));

                var bind = new BindingList<CarsDTO>(leastRented);
                var source = new BindingSource(bind, null);
                dataGridView1.DataSource = source;
            }

        }
    }
}
