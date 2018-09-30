using FirstOne.Impl.Services;
using FluentAssertions;
using NUnit.Framework;

namespace FirstOne.Tests
{
    // Given an array of sorted integers. Find a pair of elements which gives sum of N.
    // [1, 3, 4, 5] where N = 8 - Yes
    // [1, 3, 4, 9] where N = 8 - No
    
    [TestFixture]
    public class PairFinderShould
    {
        [TestCase(new[] { 1, 3, 4, 5 }, 8, 1, 3)]
        [TestCase(new[] { 1, 2, 4, 6 }, 8, 1, 3)]
        [TestCase(new[] { -2, 6, 10, 11 }, 8, 0, 2)]
        public void FindPairs(int[] arr, int sum, int expectedFirstElement, int expectedSecondElement)
        {
            var sut = new PairFinder();

            var result = sut.FindPair(arr, sum);

            result.Should().NotBeNull();
            result.FirstElementIndex.Should().Be(expectedFirstElement);
            result.SecondElementIndex.Should().Be(expectedSecondElement);
        }

        [TestCase(new[] { 1, 3, 4, 9 }, 8)]
        [TestCase(new[] { 1, 2, 4, 5 }, 8)]
        [TestCase(new[] { 0, 6, 10, 11 }, 8)]
        [TestCase(new int[0], 8)]
        public void NotFindPairs(int[] arr, int sum)
        {
            var sut = new PairFinder();

            var result = sut.FindPair(arr, sum);

            result.Should().BeNull();
        }
    }
}