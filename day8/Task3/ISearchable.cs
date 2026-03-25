using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface ISearchable<T>
    {
        T Find(IEnumerable<T> items, Func<T, bool> predicate);
    }
}
