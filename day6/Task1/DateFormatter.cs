using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    delegate string TimeHandler(DateTime time);
    public class DateFormatter
    {
        public string FormatDate(DateTime time)
        {
            return "Дата: " + time.ToString("dd.MM.yyyy");
        }
    }
}
