using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task1_1
    {
        public static IEnumerable<Book> SelectBook(IEnumerable<Book> books)
        {
            var selectedBooks = books.Where(book => book.Name.Contains("LINQ") && DateTime.IsLeapYear(book.Year));
            return selectedBooks;

        }
    }
}
