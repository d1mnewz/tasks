using FirstOne.Impl.Models;

namespace FirstOne.Impl.Services
{
    public class PairFinderForSpecificSum
    {
        public PairModel FindPair(int[] arr, int sum)
        {
            var start = 0;
            var end = arr.Length - 1;
            while (start != end && end > 0)
            {
                var requiredEndValue = sum - arr[start];
                if (requiredEndValue == arr[end])
                    return new PairModel(start, end);
                if (requiredEndValue < arr[end])
                    end--;
                if (requiredEndValue > arr[end])
                    start++;
            }

            return null;
        }
    }
}