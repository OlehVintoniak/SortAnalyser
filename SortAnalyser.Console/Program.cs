using SortAnalyser.Core;
using System;
using System.Collections.Generic;

namespace SortAnalyser
{
    class Program
    {
        static void Main()
        {
            var array = GenerateArray(10);

            Console.WriteLine("1. Buble sort");
            Console.WriteLine("2. Insertion sort");
            Console.WriteLine("3. Selection sort");
            Console.WriteLine("4. Quick sort");
            Console.WriteLine("5. Merge sort");
            Console.Write("> ");
            var input = int.Parse(Console.ReadLine());
            
            var context = new SorterContext(input);

            Console.Clear();
            context.SorterAlgorithm.Sort(array);

            Console.ReadLine();
        }

        #region Helpers

        private static int[] GenerateArray(int length)
        {
            Random rand = new Random();
            var listNumbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                listNumbers.Add(rand.Next(0, 10));
            }
            return listNumbers.ToArray();
        }

        #endregion
    }
}
