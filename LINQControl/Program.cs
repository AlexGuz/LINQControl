using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book { Name = "Book1 LINQ", Year = 2004, Author="SomeBody"},
                new Book { Name = "Book2", Year = 1963, Author="Puskin"},
                new Book { Name = "Book3 For Dummies", Year = 1999, Author="SomeBody"},
                new Book { Name = "Book4 .Net", Year = 2002, Author="Men"},
                new Book { Name = "Book5 SQL", Year = 2008, Author="Gorkij"},
                new Book { Name = "Book6 C#", Year = 2007, Author="Shevcenko"},
            };

            string[] words = { "дом", "сапог", "голова", "небо", "солнце" };

            int[] numbers = { 14, 12, 23, 20, 33, 32 };

            IEnumerable<Book> selectedBook = Task1_1.SelectBook(books);
            foreach (var book in selectedBook)
            {
                Console.WriteLine(book.Name + " " + book.Year);
            }

            int numberOfLetters = Task1_2.NumberOfLetters(words);
            Console.WriteLine("Number of letters :" + numberOfLetters);

            IEnumerable<int> sortedArray = Task1_3.SortedArray(numbers);
            foreach (var num in sortedArray)
            {
                Console.WriteLine(num);
            }

            Task1_4.AutorCount(books);

            Console.WriteLine("Average : " + Task2_1.AggregateAverage(numbers));
            Console.WriteLine("Count : " + Task2_1.AggregateCount(numbers));
            Console.WriteLine("Max : " + Task2_1.AggregateMax(numbers));

            Dictionary<string, int> autorDic = Task2_2.AutorCountDictionary(books);

            foreach (var book in autorDic)
            {
                Console.WriteLine(book.Key + " " + book.Value);
            }

            Task2_3.JoinRandomNumbers(numbers);
            Console.WriteLine();
            Task2_3.JoinNotEqualNumbers(numbers);
            Console.WriteLine();
            Task2_3.GetPairsExceptSpecularPair(numbers);

            Console.ReadLine();
        }
    }
}
