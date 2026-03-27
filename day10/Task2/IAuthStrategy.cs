using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IAuthStrategy
    {
        public void Authenticate(string username, string password);
    }
}
