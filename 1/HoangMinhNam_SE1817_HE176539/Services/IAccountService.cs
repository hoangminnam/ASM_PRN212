using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IAccountService
    {
        public bool isValidUser(string username, string password);

        public bool isUserAuthorized(string username);
    }
}
