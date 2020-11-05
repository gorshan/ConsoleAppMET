using NUnit.Framework;
using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    public class OneDimensionalArraysTests
    {

        [TestCase(new int[5] { 2,6,8,10,95}, 2)]
        [TestCase(new int[2] { 8, 95 }, 8)]
        [TestCase(new int[3] { 18, 10, 95 }, 10)]
        public void FindSmallestElement(int[] a, int expected)
        {
            int actual = OneDimensionalArrays.FindSmallestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 6, 8, 10, 95 }, 95)]
        [TestCase(new int[2] { 8, 95 }, 95)]
        [TestCase(new int[3] { 18, 10, 1 }, 18)]
        public void FindGreatestElement(int[] a, int expected)
        {
            int actual = OneDimensionalArrays.FindGreatestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 6, 8, 10, 95 }, 0)]
        [TestCase(new int[2] { 8, 95 }, 0)]
        [TestCase(new int[3] { 18, 10, 1 }, 2)]
        public void FindIndexOfSmallestElement(int[] a, int expected)
        {
            int actual = OneDimensionalArrays.FindIndexOfSmallestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 6, 8, 10, 95 }, 4)]
        [TestCase(new int[2] { 8, 95 }, 1)]
        [TestCase(new int[3] { 18, 10, 1 }, 0)]
        public void FindIndexOfGreatestElement(int[] a, int expected)
        {
            int actual = OneDimensionalArrays.FindIndexOfGreatestElement(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 6, 8, 10, 95 }, 16)]
        [TestCase(new int[2] { 8, 95 }, 95)]
        [TestCase(new int[3] { 18, 10, 1 }, 10)]
        public void CountSumOddInexedElements(int[] a, int expected)
        {
            int actual = OneDimensionalArrays.CountSumOddInexedElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 6, 8, 10, 95 }, new int[5] { 95, 10, 8, 6, 2})]
        [TestCase(new int[2] { 8, 95 }, new int[2] { 95, 8})]
        [TestCase(new int[3] { 18, 10, 1 }, new int[3] { 1, 10, 18 })]
        public void ReverseArray(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArrays.ReverseArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 21, 6, 8, 11, 95 }, 3)]
        [TestCase(new int[2] { 8, 95 }, 1)]
        [TestCase(new int[3] { 13, 10, 1 }, 2)]
        public void CountNumberOfOddElements(int[] a, int expected)
        {
            int actual = OneDimensionalArrays.CountNumberOfOddElements(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 6, 8, 10, 95 }, new int[5] { 10, 95, 8, 2, 6 })]
        [TestCase(new int[2] { 8, 95 }, new int[2] { 95, 8 })]
        [TestCase(new int[4] { 18, 10, 1, 58}, new int[4] { 1, 58, 18, 10 })]
        public void SwapHalvesOfArray(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArrays.SwapHalvesOfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 22, 6, 18, 10, 95 }, new int[5] { 6, 10, 18, 22, 95 })]
        [TestCase(new int[2] { 81, 9 }, new int[2] { 9, 81 })]
        [TestCase(new int[4] { 18, 10, 1, 58 }, new int[4] { 1, 10, 18, 58 })]
        public void RangeArrayBySelectToBig(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArrays.RangeArrayBySelectToBig(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 22, 6, 18, 10, 95 }, new int[5] { 95, 22, 18, 10, 6 })]
        [TestCase(new int[2] { 8, 9 }, new int[2] { 9, 8 })]
        [TestCase(new int[4] { 18, 10, 1, 58 }, new int[4] { 58, 18, 10, 1 })]
        public void RangeArrayByBubbleToSmall(int[] a, int[] expected)
        {
            int[] actual = OneDimensionalArrays.RangeArrayByBubbleToSmall(a);
            Assert.AreEqual(expected, actual);
        }
    }
}