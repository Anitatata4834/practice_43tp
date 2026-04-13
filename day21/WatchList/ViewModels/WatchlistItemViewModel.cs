using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WatchList.ViewModels
{
    public class WatchlistItemViewModel
    {
        [Required(ErrorMessage = "Название обязательно")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Жанр обязателен")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Тип обязателен")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Статус обязателен")]
        public string Status { get; set; }

        public List<string> Genres { get; set; } =
            new List<string> { "Драма", "Комедия", "Боевик", "Фантастика", "Приключения", "Романтика", "Ужасы", "Детектив", "Исторический" };

        public List<string> Statuses { get; set; } =
            new List<string> { "Запланировано", "Смотрю", "Просмотрено" };
    }
}
