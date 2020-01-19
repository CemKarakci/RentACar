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
    public partial class ListRentsForm : Form
    {
        public ListRentsForm()
        {
            InitializeComponent();
        }

        private void listRentsToHomebutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();

        }

        private void listRentsQuitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listRentsbutton_Click(object sender, EventArgs e)
        {

            listRentsDataGridView.AutoGenerateColumns = true;
            listRentsDataGridView.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();

            ConstructGridView(reservations);
            return;

        }

        private void ConstructGridView(List<DTO.ReservationsDTO> reservations)
        {
            var bind = new BindingList<DTO.ReservationsDTO>(reservations);
            var source = new BindingSource(bind, null);
            listRentsDataGridView.DataSource = source;
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            listRentsDataGridView.AutoGenerateColumns = true;
            listRentsDataGridView.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();


            var list = reservations.OrderBy(p => p.Location);

            ConstructGridView(list.ToList());

            return;

        }
        int NumberOfClick = 0;
        private void carIDButton_Click(object sender, EventArgs e)
        {
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    listRentsDataGridView.AutoGenerateColumns = true;
                    listRentsDataGridView.DataSource = null;

                    var reservations = Domain.ReservationsManager.ListReservations();

                    var list = reservations.OrderByDescending(p => p.CarID);

                    ConstructGridView(list.ToList());
                    break;

                case 2:
                    listRentsDataGridView.AutoGenerateColumns = true;
                    listRentsDataGridView.DataSource = null;

                    var reservation = Domain.ReservationsManager.ListReservations();
                    var lists = reservation.OrderBy(p => p.CarID);

                    ConstructGridView(lists.ToList());
                    break;

                default:
                    listRentsDataGridView.AutoGenerateColumns = true;
                    listRentsDataGridView.DataSource = null;

                    var reservation1 = Domain.ReservationsManager.ListReservations();
                    var lists1 = reservation1.OrderBy(p => p.CarID);

                    ConstructGridView(lists1.ToList());

                    break;
            }
            return;
        }

        private void customerIDButton_Click(object sender, EventArgs e)
        {
            listRentsDataGridView.AutoGenerateColumns = true;
            listRentsDataGridView.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();


            var list = reservations.OrderBy(p => p.CostumerID);

            ConstructGridView(list.ToList());
            return;
        }

        private void reservStatsButton_Click(object sender, EventArgs e)
        {
            listRentsDataGridView.AutoGenerateColumns = true;
            listRentsDataGridView.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();


            var list = reservations.OrderBy(p => p.ReservStatsID);

            ConstructGridView(list.ToList());
            return;

        }

        private void startDateButton_Click(object sender, EventArgs e)
        {
            listRentsDataGridView.AutoGenerateColumns = true;
            listRentsDataGridView.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();


            var list = reservations.OrderBy(p => p.StartDate);

            ConstructGridView(list.ToList());
            return;
        }

        private void endDateButton_Click(object sender, EventArgs e)
        {

            listRentsDataGridView.AutoGenerateColumns = true;
            listRentsDataGridView.DataSource = null;

            var reservations = Domain.ReservationsManager.ListReservations();


            var list = reservations.OrderBy(p => p.EndDate);

            ConstructGridView(list.ToList());
            return;

        }

       
    }
}
