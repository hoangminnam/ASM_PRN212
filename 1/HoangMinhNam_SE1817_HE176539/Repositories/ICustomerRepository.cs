using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetListCustomer();

        public void DeleteCustomer(Customer customer);

        public void UpdateCustomer(Customer customer);

        public void AddCustomer(Customer customer);

        public Customer GetCustomerByPhone(string telephone);
    }
}
