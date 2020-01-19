using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Domain
{
    public class CarsManager
    {
        public static List<DTO.CarsDTO> ListCars()
        {
            return Persistence.CarsRepository.ListCars();
        }
    }
}
