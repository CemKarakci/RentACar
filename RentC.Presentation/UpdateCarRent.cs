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
    public partial class UpdateCarRentForm : Form
    {
        public UpdateCarRentForm()
        {
            InitializeComponent();
        }

        private void updateCarRentToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void updateCarRentQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateRentbutton_Click(object sender, EventArgs e)
        {
            var reservations = Domain.ReservationsManager.ListReservations();

            if (updateCarPlateTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Plate is a mendatory field");
                return;
            }

            else if (Domain.ReservationsManager.FindCarIdByPlate(updateCarPlateTextBox.Text) == null)
            {
                MessageBox.Show("Car is Not Listed");
                return;
            }


            else if (DoesExist(reservations, updateCarPlateTextBox.Text) == false)
            {
                MessageBox.Show("Please Enter a Plate From Existing Reservation");
                return;
            }

            else if (updateClientIdTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Client Id is a Manndatory Field");
                return;
            }

            else if (clientIDMatchPlate(reservations, updateCarPlateTextBox.Text, updateClientIdTextBox.Text) == false)
            {
                MessageBox.Show("ID and Plate Should Match");
                return;
            }

            //else if (updateStartDateDateTimePicker.Value.Date < DateTime.Now.Date)
            //{
            //    MessageBox.Show("Please Select a Valid Start Date");
            //    return;
            //}

            else if (startDateMatch(reservations, updateCarPlateTextBox.Text, updateClientIdTextBox.Text,
                updateStartDateDateTimePicker.Value.Date) == false)
            {
                MessageBox.Show("StartDate Doesn't Match any Reservations");
                return;
            }


            //else if (updateStartDateDateTimePicker.Value.Date >= updateEndDateDateTimePicker.Value.Date)
            //{
            //    MessageBox.Show("Please Select a Valid End Date");
            //    return;
            //}

            else if (endDateMatch(reservations, updateCarPlateTextBox.Text, updateClientIdTextBox.Text,
               updateEndDateDateTimePicker.Value.Date) == false)
            {
                MessageBox.Show("EndtDate Doesn't Match any Reservations");
                return;
            }

            else if (updateCityTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("City is a Manndatory Field");
                return;
            }


            else if (cityMatch(reservations, updateCarPlateTextBox.Text, updateClientIdTextBox.Text, updateEndDateDateTimePicker.Value.Date, updateCityTextBox.Text) == false)
            {
                MessageBox.Show("City Doesn't Match any Reservations");
                return;
            }

            else if (AlreadyCanceled(reservations, updateCarPlateTextBox.Text, updateClientIdTextBox.Text, updateEndDateDateTimePicker.Value.Date, updateCityTextBox.Text) == true)
            {
                MessageBox.Show("Can't Cancel. Already Canceled");
                return;
            }


            else
            {
                var reservation = new DTO.ReservationsDTO();
                var carPlate = updateCarPlateTextBox.Text;
                var car = Domain.ReservationsManager.FindCarIdByPlate(carPlate);

                var reserv = reservations.Find(p => p.CarID == car.CarID && p.CostumerID == Convert.ToInt32(updateClientIdTextBox.Text)
                && p.StartDate == updateStartDateDateTimePicker.Value.Date && p.EndDate == updateEndDateDateTimePicker.Value.Date).ReservStatsID;

                var reservStat = new ReservationStatusesDTO() { ReservStatsID = reserv, Name = "CANCELED", Description = "CANCELED" };

                Domain.ReservationStatusesManager.UpdateStatus(reservStat);

                //var status = new DTO.ReservationStatusesDTO();
                //status.Name = "UPDATE";
                //status.Description = "RESERVATION IS OPEN";
                //Domain.ReservationStatusesManager.CreateStatus(status);

                //var newStatus = Domain.ReservationStatusesManager.RetrieveStatus();


                //reservation.CarID = car.CarID;
                //reservation.ReservStatsID = newStatus.ReservStatsID;
                //reservation.CostumerID = Convert.ToInt32(updateClientIdTextBox.Text);
                //reservation.StartDate = updateStartDateDateTimePicker.Value;
                //reservation.EndDate = updateEndDateDateTimePicker.Value;
                //reservation.Location = updateCityTextBox.Text;
                //Domain.ReservationsManager.UpdateCarRent(reservation);
                MessageBox.Show("Updated Successfully!");
            }
        }

        private bool AlreadyCanceled(List<ReservationsDTO> reservations, string text, string text2, DateTime date, string text3)
        {
            var car = Domain.ReservationsManager.FindCarIdByPlate(text);
            var reservedCars = reservations.FindAll(x => x.CarID == car.CarID).ToList();
            var match = reservations.Where(p => p.CarID == car.CarID && p.CostumerID == Convert.ToInt32(text2)
            && p.EndDate == date && p.Location == text3);
            var statuses = Domain.ReservationStatusesManager.ListStatuses();
            var canceledReservations = statuses.FindAll(x => x.Name == "CANCELED").ToList();


            var result = match.Where(p => canceledReservations.Any(x => x.ReservStatsID == p.ReservStatsID)).ToList();


            if (result.Count() == 0)
                return false;
            else
                return true;

        }

        private bool cityMatch(List<ReservationsDTO> reservations, string text1, string text2, DateTime date, string text3)
        {
            var carID = Domain.ReservationsManager.FindCarIdByPlate(text1);

            if (reservations.Exists(p => p.CarID == carID.CarID && p.CostumerID == Convert.ToInt32(text2)
              && p.EndDate == updateEndDateDateTimePicker.Value.Date && p.Location == text3))

                return true;
            else
                return false;

        }

        private bool endDateMatch(List<ReservationsDTO> reservations, string text, string text2, DateTime date)
        {

            var carID = Domain.ReservationsManager.FindCarIdByPlate(text);
            var result = reservations.Where(p => p.CarID == carID.CarID && p.CostumerID == Convert.ToInt32(text2)
            && p.EndDate == date);

            if (result.Count() == 0)
                return false;
            else
                return true;
        }

        private bool startDateMatch(List<ReservationsDTO> reservations, string text, string text2, DateTime date)
        {
            var carID = Domain.ReservationsManager.FindCarIdByPlate(text);
            var result = reservations.Where(p => p.CarID == carID.CarID && p.CostumerID == Convert.ToInt32(text2)
             && p.StartDate == date);

            if (result.Count() == 0)
                return false;
            else
                return true;
        }



        private bool clientIDMatchPlate(List<ReservationsDTO> reservations, string text, string customer)
        {
            var carID = Domain.ReservationsManager.FindCarIdByPlate(text);
            var result = reservations.Where(p => p.CarID == carID.CarID && p.CostumerID == Convert.ToInt32(customer));
            if (result.Count() == 0)
                return false;
            else
                return true;
        

        }

        private bool DoesExist(List<ReservationsDTO> reservations, string text)
        {
            var carID = Domain.ReservationsManager.FindCarIdByPlate(text);     

            if (reservations.Exists(p => p.CarID == carID.CarID) == true)
                return true;
            else
                return false;
          
        }
    }
}
