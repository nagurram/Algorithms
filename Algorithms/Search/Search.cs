namespace Algorithms.Search
{
    public class Search
    {
        public int BinarySearch(int[] intarr, int searchnum)
        {
            int result = 0;
            int mid = 0;
            int low = 0;
            int high = intarr.Length;
            while (low <= high)
            {
                mid = low + ((high - low) / 2);
                if (intarr[mid] == searchnum)
                {
                    return searchnum;
                }
                else
                {
                    if (intarr[mid] < searchnum)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return result;
        }
    }
}
