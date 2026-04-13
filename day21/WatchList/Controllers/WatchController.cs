using Microsoft.AspNetCore.Mvc;
using WatchList.Services;
using WatchList.Models;
using WatchList.ViewModels;

public class WatchController : Controller
{
    private readonly IWatchlistService _service;

    public WatchController(IWatchlistService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var items = _service.GetAll();

        ViewBag.ItemsPlanned = items.Where(x => x.Status == "Запланировано").ToList();
        ViewBag.ItemsWatching = items.Where(x => x.Status == "Смотрю").ToList();
        ViewBag.ItemsWatched = items.Where(x => x.Status == "Просмотрено").ToList();

        return View(new WatchlistItemViewModel());
    }

    [HttpPost]
    public IActionResult Add(WatchlistItemViewModel model)
    {
        if (!ModelState.IsValid)
            return View("Index", model);

        var item = new WatchItem
        {
            Title = model.Title,
            Genre = model.Genre,
            Type = model.Type,
            Status = model.Status
        };

        _service.Add(item);


        TempData["Message"] = "Добавлено в список";

        return RedirectToAction("Index");
    }

    public IActionResult MarkAsWatched(int id)
    {
        _service.MarkAsWatched(id);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        TempData["Message"] = "Удалено из списка";
        return RedirectToAction("Index");
    }
}
