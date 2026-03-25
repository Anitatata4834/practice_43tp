using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ElevatorSystem
    {
        private Queue<ElevatorRequest> requests = new Queue<ElevatorRequest>();
        public void Add(ElevatorRequest request)
        {
            requests.Enqueue(request);
            Console.WriteLine("Запрос добавлен");
        }
        public void Process()
        {
            if (requests.Count == 0)
            {
                Console.WriteLine("Нет запросов");
                return;
            }
            var r = requests.Dequeue();
            Console.WriteLine("Обрабатывается запрос...");
            r.Print();
        }
        public void Show()
        {
            if (requests.Count == 0)
            {
                Console.WriteLine("Очередь пуста");
                return;
            }
            Console.WriteLine("Текущие запросы...");
            foreach (var r in requests)
                r.Print();
        }
        public void Find(int floor)
        {
            bool found = false;
            foreach (var r in requests)
            {
                if (r.FloorNumber == floor)
                {
                    Console.WriteLine("Найден запрос:");
                    r.Print();
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Запросов с таким этажом нет");
        }
    }
}
