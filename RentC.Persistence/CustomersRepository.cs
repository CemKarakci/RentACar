using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentC.Persistence
{
    public class CustomersRepository
    {
        public static void RegisterNewCustomer(DTO.CustomersDTO newCustomer)
        {
            var db = new RentCDataBaseEntities();
            var customer = ConvertToEntities(newCustomer);
            db.Customers.Add(customer);
            db.SaveChanges();


        }

        private static Customers ConvertToEntities(DTO.CustomersDTO customersDTO)
        {
            var customer = new Customers();
            customer.CostumerID = customersDTO.CostumerID;
            customer.Name = customersDTO.Name;
            customer.BirthDate = customersDTO.BirthDate;
            customer.Location = customersDTO.Location;
            return customer;
        }

        public static void UpdateCustomer(DTO.CustomersDTO updateCustomersDto)
        {
            var db = new RentCDataBaseEntities();
            var updateCustomer = ConvertToEntities(updateCustomersDto);

            var customer = db.Customers.Where(p => p.CostumerID == updateCustomer.CostumerID).FirstOrDefault<Customers>();
            customer.Name = updateCustomer.Name;
            customer.BirthDate = updateCustomer.BirthDate;
            customer.Location = updateCustomer.Location;

            db.SaveChanges();
        }

        public static List<DTO.CustomersDTO> ListCustomers()
        {
            var db = new RentCDataBaseEntities();

            var customers = db.Customers.ToList();

            var customerDTO = ConvertToDTO(customers);
            return customerDTO;

           
        }

        private static List<DTO.CustomersDTO> ConvertToDTO(List<Customers> customers)
        {
            var customersDto = new List<DTO.CustomersDTO>();

            foreach (var customer in customers)
            {
                var customerDTO = new DTO.CustomersDTO();

                customerDTO.CostumerID = customer.CostumerID;
                customerDTO.Name = customer.Name;
                customerDTO.BirthDate = customer.BirthDate;
                customerDTO.Location = customer.Location;

                customersDto.Add(customerDTO);

            }
            return customersDto;
        }
    }
}
