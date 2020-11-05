using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    static public class OneDimensionalArrays

    {
        static public int[] CreateRandomArrayTo100(int n)
        {
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(100);
            }
            return a;
        }

        static public int[] CopyArray(int[] a)
        {
            int[] aCopy = new int[a.Length];
            Array.Copy(a, aCopy, a.Length);
            return aCopy;
        }


        static public int FindSmallestElement(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        static public int FindGreatestElement(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static public int FindIndexOfSmallestElement(int[] a)
        {
            int min = a[0];
            int IDmin = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    IDmin = i;
                }
            }
            return IDmin;
        }

        static public int FindIndexOfGreatestElement(int[] a)
        {
            int max = a[0];
            int IDmax = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    IDmax = i;
                }
            }
            return IDmax;
        }

        static public int CountSumOddInexedElements(int[] a)
        {
            int sum = 0;
            for (int i = 1; i < a.Length; i += 2)
            {
                sum = sum + a[i];
            }
            return sum;
        }

        static public int[] ReverseArray(int[] a)
        {
            int[] aRev = CopyArray(a);

            int c = 0;

            for (int i = 0; i < aRev.Length / 2; i++)
            {
                c = aRev[i];
                aRev[i] = aRev[aRev.Length - 1 - i];
                aRev[aRev.Length - 1 - i] = c;
            }

            return aRev;
        }

        static public int CountNumberOfOddElements(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    s = s + 1;
                }
            }
            return s;
        }

        static public int[] SwapHalvesOfArray(int[] b)
        {
            int[] a = CopyArray(b);

            int c = 0;
            for (int i = 0; i < a.Length / 2; i++)
            {
                c = a[i];
                a[i] = a[(a.Length + 1) / 2 + i];
                a[(a.Length + 1) / 2 + i] = c;
            }
            return a;
        }

        static public int[] RangeArrayBySelectToBig(int[] b)
        {
            int[] a = CopyArray(b);

            int temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

        static public int[] RangeArrayByBubbleToSmall(int[] b)
        {
            int[] a = CopyArray(b);

            for (int i = 0; i < a.Length - 1; i++)
            {
                int maxi = i;

                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] > a[maxi])
                    {
                        maxi = j;
                    }
                }
                int c = a[i];
                a[i] = a[maxi];
                a[maxi] = c;
            }
            return a;

        }

    }
}
