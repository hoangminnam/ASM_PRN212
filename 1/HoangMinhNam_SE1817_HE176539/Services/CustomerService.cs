using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }

        public void AddCustomer(Customer customer)
        {
            _repository.AddCustomer(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            _repository.DeleteCustomer(customer);
        }

        public Customer GetCustomerByPhone(string telephone)
        {
           return _repository.GetCustomerByPhone(telephone);
        }

        public List<Customer> GetListCustomer() => _repository.GetListCustomer();

        public void UpdateCustomer(Customer customer)
        {
            _repository.UpdateCustomer(customer);
        }
    }
}
