using SortAnalyser.Core.Abstract;
using System;

namespace SortAnalyser.Core
{
    public class SelectionSorter : Sorter, ISorter
    {
        public void Sort(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                int minIndex = x;
                for (int y = x; y < array.Length; y++)
                {
                    if (array[minIndex] > array[y])
                    {
                        minIndex = y;
                    }
                }
                Swap(array, minIndex, x);
                ShowIteration(array);
            }
        }
    }
}
