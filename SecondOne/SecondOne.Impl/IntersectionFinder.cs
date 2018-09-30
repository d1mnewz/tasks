using System.Collections.Generic;

namespace SecondOne.Impl
{
    public class IntersectionFinder
    {
        public IEnumerable<int> FindIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            var list = new List<int>();
            int iterator1 = 0, iterator2 = 0, iterator3 = 0;

            while (!OutOfBounds(arr1, arr2, arr3, iterator1, iterator2, iterator3))
            {
                if (arr1[iterator1] == arr2[iterator2] && arr2[iterator2] == arr3[iterator3])
                {
                    list.Add(arr1[iterator1]);
                    iterator1++;
                    iterator2++;
                    iterator3++;
                }
                else if (arr1[iterator1] < arr2[iterator2])
                {
                    iterator1++;
                }
                else if (arr2[iterator2] < arr3[iterator3])
                {
                    iterator2++;
                }
                else
                {
                    iterator3++;
                }
            }

            return list;
        }

        private bool OutOfBounds(int[] arr1, int[] arr2, int[] arr3, int iterator1, int iterator2, int iterator3)
        {
            return arr1.Length <= iterator1 || arr2.Length <= iterator2 || arr3.Length <= iterator3;
        }
    }
}