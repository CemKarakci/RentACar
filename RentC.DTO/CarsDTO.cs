using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DTO
{
    public partial class CarsDTO
    {
        
            //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            //public CarsDTO()
            //{
            //    this.ReservationsDTO = new HashSet<ReservationsDTO>();
            //}

            public int CarID { get; set; }
            public string Plate { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public decimal PricePerDay { get; set; }

            //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            //public virtual ICollection<ReservationsDTO> ReservationsDTO { get; set; }
        
    }
}
