using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class RobotDecorator : IRobot
    {
        protected IRobot _robot;
        public RobotDecorator(IRobot robot)
        {
            _robot = robot;
        }
        public virtual string GetStatus()
        {
            return _robot.GetStatus();
        }
    }
}
