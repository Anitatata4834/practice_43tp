using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FixedQueueProcessor<T>
    {
        private MyFixedQueue<T> _queue;
        public FixedQueueProcessor(int capacity)
        {
            _queue = new MyFixedQueue<T>(capacity);
        }
        public void Add(T item)
        {
            _queue.Enqueue(item);
        }
        public T Remove()
        {
            return _queue.Dequeue();
        }
        public bool Find(T item)
        {
            return _queue.Contains(item);
        }
        public void Sort()
        {
            _queue.Sort();
        }
        public void Show()
        {
            _queue.Print();
        }
    }
}
