using FluentAssertions;
using FourthOne.Impl;
using NUnit.Framework;

namespace FourthOne.Tests
{
    [TestFixture]
    public class ElementFinderShould
    {
        [TestCase(new[] { 4, 5, 1, 2, 3 }, 2, 3)]
        [TestCase(new[] { 0, 1, 2, 3, 4 }, 2, 2)]
        [TestCase(new[] { 5, 0, 1, 2, 3 }, 5, 0)]
        public void FindElements(int[] rotatedArray, int elementToFind, int expectedPosition)
        {
            var sut = new ElementFinder();

            var result = sut.FindIndexOfElementInRotatedArray(rotatedArray, elementToFind);

            result.Should().Be(expectedPosition);
        }
    }
}