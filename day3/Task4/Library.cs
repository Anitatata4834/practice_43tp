using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Library
    {
        public Book[] Books { get; set; }
        public Library(Book[] books)
        {
            Books = books;
        }
        public Book GetLongestBook()
        {
            Book longest = Books[0];
            foreach (var book in Books)
            {
                if (book.Pages > longest.Pages)
                    longest = book;
            }
            return longest;
        }
        public Book[] GetBooksByGenre(string genre)
        {
            int count = 0;
            foreach (var book in Books)
            {
                if (book.Genre == genre)
                    count++;
            }
            Book[] result = new Book[count];
            int i = 0;
            foreach (var book in Books)
            {
                if (book.Genre == genre)
                {
                    result[i] = book;
                    i++;
                }
            }
            return result;
        }
    }
}
