using NUnit.Framework;
using ClassLibrary1;

namespace ClassLibrary1.Tests
{
    public class TwoDimensionalArrayTests
    {
        int[,] aMock;
        int[,] expectedMock;

        [TestCase(1, 2)]
        [TestCase(2, 0)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        public void FindSmallestElement(int a, int expected)
        {
            GetAMock(a);

            int actual = TwoDimensionalArray.FindSmallestElement(aMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 8)]
        [TestCase(3, 9)]
        [TestCase(4, 9)]
        public void FindGreatestElement(int a, int expected)
        {
            GetAMock(a);

            int actual = TwoDimensionalArray.FindGreatestElement(aMock);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, new int[2] {2, 1})]
        [TestCase(2, new int[2] { 0, 0 })]
        [TestCase(3, new int[2] { 1, 1 })]
        [TestCase(4, new int[2] { 0, 0 })]
        public void FindIndexesOfSmallestElement(int a, int[] expected)
        {
            GetAMock(a);

            int[] actual = TwoDimensionalArray.FindIndexesOfSmallestElement(aMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 1, 0 })]
        [TestCase(2, new int[2] { 2, 2 })]
        [TestCase(3, new int[2] { 2, 2 })]
        [TestCase(4, new int[2] { 1, 2 })]
        public void FindIndexesOfGreatestElement(int a, int[] expected)
        {
            GetAMock(a);

            int[] actual = TwoDimensionalArray.FindIndexesOfGreatestElement(aMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3)]
        [TestCase(2, 1)]
        [TestCase(3, 3)]
        [TestCase(4, 3)]
        public void CountElementsGreaterThenNeighbors(int a, int expected)
        {
            GetAMock(a);

            int actual = TwoDimensionalArray.CountElementsGreaterThenNeighbors(aMock);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void TransposeArray(int a, int e)
        {
            GetAMock(a);
            GetExpectedMock(e);

            int[,] expected = expectedMock;
            int[,] actual = TwoDimensionalArray.TransposeArray(aMock);
            Assert.AreEqual(expected, actual);
        }

        void GetAMock(int n)
        {
            switch (n)
            {
                case 1:
                    aMock = new int[,]
                    {
                        {5, 9, 4 },
                        {8, 4, 8 },
                        {4, 2, 7 }
                    };
                    break;
                case 2:
                    aMock = new int[,]
                    {
                        {0, 1, 2 },
                        {3, 4, 5 },
                        {6, 7, 8 }
                    };
                    break;
                case 3:
                    aMock = new int[,]
                    {
                        {8, 5, 6, 5 },
                        {4, 1, 5, 1 },
                        {2, 3, 9 , 8}
                    };
                    break;
                case 4:
                    aMock = new int[,]
                    {
                        {1, 5, 4 },
                        {8, 5, 9 },
                        {4, 2, 7 },
                        {3, 6 ,1 }
                    };
                    break;
            }
        }

        void GetExpectedMock(int n)
        {
            switch (n)
            {
                case 2:
                    expectedMock = new int[,]
                    {
                        {0, 3, 6 },
                        {1, 4, 7 },
                        {2, 5, 8 }
                    };
                    break;
                case 3:
                    expectedMock = new int[,]
                    {
                        {8, 4, 2 },
                        {5, 1, 3 },
                        {6, 5, 9 },
                        {5, 1, 8 }
                    };
                    break;
                case 4:
                    expectedMock = new int[,]
                    {
                        {1, 8, 4, 3 },
                        {5, 5, 2, 6 },
                        {4, 9, 7, 1 },
                    };
                    break;
            }
        }



    }
}