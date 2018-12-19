using SortAnalyser.Core.Abstract;
using SortAnalyser.Core.Factory;
using System.Diagnostics;

namespace SortAnalyser.Core
{
    public class SorterContext
    {
        public ISorter SorterAlgorithm;

        public SorterContext(ISorter sorter)
        {
            SorterAlgorithm = sorter;
        }

        public SorterContext(int sorterType)
        {
            SorterAlgorithm = SorterFactory.GetSorter(sorterType);
        }

        public long GetSortTime(int[] array)
        {
            var watch = Stopwatch.StartNew();

            SorterAlgorithm.Sort(array);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
