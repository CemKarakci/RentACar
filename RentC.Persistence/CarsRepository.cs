using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Persistence
{
    public class CarsRepository
    {
        public static List<DTO.CarsDTO> ListCars()
        {
            var db = new RentCDataBaseEntities();
            var cars = db.Cars.ToList();

            var carsDTO = ConvertToDTO(cars);
            return carsDTO;

        }

        private static List<DTO.CarsDTO> ConvertToDTO(List<Cars> cars)
        {
            var carsDTO = new List<DTO.CarsDTO>();
            foreach (var car in cars)
            {
                var carDto = new DTO.CarsDTO();
                carDto.CarID = car.CarID;
                carDto.Plate = car.Plate;
                carDto.Manufacturer = car.Manufacturer;
                carDto.Model = car.Model;
                carDto.PricePerDay = car.PricePerDay;

                carsDTO.Add(carDto);
            }

            return carsDTO;
        }
    }
}
