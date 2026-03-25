using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class SearchManager<T>
    {
        private Repository<T> repository;
        private ISearchable<T> searcher;
        public SearchManager(Repository<T> repo, ISearchable<T> searcher)
        {
            repository = repo;
            this.searcher = searcher;
        }
        public void AddItem(T item)
        {
            repository.Add(item);
        }
        public void RemoveItem(T item)
        {
            bool removed = repository.Remove(item);
            if (removed)
                Console.WriteLine("Удалено: " + item);
            else
                Console.WriteLine("Число не найдено, удалить невозможно");
        }
        public T SearchItem(Func<T, bool> predicate)
        {
            return searcher.Find(repository.GetAll(), predicate);
        }
        public void DisplaySearchResult(T item)
        {
            if (item == null || item.Equals(default(T)))
                Console.WriteLine("Число не найдено");
            else
                Console.WriteLine("Найдено число: " + item);
        }
        public void SortItems()
        {
            var list = repository.GetAll().ToList();
            list.Sort();
            Console.WriteLine("Отсортированные числа:");
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
