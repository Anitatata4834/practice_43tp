using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileManager
    {
        public void CreateFile(string path, string text)
        {
            File.WriteAllText(path, text);
        }
        public void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine("Файл не найден");
        }
        public void CopyFile(string source, string dest)
        {
            File.Copy(source, dest, true);
        }
        public void MoveFile(string source, string dest)
        {
            File.Move(source, dest);
        }
        public void RenameFile(string path, string newName)
        {
            string folder = Path.GetDirectoryName(path);
            string newPath = Path.Combine(folder, newName);
            File.Move(path, newPath);
        }
        public void DeleteByPattern(string folder, string pattern)
        {
            string[] files = Directory.GetFiles(folder, pattern);
            foreach (string file in files)
                File.Delete(file);
        }
        public void ListFiles(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
                Console.WriteLine(file);
        }
        public void SetReadOnly(string path)
        {
            FileInfo fi = new FileInfo(path);
            fi.IsReadOnly = true;
        }
        public void TryWrite(string path, string text)
        {
            try
            {
                File.WriteAllText(path, text);
            }
            catch
            {
                Console.WriteLine("Запись запрещена");
            }
        }
    }
}
