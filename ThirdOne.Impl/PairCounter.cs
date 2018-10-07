using System.Collections.Generic;

namespace ThirdOne.Impl
{
    // https://www.hackerrank.com/challenges/sock-merchant/problem
    public class PairCounter
    {
        public int CountPairs(int[] arr)
        {
            var result = 0;
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 1);
                else
                {
                    dict[arr[i]]++;
                    if (dict[arr[i]] % 2 == 0)
                        result++;
                }
            }

            return result;
        }
    }
}