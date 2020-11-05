using NUnit.Framework;
using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    public class IfElseTests
    {

        [TestCase(16, 5, 21)]
        [TestCase(8, 0, 8)]
        [TestCase(10, 24, -14)]
        [TestCase(16, 31, -15)]
        [TestCase(10, 10, 100)]
        [TestCase(2, 2, 4)]
        public void DoSomeMath(int a, int b, int expected)
        {
            int actual = IfElse.DoSomeMath(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 12, "I четверть")]
        [TestCase(4, 160, "I четверть")]
        [TestCase(-3, 1, "II четверть")]
        [TestCase(-10, 112, "II четверть")]
        [TestCase(5, -12, "IV четверть")]
        [TestCase(15, -1, "IV четверть")]
        [TestCase(-5, -12, "III четверть")]
        [TestCase(-17, -8, "III четверть")]
        [TestCase(0, 12, "на оси")]
        [TestCase(-5, 0, "на оси")]
        public void FindQuarter(int x, int y, string expected)
        {
            string actual = IfElse.FindQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, 7, new int[3] { 3, 5, 7})]
        [TestCase(8, 5, 7, new int[3] { 5, 7, 8 })]
        [TestCase(3, 5, 1, new int[3] { 1, 3, 5 })]
        [TestCase(3, 0, 7, new int[3] { 0, 3, 7 })]
        [TestCase(3, 5, 3, new int[3] { 3, 3, 5 })]
        [TestCase(7, 5, 7, new int[3] { 5, 7, 7 })]
        public void Sort3ToBig(int a, int b, int c, int[] expected)
        {
            int[] actual = IfElse.Sort3ToBig(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -9, 0, new double[2] { 9, 0})]
        [TestCase(1, 4, -5, new double[2] { 1, -5 })]
        [TestCase(-4, 28, -49, new double[1] { 3.5 })]
        [TestCase(5, 6, 2, new double[0] { })]
        [TestCase(1, -4, 4, new double[1] { 2})]
        public void SolveQuadraticEquation(double a, double b, double c, double[] expected)
        {
            double[] actual = IfElse.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, -4)]
        [TestCase(0, -1, 8)]
        [TestCase(0, 5, 0)]
        public void SolveQuadraticEquatioNegative(double a, double b, double c)
        {
            try
            {
                IfElse.SolveQuadraticEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(25, "двадцать пять")]
        [TestCase(41, "сорок один")]
        [TestCase(12, "двенадцать")]
        public void ConvertTwoDigitNumberToString(int a, string expected)
        {
            string actual = IfElse.ConvertTwoDigitNumberToString(a);
            Assert.AreEqual(expected, actual);
        }




    }

    
}