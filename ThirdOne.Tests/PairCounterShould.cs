using FluentAssertions;
using NUnit.Framework;
using ThirdOne.Impl;

namespace ThirdOne.Tests
{
    [TestFixture]
    public class PairCounterShould
    {
        [TestCase(new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
        [TestCase(new[] { 1, 2, 2, 3, 4, 1, 2, 3, 4 }, 4)]
        public void CountPairs(int[] arr, int expectedResult)
        {
            var sut = new PairCounter();
            var result = sut.CountPairs(arr);

            result.Should().Be(expectedResult);
        }
    }
}