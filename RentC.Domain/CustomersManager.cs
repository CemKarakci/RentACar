using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Domain
{
    public class CustomersManager
    {
        public static void RegisterNewCustomer(DTO.CustomersDTO newCustomer)
        {
            Persistence.CustomersRepository.RegisterNewCustomer(newCustomer);
        }

        public static void UpdateCustomer(DTO.CustomersDTO updateCustomer)
        {
            Persistence.CustomersRepository.UpdateCustomer(updateCustomer);
        }

        public static List<DTO.CustomersDTO> ListCustomers()
        {
            return Persistence.CustomersRepository.ListCustomers();
        }
    }

}
