using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using SecondOne.Impl;

namespace SecondOne.Tests
{
    // find intersection between 3 sorted arrays
    // [2,6,7,8]
    // [3,6,8,10]
    // [4,5,6,8]

    [TestFixture]
    public class IntersectionFinderShould
    {
        [TestCase(new[] { 2, 6, 7, 8 }, new[] { 3, 6, 8, 10 }, new[] { 4, 5, 6, 8 }, new[] { 6, 8 })]
        public void FindIntersection(int[] arr1, int[] arr2, int[] arr3, int[] intersection)
        {
            var sut = new IntersectionFinder();

            var result = sut.FindIntersection(arr1, arr2, arr3);
            result.Should().NotBeNull();
            result.Should().HaveSameCount(intersection);
            result.SequenceEqual(intersection).Should().BeTrue();
        }
    }
}