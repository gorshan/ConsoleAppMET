using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    static public class TwoDimensionalArray
    {
        static public int[,] CreateRandomArrayMxNTo100(int m, int n)
        {
            int[,] a = new int[4, 5];
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(10);
                }
            }
            return a;
        }

        static public int[,] CopyArray(int[,] a)
        {
            int[,] aCopy = new int[a.GetLength(0), a.GetLength(1)];
            Array.Copy(a, aCopy, a.Length);
            return aCopy;
        }


        static public int FindSmallestElement(int[,] a)
        {
            int min = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            return min;
        }

        static public int FindGreatestElement(int[,] a)
        {
            int max = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }

        static public int[] FindIndexesOfSmallestElement(int[,] a)
        {
            int min = a[0, 0];
            int IDi = 0;
            int IDj = 0;
            for (int i = 1; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        IDi = i;
                        IDj = j;
                    }
                }
            }
            int[] Indexes;
            Indexes = new int[2] { IDi, IDj };

            return Indexes;
        }

        static public int[] FindIndexesOfGreatestElement(int[,] a)
        {
            int max = a[0, 0];
            int IDi = 0;
            int IDj = 0;
            for (int i = 1; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        IDi = i;
                        IDj = j;
                    }
                }
            }
            int[] Indexes;
            Indexes = new int[2] { IDi, IDj };

            return Indexes;
        }

        static public int CountElementsGreaterThenNeighbors(int[,] a)
        {
            int s = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (((i - 1 < 0) || (a[i, j] > a[i - 1, j]))
                        && ((j - 1 < 0) || (a[i, j] > a[i, j - 1]))
                        && ((j + 1 > a.GetLength(1) - 1) || (a[i, j] > a[i, j + 1]))
                        && ((i + 1 > a.GetLength(0) - 1) || (a[i, j] > a[i + 1, j])))
                    {
                        Console.WriteLine(a[i, j]);
                        s = s + 1;
                    }
                }
            }
            return s;
        }

        static public int[,] TransposeArray(int[,] ar)
        {
            int[,] a = CopyArray(ar);

            int[,] b = new int[a.GetLength(1), a.GetLength(0)];

            Array.Copy(a, b, a.Length);

            Console.WriteLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j, i] = a[i, j];
                }
            }

            return b;

        }



    }
}
