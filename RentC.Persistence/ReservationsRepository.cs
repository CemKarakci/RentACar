using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RentC.DTO;

namespace RentC.Persistence
{
    public class ReservationsRepository
    {
        public static void RegisterNewCarRent(ReservationsDTO reservationsDTO)
        {
            var db = new RentCDataBaseEntities();
            var reservation = ConvertToEntity(reservationsDTO);
            db.Reservations.Add(reservation);
            db.SaveChanges();            

        }

        public static DTO.CarsDTO FindCarIdByPlate(string plate)
        {
            var db = new RentCDataBaseEntities();
            var car = db.Cars.Where(p => p.Plate == plate).FirstOrDefault();
            if (car == null)
            {
                return null;
            }
            else
            {
                var carDTO = new DTO.CarsDTO();
                carDTO.Plate = car.Plate;
                carDTO.CarID = car.CarID;
                return carDTO;
            }
        }

        private static Reservations ConvertToEntity(ReservationsDTO reservationsDTO)
        {
          
            Reservations reservation = new Reservations();
            reservation.ReservationID = reservationsDTO.ReservationID;
            reservation.CarID = reservationsDTO.CarID;
            reservation.CostumerID = reservationsDTO.CostumerID;
            reservation.ReservStatsID = reservationsDTO.ReservStatsID;
            reservation.StartDate = reservationsDTO.StartDate;
            reservation.EndDate = reservationsDTO.EndDate;
            reservation.Location = reservationsDTO.Location;
            return reservation;
        }

        //public static void UpdateCarRent(DTO.ReservationsDTO update)
        //{
        //    var db = new RentCDataBaseEntities();
        //    var updateReservation = ConvertToEntity(update);

        //    var reservation = db.Reservations.Where(p => p.CarID == updateReservation.CarID 
        //    && p.CostumerID == updateReservation.CostumerID).FirstOrDefault<Reservations>();

        //    //reservation.ReservationID = updateReservation.ReservationID;
        //    reservation.CarID = updateReservation.CarID;
        //    reservation.CostumerID = updateReservation.CostumerID;
        //    reservation.ReservStatsID = updateReservation.ReservStatsID;
        //    reservation.StartDate = updateReservation.StartDate;
        //    reservation.EndDate = updateReservation.EndDate;
        //    reservation.Location = updateReservation.Location;

        //    db.SaveChanges();

        //}

        public static List<DTO.ReservationsDTO> ListReservations()
        {
            var db = new RentCDataBaseEntities();
            var reservations = db.Reservations.ToList();

            var cars = Persistence.CarsRepository.ListCars();
            var statuses = RentC.Persistence.ReservationStatutesRepository.ListStatuses();
            var canceledReservations = statuses.FindAll(x => x.Name == "CANCELED").ToList();
            var result = reservations.Where(p => !canceledReservations.Any(x => x.ReservStatsID == p.ReservStatsID)).ToList();

            var reservationDTO = ConvertToDTO(result);

            return reservationDTO;
        }

        private static List<DTO.ReservationsDTO> ConvertToDTO(List<Reservations> reservations)
        {
            var reservationsDTO = new List<DTO.ReservationsDTO>();

            foreach (var reservation in reservations)
            {
                var reservationDto = new DTO.ReservationsDTO();
                reservationDto.ReservationID = reservation.ReservationID;
                reservationDto.CarID = reservation.CarID;
                reservationDto.CostumerID = reservation.CostumerID;
                reservationDto.ReservStatsID = reservation.ReservStatsID;
                reservationDto.StartDate = reservation.StartDate;
                reservationDto.EndDate = reservation.EndDate;
                reservationDto.Location = reservation.Location;
                reservationDto.CouponCode = reservation.CouponCode;

                reservationsDTO.Add(reservationDto);

            }
            return reservationsDTO;
        }

    
    }

}
