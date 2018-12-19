using SortAnalyser.Core.Abstract;

namespace SortAnalyser.Core
{
    public class InsertionSorter: Sorter, ISorter
    {
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
                ShowIteration(array);
            }
        }
    }
}
