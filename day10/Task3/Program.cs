using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderSystem orderSystem = new OrderSystem();
            Customer customer = new Customer();
            Chef chef = new Chef();
            Waiter waiter = new Waiter();
            orderSystem.Subscribe(customer);
            orderSystem.Subscribe(chef);
            orderSystem.Subscribe(waiter);
            Console.WriteLine("Статусы заказа:");
            Console.WriteLine("Принят");
            Console.WriteLine("Готовится");
            Console.WriteLine("Готов");
            Console.WriteLine("Подан");
            while (true)
            {
                Console.Write("\nВведите статус заказа: ");
                string status = Console.ReadLine();
                orderSystem.UpdateOrderStatus(status);
                break;
            }
        }
    }
}
