using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class OrderSystem
    {
        private List<IOrderObserver> _observers = new List<IOrderObserver>();
        public void Subscribe(IOrderObserver observer)
        {
            _observers.Add(observer);
        }
        public void Unsubscribe(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }
        public void UpdateOrderStatus(string status)
        {
            Console.WriteLine($"\nСтатус заказа обновлён: {status}");
            Notify(status);
        }
        private void Notify(string status)
        {
            foreach (var observer in _observers)
            {
                observer.Update(status);
            }
        }
    }
}
