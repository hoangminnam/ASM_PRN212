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
        private static List<Customer> customers = new List<Customer>
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

        public static List<Customer> GetListCustomer()
        {
            return customers;
        }

        public static void Delete(Customer customer)
        {
            customers.Remove(customer);
        }

        public static void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public static void Update(Customer customer)
        {
            var c = customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            if(c != null)
            {
                c.CustomerFullName = customer.CustomerFullName;
                c.Telephone = customer.Telephone;
                c.EmailAddress = customer.EmailAddress;
                c.CustomerStatus = customer.CustomerStatus;
                c.Password = customer.Password;
            }
        }
        public static Customer GetCustomerByPhone(string telephone)
        {
            return customers.FirstOrDefault(c => c.Telephone == telephone);
        }
    }
}
