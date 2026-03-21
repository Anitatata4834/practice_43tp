using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Offline : LearningMode
    {
        public override void GetLearningType()
        {
            Console.WriteLine("Offline - обучение проходит в аудитории");
        }
    }
}
