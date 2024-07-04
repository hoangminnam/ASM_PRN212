using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            CustomerDAO.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            CustomerDAO.Delete(customer);
        }

        public Customer GetCustomerByPhone(string telephone)
        {
           return CustomerDAO.GetCustomerByPhone(telephone);
        }

        public List<Customer> GetListCustomer() => CustomerDAO.GetListCustomer();

        public void UpdateCustomer(Customer customer)
        {
            CustomerDAO.Update(customer);
        }
    }
}
