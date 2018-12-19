using SortAnalyser.Core.Abstract;

namespace SortAnalyser.Core
{
    public class QuickSorter : Sorter, ISorter
    {
        public void Sort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }

        private int Partition(int[] array, int start, int end)
        {
            int marker = start;//divides left and right subArrays
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    Swap(array, i, marker);
                    marker += 1;
                    ShowIteration(array);
                }
            }
            //put pivot(array[end]) between left and right subArrays
            Swap(array, marker, end);
            return marker;
        }
    }
}
