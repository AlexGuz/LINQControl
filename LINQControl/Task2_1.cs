using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task2_1
    {
        public static int AggregateCount(int[] numbers)
        {
            return numbers.Aggregate(0, (n, i) => n = n + 1);
        }
        public static int AggregateMax(int[] numbers)
        {
            return numbers.Aggregate(int.MinValue,(n, i) => n < i ? i : n);
        }
        public static double AggregateAverage(int[] numbers)
        {
            return numbers.Aggregate(0, (n, i) => n += i) / numbers.Count();
        }
    }
}
