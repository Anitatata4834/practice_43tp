using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Library
    {
        public Book[] Books;
        public Library(Book[] books)
        {
            Books = books;
        }
        public Book GetMostPagesBook()
        {
            if (Books.Length == 0)
                return null;
            Book max = Books[0];
            foreach (var book in Books)
            {
                if (book.Pages > max.Pages)
                    max = book;
            }
            return max;
        }
        public Book[] GetBooksByAuthor(string author)
        {
            int count = 0;
            foreach (var book in Books)
            {
                if (book.Author == author)
                    count++;
            }
            Book[] res = new Book[count];
            int i = 0;
            foreach (var book in Books)
            {
                if (book.Author == author)
                {
                    res[i] = book;
                    i++;
                }
            }
            return res;
        }
    }
}
