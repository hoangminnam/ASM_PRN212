using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        public static List<Customer> GetListCustomer()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    CustomerFullName = "Nguyen Van A",
                    Telephone = "+84123456789",
                    EmailAddress = "nguyenvana@example.com",
                    CustomerStatus = true,
                    Password = "password123"
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerFullName = "Tran Thi B",
                    Telephone = "+84987654321",
                    EmailAddress = "tranthib@example.com",
                    CustomerStatus = false,
                    Password = "password456"
                },
                new Customer
                {
                    CustomerId = 3,
                    CustomerFullName = "Le Van C",
                    Telephone = "+84234567890",
                    EmailAddress = "levanc@example.com",
                    CustomerStatus = true,
                    Password = "password789"
                }
            };
            return customers;
        }
    }
}
