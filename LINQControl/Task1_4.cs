using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task1_4
    {
        public static void AutorCount(IEnumerable<Book> books)
        {
            var sortedBooks = books.GroupBy(b => b.Author);

            foreach (var item in sortedBooks)
            {
                Console.WriteLine("{0} have {1} books", item.Key, item.Count());
            }
        }
    }
}
