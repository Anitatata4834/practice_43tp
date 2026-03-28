using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class NavigationDecorator : RobotDecorator
    {
        public NavigationDecorator(IRobot robot) : base(robot) { }
        public override string GetStatus()
        {
            return base.GetStatus() + ", улучшенная навигация";
        }
    }
}
