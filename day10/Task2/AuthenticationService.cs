using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AuthenticationService
    {
        private IAuthStrategy _strategy;
        public AuthenticationService(IAuthStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IAuthStrategy strategy)
        {
            _strategy = strategy;
        }
        public void AuthenticateUser(string username, string password)
        {
            _strategy.Authenticate(username, password);
        }
    }
}
