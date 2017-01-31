using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task2_3
    {
        public static void JoinRandomNumbers(int[] numbers)
        {
            var randomList = numbers.Join(numbers, i1 => numbers, i2 => numbers, (i1, i2) => new { i1, i2 });

            foreach (var list in randomList)
            {
                Console.WriteLine(list.i1.ToString() + " " + list.i2);
            }
        }

        public static void JoinNotEqualNumbers(int[] numbers)
        {
            var randomList = numbers.Join(numbers, i1 => numbers, i2 => numbers, (i1, i2) => new { i1, i2 });
            var result = randomList.Where(pair => pair.i1 != pair.i2).ToList();

            foreach (var list in result)
            {
                Console.WriteLine(list.i1.ToString() + " " + list.i2);
            }
        }

        public static void GetPairsExceptSpecularPair(int[] numbers)
        {
            var randomList = numbers.Join(numbers, i1 => numbers, i2 => numbers, (i1, i2) => new { i1, i2 });
            var result = randomList.Where((pair, count) => randomList.Take(count).Any(specularPair =>(pair.i1 == specularPair.i2 && pair.i2 == specularPair.i1))).ToList();

            foreach (var list in result)
            {
                Console.WriteLine(list.i1.ToString() + " " + list.i2);
            }
        }
    }
}
