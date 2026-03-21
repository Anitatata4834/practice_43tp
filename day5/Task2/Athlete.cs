using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Athlete
    {
        public string Name { get; set; }
        public Coach[] Coaches { get; set; }
        public Equipment Equipment { get; private set; }
        public Team Team { get; set; }
        public Athlete(string name, Coach[] coaches, Team team)
        {
            Name = name;
            Coaches = coaches;
            Team = team;
            Equipment = new Equipment("Базовая экипировка");
        }
        public void Train()
        {
            Console.WriteLine($"Спортсмен: {Name}");
            Console.WriteLine("Тренеры:");
            foreach (var coach in Coaches)
            {
                Console.WriteLine($"{coach.FullName}");
            }
            Console.WriteLine($"Экипировка: {Equipment.Type}");
            if (Team != null)
                Console.WriteLine($"Команда: {Team.Name}");
            Console.WriteLine("Начинает тренировку...\n");
        }
    }
}
