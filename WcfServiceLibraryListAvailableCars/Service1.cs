using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RentC.DTO;

namespace WcfServiceLibraryListAvailableCars
{
    public class Service1 : IService1
    {

        public List<CarsDTO> ListCars()
        {
            List<CarsDTO> cars = RentC.Domain.CarsManager.ListCars();
            var reservations = RentC.Domain.ReservationsManager.ListReservations();

            var carsRented = from b in reservations
                             where
                                     ((DateTime.Now.Date >= b.StartDate) && (DateTime.Now.Date <= b.EndDate)) ||
                                     ((DateTime.Now.Date >= b.StartDate) && (DateTime.Now.Date <= b.EndDate)) ||
                                     ((DateTime.Now.Date <= b.StartDate) && (DateTime.Now.Date >= b.StartDate) && (DateTime.Now.Date <= b.EndDate)) ||
                                     ((DateTime.Now.Date >= b.StartDate) && (DateTime.Now.Date <= b.EndDate) && (DateTime.Now.Date >= b.EndDate)) ||
                                     ((DateTime.Now.Date <= b.StartDate) && (DateTime.Now.Date >= b.EndDate))
                             select b;

            var availableCars = cars.Where(r => !carsRented.Any(b => b.CarID == r.CarID)).ToList();
            return availableCars;

            //List<ReservationsDTO> newList = new List<ReservationsDTO>(reservations.FindAll(p => p.EndDate > DateTime.Now.Date && p.StartDate <= DateTime.Now.Date));

            //var carIds = newList.Select(x => x.CarID);

            //cars.RemoveAll(x => carIds.Contains(x.CarID));
            //return cars;
        }
    }

}
