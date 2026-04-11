namespace WatchList.Services
{
    public interface IWatchlistService
    {
        List<WatchlistItemDto> GetAll();
        void Add(WatchlistItemDto item);
        void Delete(int id);
        void MarkAsWatched(int id);

    }
}
