using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Task1_2
    {
        public static int NumberOfLetters(string[] words)
        {
            int countOfLetters = words.SelectMany(w => w).Distinct().Count();
            return countOfLetters;
        }
    }
}
