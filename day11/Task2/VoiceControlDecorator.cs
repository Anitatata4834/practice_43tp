using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class VoiceControlDecorator : RobotDecorator
    {
        public VoiceControlDecorator(IRobot robot) : base(robot) { }
        public override string GetStatus()
        {
            return base.GetStatus() + ", голосовое управление"; 
        }
    }
}
