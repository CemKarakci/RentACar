using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.DTO
{
    public partial class UsersDTO
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public int RoleID { get; set; }

        public virtual RolesDTO Roles { get; set; }
    }
}
