using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Book
    {
        public string Title;
        public string Author;
        public int Pages;
    }
    sealed class FictionBook : Book
    {
        public FictionBook(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
    sealed class NonFictionBook : Book
    {
        public NonFictionBook(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
