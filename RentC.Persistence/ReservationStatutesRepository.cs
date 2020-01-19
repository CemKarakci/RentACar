using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Persistence
{
    public class ReservationStatutesRepository
    {
        public static void CreateNewStatus(DTO.ReservationStatusesDTO status)
        {
            var db = new RentCDataBaseEntities();
            var newStatus = ConvertToEntity(status);
            db.ReservationStatuses.Add(newStatus);
            db.SaveChanges();
           
        }

        private static ReservationStatuses ConvertToEntity(DTO.ReservationStatusesDTO status)
        {
            var newStatus = new ReservationStatuses();
            newStatus.Name = status.Name;
            newStatus.Description = status.Description;
            return newStatus;
        }

        public static DTO.ReservationStatusesDTO RetrieveStatus()
        {
            var db = new RentCDataBaseEntities();

            var status = db.ReservationStatuses.Max(p => p.ReservStatsID);

            var statusDto = new DTO.ReservationStatusesDTO();

            statusDto.ReservStatsID = status;

            return statusDto;

        }


    }
}
