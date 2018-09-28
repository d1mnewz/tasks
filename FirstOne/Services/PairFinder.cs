using FirstOne.Models;

namespace FirstOne.Services
{
    public class PairFinder
    {
        public PairModel FindPair(int[] arr, int sum)
        {
            var start = 0;
            var end = arr.Length - 1;
            while (start != end)
            {
                var requiredEndValue = sum - arr[start];
                if (requiredEndValue < arr[end])
                    end--;
                if (requiredEndValue > arr[end])
                    start++;
                if (requiredEndValue == arr[end])
                    return new PairModel(start, end);
            }

            return null;
        }
    }
}