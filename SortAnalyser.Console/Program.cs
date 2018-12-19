using SortAnalyser.Core;
using System;
using System.Collections.Generic;

namespace SortAnalyser
{
    class Program
    {
        static void Main()
        {
            var array = GenerateArray(1000);

            var context = new SorterContext(new BubleSorter());

            var elapsedMs = context.GetSortTime(array);

            Console.WriteLine($"Time : {elapsedMs} milliseconds");
            Console.ReadLine();
        }

        #region Helpers


        private static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static int[] GenerateArray(int length)
        {
            Random rand = new Random();
            var listNumbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                listNumbers.Add(rand.Next(0, 10000));
            }
            return listNumbers.ToArray();
        }

        #endregion
    }
}
