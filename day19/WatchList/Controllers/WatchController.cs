using Microsoft.AspNetCore.Mvc;
using WatchList.Models;

namespace WatchList.Controllers
{
    public class WatchController : Controller
    {
        private static List<WatchItem> _items = new List<WatchItem>();
        private static int _nextId = 1;

        public IActionResult Index()
        {
            return View(_items);
        }

        [HttpPost]
        public IActionResult Add(string title, string type, string status)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                WatchItem item = new WatchItem();
                item.Id = _nextId;
                item.Title = title;
                item.Type = type;
                item.Status = status;

                _items.Add(item);
                _nextId = _nextId + 1;
            }

            return RedirectToAction("Index");
        }

        public IActionResult MarkAsWatched(int id)
        {
            WatchItem item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Status = "Просмотрено";
            }

            return RedirectToAction("Index");
        }
    }
}
