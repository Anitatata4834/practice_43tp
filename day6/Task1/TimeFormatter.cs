using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TimeFormatter
    {
        public string FormatTime(DateTime time)
        {
            return "Время: " + time.ToString("HH:mm:ss");
        }
    }
}
