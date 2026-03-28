using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TVPowerOnCommand : ICommand
    {
        private Television _tv;
        public TVPowerOnCommand(Television tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.PowerOn();
        }
    }
}
