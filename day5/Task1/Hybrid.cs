using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Hybrid : LearningMode
    {
        public override void GetLearningType()
        {
            Console.WriteLine("Hybrid - обучение может быть и online и offline");
        }
    }
}
