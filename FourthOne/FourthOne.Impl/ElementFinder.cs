using System;
using System.Linq;

namespace FourthOne.Impl
{
    // Find an element in a rotated sorted array
    public class ElementFinder
    {
        public int FindIndexOfElementInRotatedArray(int[] rotatedArray, int elementToFind)
        {
            var smallestLeft = rotatedArray[0];
            var iterator = 0;
            while (!OOB(rotatedArray, iterator) && smallestLeft <= rotatedArray[iterator])
            {
                if (rotatedArray[iterator] == elementToFind)
                {
                    return iterator;
                }

                iterator++;
            }

            if (elementToFind > smallestLeft)
            {
                var arrForBs = rotatedArray.Take(iterator).ToArray();
                return BinarySearch(arrForBs, elementToFind);
            }
            else
            {
                var arrForBs = rotatedArray.TakeLast(rotatedArray.Length - iterator).ToArray();
                return BinarySearch(arrForBs, elementToFind) + iterator;
            }
        }

        private int BinarySearch(int[] arr, int elementToFind)
        {
            var start = 0;
            var end = arr.Length - 1;
            while (start < end)
            {
                var middleIndex = (start + end) / 2;
                var middleElement = arr[middleIndex];

                if (middleElement == elementToFind)
                {
                    return middleIndex;
                }

                if (middleElement > elementToFind)
                {
                    end = middleIndex + 1;
                }
                else if (middleElement < elementToFind)
                {
                    start = middleIndex - 1;
                }
            }

            throw new Exception();
        }

        private bool OOB(int[] rotatedArray, int iterator)
        {
            return rotatedArray.Length - 1 < iterator;
        }
    }
}