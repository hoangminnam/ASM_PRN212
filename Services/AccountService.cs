using BusinessObjects;
using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly ICustomerRepository customerRepository;

        public AccountService()
        {
            customerRepository = new CustomerRepository();
        }

        public bool isUserAuthorized(string username)
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(AppContext.BaseDirectory)
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                .Build();
            if(configuration["DefaultAdmin:Email"].Equals(username))
                return true;
            return false;
        }

        public bool isValidUser(string username, string password)
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(AppContext.BaseDirectory)
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                .Build();
            var listC = customerRepository.GetListCustomer();

            string passwordAdmin = configuration["DefaultAdmin:Password"];

            if (username.Equals("admin@FUMiniHotelSystem.com") && passwordAdmin.Equals(password))
            {
                return true;
            }
            else
            {
                var customer = listC.FirstOrDefault(c => c.Telephone.Equals(username));
                if (customer != null)
                {
                    if(customer.Password == password)
                        return true;
                }
            }
            return false;
        }
    }
}
