using SortAnalyser.Core.Abstract;
using System;

namespace SortAnalyser.Core.Factory
{
    public static class SorterFactory
    {
        public static ISorter GetSorter(int input)
        {
            switch (input)
            {
                case 1: return new BubleSorter();
                case 2: return new InsertionSorter();
                case 3: return new SelectionSorter();
                case 4: return new QuickSorter();
                case 5: return new MergeSorter();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
