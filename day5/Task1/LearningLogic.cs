using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class LearningLogic
    {
        public void Process(LearningMode[] modes)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Показать все виды обучения");
            Console.WriteLine("2 - Показать только Online");
            Console.WriteLine("3 - Показать только Offline");
            Console.WriteLine("4 - Показать только Hybrid");
            Console.Write("Введите номер: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PrintAll(modes);
                    break;
                case 2:
                    PrintOnlyOnline(modes);
                    break;
                case 3:
                    PrintOnlyOffline(modes);
                    break;
                case 4:
                    PrintOnlyHybrid(modes);
                    break;
                default:
                    Console.WriteLine("Нет такого варианта");
                    break;
            }
        }
        public void PrintAll(LearningMode[] modes)
        {
            foreach (var mode in modes)
            {
                mode.GetLearningType();
            }
            Console.WriteLine();
        }
        public void PrintOnlyOnline(LearningMode[] modes)
        {
            foreach (var mode in modes)
            {
                if (mode is Online)
                    mode.GetLearningType();
            }
            Console.WriteLine();
        }
        public void PrintOnlyOffline(LearningMode[] modes)
        {
            foreach (var mode in modes)
            {
                if (mode is Offline)
                    mode.GetLearningType();
            }
            Console.WriteLine();
        }
        public void PrintOnlyHybrid(LearningMode[] modes)
        {
            foreach (var mode in modes)
            {
                if (mode is Hybrid)
                    mode.GetLearningType();
            }
            Console.WriteLine();
        }
    }
}
