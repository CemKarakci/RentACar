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
    public partial class ListAvailableCars : Form
    {
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

        public ListAvailableCars()
        {
            InitializeComponent();
        }

        private void listCarsToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void listAvailableCarsQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listAvailableCarsbutton_Click(object sender, EventArgs e)
        {
            listAvailableCarsDataGridView.AutoGenerateColumns = true;
            listAvailableCarsDataGridView.DataSource = null;

            List<DTO.CarsDTO> cars = new List<DTO.CarsDTO>();

            cars = obj.ListCars().ToList();
            ConstructGridView(cars);
            return;
            
        }

        private void ConstructGridView(List<CarsDTO> cars)
        {
            var bind = new BindingList<CarsDTO>(cars);
            var source = new BindingSource(bind, null);
            listAvailableCarsDataGridView.DataSource = source;

        }

      
        private void sortByPlatebutton_Click(object sender, EventArgs e)
        {
            listAvailableCarsDataGridView.AutoGenerateColumns = true;
            listAvailableCarsDataGridView.DataSource = null;

            var cars = obj.ListCars().ToList();

            var list = cars.OrderBy(p => p.Plate);

            ConstructGridView(list.ToList());

            return;
            

        }

        int NumberOfClick = 0;

        private void sortByIDbutton_Click(object sender, EventArgs e)
        {
            
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    listAvailableCarsDataGridView.AutoGenerateColumns = true;
                    listAvailableCarsDataGridView.DataSource = null;

                    var cars = obj.ListCars().ToList();

                    var list = cars.OrderByDescending(p => p.CarID);

                    ConstructGridView(list.ToList());
                    break;

                case 2:
                    listAvailableCarsDataGridView.AutoGenerateColumns = true;
                    listAvailableCarsDataGridView.DataSource = null;

                    var car = obj.ListCars().ToList();

                    var lists = car.OrderBy(p => p.CarID);

                    ConstructGridView(lists.ToList());
                    break;

                default:
                    listAvailableCarsDataGridView.AutoGenerateColumns = true;
                    listAvailableCarsDataGridView.DataSource = null;

                    var car1 = obj.ListCars().ToList();

                    var lists1 = car1.OrderBy(p => p.CarID);

                    ConstructGridView(lists1.ToList());
                    break;
            }
            return;

        }

        private void sortByManufacturerbutton_Click(object sender, EventArgs e)
        {
            listAvailableCarsDataGridView.AutoGenerateColumns = true;
            listAvailableCarsDataGridView.DataSource = null;

            var cars = obj.ListCars().ToList();

            var list = cars.OrderBy(p => p.Manufacturer);

            ConstructGridView(list.ToList());
            return;

        }

        private void sortByModelbutton_Click(object sender, EventArgs e)
        {
            listAvailableCarsDataGridView.AutoGenerateColumns = true;
            listAvailableCarsDataGridView.DataSource = null;

            var cars = obj.ListCars().ToList();

            var list = cars.OrderBy(p => p.Model);

            ConstructGridView(list.ToList());
            return;
        }
    }
}
