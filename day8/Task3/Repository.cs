using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public bool Remove(T item)
        {
            return items.Remove(item);
        }
        public IEnumerable<T> GetAll()
        {
            return items;
        }
    }
}
