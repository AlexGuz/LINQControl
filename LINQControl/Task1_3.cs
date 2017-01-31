using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task1_3
    {
        public static IEnumerable<int> SortedArray(int[] numbers)
        {
            //если правильно понял задание-то должно быть так
            return numbers.OrderBy(i => i / 10).ThenByDescending(i => i % 10);
        }
    }
}
