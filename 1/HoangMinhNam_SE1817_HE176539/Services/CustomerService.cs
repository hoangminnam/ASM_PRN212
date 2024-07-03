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
        public List<Customer> GetListCustomer() => _repository.GetListCustomer();
    }
}
