namespace SortAnalyser.Core.Abstract
{
    public abstract class Sorter
    {
        protected void Swap(int[] array, int itemA, int itemB)
        {
            int temp = array[itemA];
            array[itemA] = array[itemB];
            array[itemB] = temp;
        }
    }
}
