using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FileWatcher
    {
        private FileSystemWatcher watcher;
        public FileWatcher(string path)
        {
            watcher = new FileSystemWatcher(path);
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Changed += OnChanged;
            watcher.Renamed += OnRenamed;
            watcher.EnableRaisingEvents = true;
        }
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Создан файл: " + e.Name);
            if (e.FullPath.EndsWith(".tmp"))
            {
                try
                {
                    File.Delete(e.FullPath);
                    Console.WriteLine("Временный файл удалён автоматически");
                }
                catch
                {
                    Console.WriteLine("Не удалось удалить временный файл");
                }
            }
        }
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Удалён файл: " + e.Name);
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Изменён файл: " + e.Name);
        }
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Переименован файл: " + e.OldName + " - " + e.Name);
            if (e.FullPath.EndsWith(".tmp"))
            {
                try
                {
                    File.Delete(e.FullPath);
                    Console.WriteLine("Временный файл удалён автоматически");
                }
                catch
                {
                    Console.WriteLine("Не удалось удалить временный файл");
                }
            }
        }
    }
}
