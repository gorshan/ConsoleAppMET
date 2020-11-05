using NUnit.Framework;
using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(1, 3, 7)]
        [TestCase(2, 5, 11)]
        [TestCase(4, -5, -5)]
        [TestCase(15, 0, -5)]
        public void DoSomeMath(int a, int b, int expected)
        {
            int actual = Variables.DoSomeMath(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(18, 18)]
        public void DoSomeMathNegative(int a, int b)
        {
            try
            {
                Variables.DoSomeMath(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, new int[2] { 2, 1 })]
        [TestCase(-5, 18, new int[2] { 18, -5 })]
        [TestCase(0, 512, new int[2] { 512, 0 })]
        public void SwitchVariables(int a, int b, int[] expected)
        {
            int[] actual = Variables.SwitchVariables(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 3, new int[2] { 0, 0 })]
        [TestCase(5, 1, new int[2] { 5, 0 })]
        [TestCase(13, 6, new int[2] { 2, 1 })]
        public void DoSomeAnotherMath(int a, int b, int[] expected)
        {
            int[] actual = Variables.DoSomeAnotherMath(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 11, 3)]
        [TestCase(10, -10, 13, 2.3)]
        [TestCase(5, 0, 5, 1)]
        [TestCase(25, -4, 0, 0.16)]
        public void DoLinearEquation(double a, double b, double c, double expected)     
        {
            double actual = Variables.DoLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 4, 7, "y=1x+3")]
        [TestCase(5, 8, 3, 7, "y=0,5x+5,5")]
        [TestCase(41, 5, 25, 14, "y=-0,5625x+28,0625")]
        public void FindEquationOfTwoPoints(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = Variables.FindEquationOfTwoPoints(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

    }
}