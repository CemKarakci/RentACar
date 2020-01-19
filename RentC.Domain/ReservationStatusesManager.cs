using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Domain
{
    public class ReservationStatusesManager
    {
        public static void CreateStatus(DTO.ReservationStatusesDTO status)
        {
            Persistence.ReservationStatutesRepository.CreateNewStatus(status);

        }
        public static DTO.ReservationStatusesDTO RetrieveStatus()
        {
            var status = Persistence.ReservationStatutesRepository.RetrieveStatus();
            return status;
        }
    }
}
