using WatchList.Models;

namespace WatchList.Services
{
    public interface IWatchlistService
    {
        List<WatchItem> GetAll();
        void Add(WatchItem item);
        void Delete(int id);
        void MarkAsWatched(int id);
    }
}
