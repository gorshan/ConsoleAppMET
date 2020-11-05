using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    static public class Cycles
    {
        static public int RaiseToThePower(int a, int b)
        {
            int c = 1;

            for (int i = 0; i < b; i++)
            {
                c *= a;
            }
            return c;
        }


        static public int[] FindNumbersDivisibleByA(int a)
        {
            int[] aa = new int[1000 / a];
            int j = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    aa[j] = i;
                    j++;
                    //Console.WriteLine(i);
                }
            }

            return aa;
        }

        static public int FindNumberOfNumbersWithPower2LessA(int a)
        {
            int s = 0;

            for (int i = 1; i < a; i++)
            {
                if ((i * i) < a)
                {
                    s = s + 1;
                }
            }
            return s;
        }

        static public int FindGreatestDivisorOfA(int a)
        {
            int s = 1;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    s = i;
                }
            }
            return s;
        }

        static public int FindSumOfNumbersDivisibleTo7FromAToB(int a, int b)
        {
            int c;
            int s = 0;

            if (b < a)
            {
                c = a;
                a = b;
                b = c;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    s = s + i;
                }
            }
            return s;
        }

        static public int FindNNumberOfFibonacciSequence(int n)
        {
            int u = 0;
            int u1 = 0;
            int u2 = 1;

            for (int i = 1; i < n; i++)
            {
                u = u1 + u2;
                u1 = u2;
                u2 = u;
            }

            if (n == 1)
            {
                u = 1;
            }
            return u;
        }

        static public int FindGCD(int a, int b)
        { // GCD - greatest common divizor
            int gcd;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            gcd = b;
            return gcd;
        }

        static public int FindCubicRootOfIntegerByBisectionMethod(int a)
        {
            int leftbndry = 0;
            int rightbndry = a;
            int crrnt = 0;

            while (Math.Pow(crrnt, 3) != a)
            {
                crrnt = (leftbndry + rightbndry) / 2;
                if (Math.Pow(crrnt, 3) > a)
                {
                    rightbndry = crrnt;
                }
                else
                {
                    leftbndry = crrnt;
                }
            }
            return crrnt;
        }

        static public int FindNumberOfOddNumerals(int a)
        {
            int numOdd = 0;

            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                {
                    numOdd++;
                }
                a = a / 10;
            }
            return numOdd;
        }

        static public int FindReversNumber(int a)
        {
            int c, d1, aRev;
            d1 = a / 10;
            aRev = a % 10;
            while (d1 != 0)
            {
                c = d1 % 10;
                aRev = 10 * aRev + c;
                d1 = d1 / 10;
            }
            return aRev;
        }

        static public int FindNumberSumOfEvenNumeralGreatestOdds(int n)
        {
            int c = 0;
            int icrrnt;
            for (int i = 1; i <= n; i++)
            {
                int numOdd = 0;
                int numEven = 0;
                icrrnt = i;
                while (icrrnt != 0)
                {
                    if ((icrrnt % 10) % 2 != 0)
                    {
                        numOdd += (icrrnt % 10);
                    }
                    else
                    {
                        numEven += (icrrnt % 10);
                    }
                    icrrnt = icrrnt / 10;

                }
                if (numEven > numOdd)
                {
                    c++;
                }
            }
            return c;
        }

        static public bool ConfirIsThereSameNumerals(int a, int b)
        {
            bool result = false;
            do
            {
                int c = b;
                do
                {
                    if ((a % 10) == (c % 10))
                    {
                        result = true;
                    }
                    else
                    {
                        c /= 10;
                    }
                } while ((result == false) && (c != 0));
                a /= 10;
            } while ((result == false) && (a != 0));

            return result;
        }


    }
}
