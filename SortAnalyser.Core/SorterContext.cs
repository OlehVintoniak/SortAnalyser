using SortAnalyser.Core.Abstract;
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

        public long GetSortTime(int[] array)
        {
            var watch = Stopwatch.StartNew();

            SorterAlgorithm.Sort(array);

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
