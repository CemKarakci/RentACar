using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DTO
{
    public partial class CouponsDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CouponsDTO()
        {
            this.Reservations = new HashSet<ReservationsDTO>();
        }

        public string CouponCode { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationsDTO> Reservations { get; set; }
    }
}
