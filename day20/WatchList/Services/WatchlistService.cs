namespace WatchList.Services
{
    public class WatchlistService : IWatchlistService
    {
        private readonly List<WatchlistItemDto> _items = new();
        private int _nextId = 1;

        public List<WatchlistItemDto> GetAll()
        {
            return _items;
        }

        public void Add(WatchlistItemDto item)
        {
            item.Id = _nextId++;
            _items.Add(item);
        }

        public void Delete(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
                _items.Remove(item);
        }
        public void MarkAsWatched(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
                item.Status = "Просмотрено";
        }
    }
}
