using NUnit.Framework;
using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    public class CyclesTests
    {
        [TestCase(1, 3, 1)]
        [TestCase(2, 8, 256)]
        [TestCase(3, 3, 27)]
        public void RaiseToThePower(int a, int b, int expected)
        {
            int actual = Cycles.RaiseToThePower(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, new int[1]{1000})]
        [TestCase(500, new int[2] {500, 1000 })]
        [TestCase(200, new int[5] {200, 400, 600, 800, 1000 })]
        public void FindNumbersDivisibleByA(int a, int[] expected)
        {
            int[] actual = Cycles.FindNumbersDivisibleByA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3)]
        [TestCase(20, 4)]
        [TestCase(100, 9)]
        public void FindNumberOfNumbersWithPower2LessA(int a, int expected)
        {
            int actual = Cycles.FindNumberOfNumbersWithPower2LessA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5)]
        [TestCase(50, 25)]
        [TestCase(99, 33)]
        public void FindGreatestDivisorOfA(int a, int expected)
        {
            int actual = Cycles.FindGreatestDivisorOfA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 18, 21)]
        [TestCase(0, 21, 42)]
        [TestCase(50, 30, 126)]
        public void FindSumOfNumbersDivisibleTo7FromAToB(int a, int b, int expected)
        {
            int actual = Cycles.FindSumOfNumbersDivisibleTo7FromAToB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(15, 610)]
        public void FindNNumberOfFibonacciSequence(int n, int expected)
        {
            int actual = Cycles.FindNNumberOfFibonacciSequence(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 15, 5)]
        [TestCase(21, 47, 1)]
        [TestCase(54, 114, 6)]
        public void FindGCD(int a, int b, int expected)
        {
            int actual = Cycles.FindGCD(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(3375, 15)]
        public void FindCubicRootOfIntegerByBisectionMethod(int a, int expected)
        {
            int actual = Cycles.FindCubicRootOfIntegerByBisectionMethod(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 2)]
        [TestCase(48, 0)]
        [TestCase(1583, 3)]
        public void FindNumberOfOddNumerals(int a, int expected)
        {
            int actual = Cycles.FindNumberOfOddNumerals(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(153, 351)]
        [TestCase(10, 1)]
        [TestCase(8, 8)]
        public void FindReversNumber(int a, int expected)
        {
            int actual = Cycles.FindReversNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 12)]
        [TestCase(9, 4)]
        [TestCase(2, 1)]
        public void FindNumberSumOfEvenNumeralGreatestOdds(int n, int expected)
        {
            int actual = Cycles.FindNumberSumOfEvenNumeralGreatestOdds(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 51, true)]
        [TestCase(55, 2, false)]
        [TestCase(12, 1532, true)]
        [TestCase(1220, 30, true)]
        public void ConfirIsThereSameNumerals(int a, int b, bool expected)
        {
            bool actual = Cycles.ConfirIsThereSameNumerals(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
    

   
}