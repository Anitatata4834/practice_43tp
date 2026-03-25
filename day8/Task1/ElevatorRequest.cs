using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ElevatorRequest
    {
        public int FloorNumber { get; set; }
        public string Direction { get; set; }
        public ElevatorRequest(int floor, string direction)
        {
            FloorNumber = floor;
            Direction = direction;
        }
        public void Print()
        {
            Console.WriteLine("Этаж: " + FloorNumber + ", направление: " + Direction);
        }
    }
}
