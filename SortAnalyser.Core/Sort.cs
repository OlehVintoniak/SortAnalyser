namespace SortAnalyser.Core
{
    /// <summary>
    /// Singleton used for calling different type of sorting
    /// </summary>
    public class Sort
    {
        private static readonly Sort _instance;
        private Sort() { }
        public static Sort Instance => _instance ?? new Sort();

        #region QuickSort

        public void QuickSort(int[] array, int start, int end)
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
                }
            }
            //put pivot(array[end]) between left and right subArrays
            Swap(array, marker, end);
            return marker;
        }

        #endregion

        #region BubbleSort

        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(array, i, j);
                    }
                }
            }
        }

        #endregion

        #region InsertionSort

        public void InsertionSort(int[] array)
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
            }
        }

        #endregion

        #region SelectionSort

        public void SelectionSort(int[] array)
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
            }
        }

        #endregion

        #region MergeSort


        public void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }

        private void MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);
                Merge(array, low, middle, high);
            }
        }

        private void Merge(int[] array, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (array[left] < array[right])
                {
                    tmp[tmpIndex] = array[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = array[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = array[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = array[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                array[low + i] = tmp[i];
            }
        }

        #endregion

        #region Helpers

        private static void Swap(int[] array, int itemA, int itemB)
        {
            int temp = array[itemA];
            array[itemA] = array[itemB];
            array[itemB] = temp;
        }

        #endregion
    }
}
