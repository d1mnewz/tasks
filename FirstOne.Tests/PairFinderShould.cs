using FirstOne.Services;
using FluentAssertions;
using NUnit.Framework;

namespace FirstOne.Tests
{
    public class PairFinderShould
    {
        [Test]
        public void FindPairs()
        {
            var arr = new[] { 1, 3, 4, 4 };
            var sum = 8;
            var sut = new PairFinder();

            var result = sut.FindPair(arr, sum);

            result.Should().NotBeNull();
            result.FirstElementIndex.Should().Be(2);
            result.SecondElementIndex.Should().Be(3);
        }

        [Test]
        public void NotFindPairs()
        {
            var arr = new[] { 1, 3, 4, 9 };
            var sum = 8;
            var sut = new PairFinder();

            var result = sut.FindPair(arr, sum);

            result.Should().BeNull();
        }
    }
}