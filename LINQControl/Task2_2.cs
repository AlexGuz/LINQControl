using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task2_2
    {
        public static Dictionary<string, int> AutorCountDictionary(IEnumerable<Book> books)
        {            
            var result = books.GroupBy(book => book.Author).ToDictionary(g => g.Key, g => g.Count());

            return result;
        }
    }
}
