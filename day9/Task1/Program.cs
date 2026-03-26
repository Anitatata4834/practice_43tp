namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            FileInfoProvider info = new FileInfoProvider();
            string file = "roshepkina.ao";
            Console.WriteLine("Файл создан");
            manager.CreateFile(file, "Привет, Anita!");
            Console.WriteLine(File.ReadAllText(file));
            if (File.Exists(file))
            {
                Console.WriteLine("Удалить файл? (да/нет)");
                if (Console.ReadLine() == "да")
                {
                    manager.DeleteFile(file);
                    Console.WriteLine("Файл удалён");
                }
                else
                {
                    Console.WriteLine("Не удалён");
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
            if (File.Exists(file))
            {
                Console.WriteLine("Информация о файле:");
                info.GetInfo(file);
                Console.WriteLine("Файл скопирован");
                manager.CopyFile(file, "copy_file.ao");
                Directory.CreateDirectory("NewFolder");
                manager.MoveFile("copy_file.ao", "NewFolder/copy_file.ao");
                Console.WriteLine("Файл переименован");
                manager.RenameFile(file, "familiya.ao");
            }
            else
            {
                Console.WriteLine("Остальные действия невозможны — файла нет");
            }
            Console.WriteLine("Пробуем удалить несуществующий файл:");
            manager.DeleteFile("Нет такогo file.ao");
            if (File.Exists("familiya.ao") && File.Exists("NewFolder/copy_file.ao"))
            {
                Console.WriteLine("Сравнение файлов:");
                info.CompareFiles("familiya.ao", "NewFolder/copy_file.ao");
            }
            else
            {
                Console.WriteLine("Сравнение невозможно — одного из файлов нет");
            }
            Console.WriteLine("Удалить все файлы *.ao? (да/нет)");
            if (Console.ReadLine() == "да")
            {
                manager.DeleteByPattern(".", "*.ao");
                Console.WriteLine("Файлы удалены");
            }
            Console.WriteLine("Список файлов:");
            manager.ListFiles(".");
            Console.WriteLine("Запретить запись в файл familiya.ao");
            if (File.Exists("familiya.ao"))
            {
                manager.SetReadOnly("familiya.ao");
                manager.TryWrite("familiya.ao", "test");
                info.CheckAccess("familiya.ao");
            }
            else
            {
                Console.WriteLine("Файл familiya.ao не найден — действия пропущены");
            }
        }
    }
}
