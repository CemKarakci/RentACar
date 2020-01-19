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
    public partial class RegisterNewCarRentForm : Form
    {
        public RegisterNewCarRentForm()
        {
            InitializeComponent();
            

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            var cars = Domain.CarsManager.ListCars();
            var reservations = Domain.ReservationsManager.ListReservations();
            var customers = Domain.CustomersManager.ListCustomers();


            if (carPlateTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Plate is a Mandatory Field");
                return;
            }

            else if (Domain.ReservationsManager.FindCarIdByPlate(carPlateTextBox.Text) == null)
            {
                MessageBox.Show("Car is Not Listed");
                return;
            }


            else if (clientIdTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Client Id is a Mandatory Field");
                return;
            }

            else if (IsInteger(clientIdTextBox.Text) == false)
            {
                MessageBox.Show("Please Enter an Integer");
                return;
            }

            else if (doesExist(customers, clientIdTextBox.Text) == false)
            {
                MessageBox.Show("Client does not exist");
                return;
            }

            else if (startDateDateTimePicker.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please Select a Valid Start Date");
                return;
            }


            else if (IsReserved(reservations, carPlateTextBox.Text) == true
                      && CheckStartDate(reservations, carPlateTextBox.Text, startDateDateTimePicker.Value.Date) == false)
            {
                MessageBox.Show("Please Select a Different Date");
                return;
            }


            else if (endDateDateTimePicker.Value.Date <= startDateDateTimePicker.Value.Date)
            {
                MessageBox.Show("Please Select a Valid End Date");
                return;
               
            }

          

            else if (cityTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("City is a Mandatory Field");
                return;
            }

            else
            {
                var carPlate = carPlateTextBox.Text;
                var car = Domain.ReservationsManager.FindCarIdByPlate(carPlate);


                var status = new DTO.ReservationStatusesDTO();
                status.Name = "OPEN";
                status.Description = "RESERVATION IS OPEN";
                Domain.ReservationStatusesManager.CreateStatus(status);

                var newStatus = Domain.ReservationStatusesManager.RetrieveStatus();

                var reservation = new DTO.ReservationsDTO();


                reservation.CarID = car.CarID;
                reservation.ReservStatsID = newStatus.ReservStatsID;
                reservation.CostumerID = Convert.ToInt32(clientIdTextBox.Text);
                reservation.StartDate = startDateDateTimePicker.Value;
                reservation.EndDate = endDateDateTimePicker.Value;
                reservation.Location = cityTextBox.Text;
                Domain.ReservationsManager.RegisterNewCarRent(reservation);
                MessageBox.Show("Registered Successfully!");
            }


        }


        private bool CheckStartDate(List<ReservationsDTO> reservations, string text, DateTime date)
        {
            var car = Domain.ReservationsManager.FindCarIdByPlate(text);
            var reservedCars = reservations.FindAll(x => x.CarID == car.CarID).ToList();

            if ((reservedCars.OrderByDescending(p => p.StartDate).First().StartDate < date
                || reservedCars.OrderBy(p => p.StartDate).First().StartDate > date)
                || reservedCars.OrderByDescending(p => p.EndDate).First().EndDate < date)
                return true;

            else
                return false;

        }

        private bool IsInteger(string text)
        {
            int integer;
            if (int.TryParse(text, out integer))
            {
                return true;
            }

            else
                return false;

        }

        private bool IsReserved(List<ReservationsDTO> reservations, string text)
        {
            var car = Domain.ReservationsManager.FindCarIdByPlate(text);
            if (reservations.Exists(p => p.CarID == car.CarID) == true)
                return true;
            else
                return false;
        }



        private bool doesExist(List<CustomersDTO> customers, string text)
        {
            var clientId = customers.FindAll(p => p.CostumerID == Convert.ToInt32(text));
            if (clientId.Count == 0)
                return false;
            else
                return true;
        }

        private void newRentToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void newCarRentQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
