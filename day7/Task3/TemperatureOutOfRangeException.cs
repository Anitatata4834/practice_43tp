using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TemperatureOutOfRangeException : Exception
    {
        public TemperatureOutOfRangeException() { }
        public TemperatureOutOfRangeException(string message) : base(message) { }
        public TemperatureOutOfRangeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
