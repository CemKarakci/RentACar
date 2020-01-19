using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DTO
{
    public partial class ReservationsDTO
    {
        public int ReservationID { get; set; }
        public int CarID { get; set; }
        public int CostumerID { get; set; }
        public byte ReservStatsID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string CouponCode { get; set; }
        

        //public virtual CarsDTO Cars { get; set; }
        //public virtual CouponsDTO Coupons { get; set; }
        //public virtual CustomersDTO Customers { get; set; }
        //public virtual ReservationStatusesDTO ReservationStatuses { get; set; }
    }
}
