using WatchList.Models;
using WatchList.Data;

namespace WatchList.Services
{
    public class WatchlistService : IWatchlistService
    {
        private readonly AppDbContext _context;

        public WatchlistService(AppDbContext context)
        {
            _context = context;
        }

        public List<WatchItem> GetAll()
        {
            return _context.WatchItems.ToList();
        }

        public void Add(WatchItem item)
        {
            _context.WatchItems.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.WatchItems.Find(id);
            if (item != null)
            {
                _context.WatchItems.Remove(item);
                _context.SaveChanges();
            }
        }

        public void MarkAsWatched(int id)
        {
            var item = _context.WatchItems.Find(id);
            if (item != null)
            {
                item.Status = "Просмотрено";
                _context.SaveChanges();
            }
        }
    }
}
