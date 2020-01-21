using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Domain
{
    public class ReservationsManager
    {
       public static void RegisterNewCarRent(DTO.ReservationsDTO reservationsDTO)
        {
            Persistence.ReservationsRepository.RegisterNewCarRent(reservationsDTO);
        }

        public static DTO.CarsDTO FindCarIdByPlate(string plate)
        {
            var car = Persistence.ReservationsRepository.FindCarIdByPlate(plate);
            return car;
        }

        //public static void UpdateCarRent(DTO.ReservationsDTO reservationsDTO)
        //{
        //    Persistence.ReservationsRepository.UpdateCarRent(reservationsDTO);

        //}

        public static List<DTO.ReservationsDTO> ListReservations()
        {
            return Persistence.ReservationsRepository.ListReservations();
        }
    }
}
