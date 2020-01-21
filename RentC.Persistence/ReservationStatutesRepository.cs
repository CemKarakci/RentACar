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
            newStatus.ReservStatsID = status.ReservStatsID;
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

        public static void UpdateStatus(DTO.ReservationStatusesDTO status)
        {
            var db = new RentCDataBaseEntities();
            var update = ConvertToEntity(status);

            var newStatus = db.ReservationStatuses.Where(p => p.ReservStatsID == update.ReservStatsID).FirstOrDefault();

            //newStatus.ReservStatsID = update.ReservStatsID;
            newStatus.Name = update.Name;
            newStatus.Description = update.Description;

            db.SaveChanges();

        }

        public static List<DTO.ReservationStatusesDTO> ListStatuses()
        {
            var db = new RentCDataBaseEntities();
            var statues = db.ReservationStatuses.ToList();

            var statutesDTO = ConvertToDTO(statues);


            return statutesDTO;

        }

        private static List<DTO.ReservationStatusesDTO> ConvertToDTO(List<ReservationStatuses> statues)
        {
            var statuesDTO = new List<DTO.ReservationStatusesDTO>();

            foreach (var statue in statues)
            {
                var statuedto = new DTO.ReservationStatusesDTO();
                statuedto.ReservStatsID = statue.ReservStatsID;
                statuedto.Name = statue.Name;
                statuedto.Description = statue.Description;

                statuesDTO.Add(statuedto);
            }
            return statuesDTO;
        }


    }
}
