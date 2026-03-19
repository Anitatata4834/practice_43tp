using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public partial class Book
    {
        public void Print()
        {
            Console.WriteLine($"{Title} - {Author}, {Pages} стр., жанр: {Genre}");
        }
    }
}
