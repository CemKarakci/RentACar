using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DTO
{
    public partial class CustomersDTO
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public CustomersDTO()
        //{
        //    this.Reservations = new HashSet<ReservationsDTO>();
        //}

        public int CostumerID { get; set; }
        public string Name { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Location { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ReservationsDTO> Reservations { get; set; }
    }
}
