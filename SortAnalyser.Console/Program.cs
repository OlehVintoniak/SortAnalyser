using System;
using System.Collections.Generic;
using System.Diagnostics;
using SortAnalyser.Core;

namespace SortAnalyser
{
    class Program
    {
        static void Main()
        {
            var array = GenerateArray(10);
            ShowArray(array);

            var watch = Stopwatch.StartNew();
            //Sort.Instance.BubbleSort(array);
            //Sort.Instance.InsertionSort(array);
            //Sort.Instance.MergeSort(array);
            //Sort.Instance.SelectionSort(array);
            Sort.Instance.QuickSort(array, 0, array.Length - 1);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            ShowArray(array);
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
