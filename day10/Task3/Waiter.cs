using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Waiter : IOrderObserver
    {
        public void Update(string orderStatus)
        {
            Console.WriteLine($"Официант получил уведомление: {orderStatus}");
        }
    }
}
