using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileInfoProvider
    {
        public void GetInfo(string path)
        {
            FileInfo info = new FileInfo(path);
            Console.WriteLine("Размер: " + info.Length);
            Console.WriteLine("Создан: " + info.CreationTime);
        }
        public void CompareFiles(string f1, string f2)
        {
            FileInfo i1 = new FileInfo(f1);
            FileInfo i2 = new FileInfo(f2);
            if (i1.Length > i2.Length)
                Console.WriteLine("Первый файл больше");
            else if (i1.Length < i2.Length)
                Console.WriteLine("Второй файл больше");
            else
                Console.WriteLine("Файлы одинаковые");
        }
        public void CheckAccess(string path)
        {
            FileInfo info = new FileInfo(path);
            Console.WriteLine("Только чтение: " + info.IsReadOnly);
        }
    }
}
