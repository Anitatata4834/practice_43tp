using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MyFixedQueue<T>
    {
        private List<T> _items = new List<T>();
        private int _capacity;   
        public MyFixedQueue(int capacity)
        {
            _capacity = capacity;
        }
        public void Enqueue(T item)
        {
            if (_items.Count == _capacity)
            {
                _items.RemoveAt(0);
            }
            _items.Add(item);
        }
        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста");
            }
            T value = _items[0];
            _items.RemoveAt(0);
            return value;
        }
        public bool Contains(T item)
        {
            return _items.Contains(item);
        }
        public void Sort()
        {
            _items.Sort();
        }
        public void Print()
        {
            Console.WriteLine("Очередь: " + string.Join(", ", _items));
        }
    }
}
