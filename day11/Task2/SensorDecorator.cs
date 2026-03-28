using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SensorDecorator : RobotDecorator
    {
        public SensorDecorator(IRobot robot) : base(robot) { }

        public override string GetStatus()
        {
            return base.GetStatus() + ", дополнительные датчики";
        }
    }
}
