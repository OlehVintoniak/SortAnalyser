using SortAnalyser.Core.Abstract;

namespace SortAnalyser.Core
{
    public class BubleSorter: Sorter, ISorter
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(array, i, j);
                        ShowIteration(array);
                    }
                }
            }
        }
    }
}
