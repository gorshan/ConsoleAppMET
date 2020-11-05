using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    static public class Variables
    {
        static public int DoSomeMath(int a, int b)
        {
            if (a == b)
            {
                throw new Exception("Parameter a and b can't be equal");
            }  
            int c;
            c = (5 * a + b * b) / (b - a);
            return c;
        }

        static public int[] SwitchVariables(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;

            int[] ar = new int[] { a, b };

            return ar;
        }

        static public int[] DoSomeAnotherMath(int a, int b)
        {
            int del;
            int rest;
            del = a / b;
            rest = a % b;
            int[] ar = new int[] { del, rest };
            return ar;
        }

        static public double DoLinearEquation(double a, double b, double c = 0)
        {
            double x;
            x = (c - b) / a;
            return x;
        }
        static public string FindEquationOfTwoPoints(double x1, double y1, double x2, double y2)
        {
            double a, b;
            a = (y1 - y2) / (x1 - x2);
            b = y2 - a * x2;
            string Eq;
            Eq = "y=" + a + "x+" + b;
            return Eq;
        }
    }

    //static public class IfElse
    //{
    //    static public int DoSomeMath(int a, int b)
    //    {
    //        int c;
    //        if (a > b)
    //        {
    //            c = a + b;
    //        }
    //        else if (a < b)
    //        {
    //            c = a - b;
    //        }
    //        else c = a * b;
    //        return c;
    //    }

    //    static public string FindQuarter(int x, int y)
    //    {
    //        string Quarter;
    //        if ((x > 0) && (y > 0))
    //            Quarter = "I четверть";
    //        else if ((x < 0) && (y > 0))
    //            Quarter = "II четверть";
    //        else if ((x < 0) && (y < 0))
    //            Quarter = "III четверть";
    //        else if ((x > 0) && (y < 0))
    //            Quarter = "IV четверть";
    //        else
    //            Quarter = "на оси";
    //        return Quarter;

    //    }

    //    static public int[] Sort3ToBig(int a, int b, int c)
    //    {
    //        int[] Sor;
    //        if (a < b && a < c)
    //        {
    //            if (b < c)
    //                Sor = new int[3] { a, b, c };
    //            else
    //                Sor = new int[3] { a, c, b };
    //        }
    //        else if (b < a && b < c)
    //        {
    //            if (a < c)
    //                Sor = new int[3] { b, a, c };
    //            else
    //                Sor = new int[3] { b, c, a };
    //        }
    //        else if (a < b)
    //            Sor = new int[3] { c, a, b };
    //        else
    //            Sor = new int[3] { c, b, a };

    //        return Sor;
    //    }

    //    static public double[] SolveQuadraticEquation(int a, int b, int c)
    //    {
    //        double d;
    //        double x, x1, x2;
    //        double[] Root;

    //        d = b * b - 4 * a * c;
    //        if (d < 0)
    //            Root = new double[0];
    //        else if (d == 0)
    //        {
    //            x = (-1 * b) / (2 * a);
    //            Root = new double[1] { x };
    //        }
    //        else
    //        {
    //            x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
    //            x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
    //            Root = new double[2] { x1, x2 };
    //        }
    //        return Root;
    //    }

    //    static public string ConvertTwoDigitNumberToString(int a)
    //    {
    //        if (a > 99 || a < 10)
    //        {
    //            throw new Exception("Not a two-digit number!");
    //        }

    //        if (a == 10)
    //        {
    //            Console.WriteLine("десять");
    //        }
    //        string x;
    //        string y;
    //        string aString;
    //        int d;
    //        int c;
    //        x = "";
    //        y = "";
    //        d = a / 10;
    //        c = a % 10;

    //        if (d == 1)
    //        {
    //            y = "надцать";
    //            switch (c)
    //            {
    //                case 1:
    //                    x = "один";
    //                    break;
    //                case 2:
    //                    x = "две";
    //                    break;
    //                case 3:
    //                    x = "три";
    //                    break;
    //                case 4:
    //                    x = "четыр";
    //                    break;
    //                case 5:
    //                    x = "пят";
    //                    break;
    //                case 6:
    //                    x = "шест";
    //                    break;
    //                case 7:
    //                    x = "сем";
    //                    break;
    //                case 8:
    //                    x = "восемь";
    //                    break;
    //                case 9:
    //                    x = "девят";
    //                    break;

    //            }
    //            c = -1;

    //        }

    //        switch (d)
    //        {
    //            case 2:
    //                x = "двадцать ";
    //                break;
    //            case 3:
    //                x = "тридцать ";
    //                break;
    //            case 4:
    //                x = "сорок ";
    //                break;
    //            case 5:
    //                x = "пятьдесят ";
    //                break;
    //            case 6:
    //                x = "шестьдесять ";
    //                break;
    //            case 7:
    //                x = "семьдесят ";
    //                break;
    //            case 8:
    //                x = "восемдесят ";
    //                break;
    //            case 9:
    //                x = "девяносто ";
    //                break;
    //        }

    //        switch (c)
    //        {
    //            case 0:
    //                y = "";
    //                break;
    //            case 1:
    //                y = "один";
    //                break;
    //            case 2:
    //                y = "два";
    //                break;
    //            case 3:
    //                y = "три";
    //                break;
    //            case 4:
    //                y = "четыре";
    //                break;
    //            case 5:
    //                y = "пять";
    //                break;
    //            case 6:
    //                y = "шесть";
    //                break;
    //            case 7:
    //                y = "семь";
    //                break;
    //            case 8:
    //                y = "восемь";
    //                break;
    //            case 9:
    //                y = "девять";
    //                break;

    //        }


    //        //Console.WriteLine(x + y);
    //        aString = x + y;
    //        return aString;
    //    }

    //}

    //static public class Cycles
    //{
    //    static public int RaiseToThePower(int a, int b)
    //    {
    //        int c = 1;

    //        for (int i = 0; i < b; i++)
    //        {
    //            c *= a;
    //        }
    //        return c;
    //    }


    //    static public int[] FindNumbersDivisibleByA(int a)
    //    {
    //        int[] aa = new int[1000 / a];
    //        int j = 0;
    //        for (int i = 1; i <= 1000; i++)
    //        {
    //            if (i % a == 0)
    //            {
    //                aa[j] = i;
    //                j++;
    //                //Console.WriteLine(i);
    //            }
    //        }

    //        return aa;
    //    }

    //    static public int FindNumberOfNumbersWithPower2LessA(int a)
    //    {
    //        int s = 0;

    //        for (int i = 1; i < a; i++)
    //        {
    //            if ((i * i) < a)
    //            {
    //                s = s + 1;
    //            }
    //        }
    //        return s;
    //    }

    //    static public int FindGreatestDivisorOfA(int a)
    //    {
    //        int s = 1;

    //        for (int i = 1; i < a; i++)
    //        {
    //            if (a % i == 0)
    //            {
    //                s = i;
    //            }
    //        }
    //        return s;
    //    }

    //    static public int FindSumOfNumbersDivisibleTo7FromAToB(int a, int b)
    //    {
    //        int c;
    //        int s = 0;

    //        if (b < a)
    //        {
    //            c = a;
    //            a = b;
    //            b = c;
    //        }

    //        for (int i = a; i <= b; i++)
    //        {
    //            if (i % 7 == 0)
    //            {
    //                s = s + i;
    //            }
    //        }
    //        return s;
    //    }

    //    static public int FindNNumberOfFibonacciSequence(int n)
    //    {
    //        int u = 0;
    //        int u1 = 0;
    //        int u2 = 1;

    //        for (int i = 1; i < n; i++)
    //        {
    //            u = u1 + u2;
    //            u1 = u2;
    //            u2 = u;
    //        }

    //        if (n == 1)
    //        {
    //            u = 1;
    //        }
    //        return u;
    //    }

    //    static public int FindGCD(int a, int b)
    //    { // GCD - greatest common divizor
    //        int gcd;

    //        while (a != b)
    //        {
    //            if (a > b)
    //            {
    //                a = a - b;
    //            }
    //            else
    //            {
    //                b = b - a;
    //            }
    //        }

    //        gcd = b;
    //        return gcd;
    //    }

    //    static public int FindCubicRootOfIntegerByBisectionMethod(int a)
    //    {
    //        int leftbndry = 0;
    //        int rightbndry = a;
    //        int crrnt = 0;

    //        while (Math.Pow(crrnt, 3) != a)
    //        {
    //            crrnt = (leftbndry + rightbndry) / 2;
    //            if (Math.Pow(crrnt, 3) > a)
    //            {
    //                rightbndry = crrnt;
    //            }
    //            else
    //            {
    //                leftbndry = crrnt;
    //            }
    //        }
    //        return crrnt;
    //    }

    //    static public int FindNumberOfOddNumerals(int a)
    //    {
    //        int numOdd = 0;

    //        while (a != 0)
    //        {
    //            if ((a % 10) % 2 != 0)
    //            {
    //                numOdd++;
    //            }
    //            a = a / 10;
    //        }
    //        return numOdd;
    //    }

    //    static public int FindReversNumber(int a)
    //    {
    //        int c, d1, aRev;
    //        d1 = a / 10;
    //        aRev = a % 10;
    //        while (d1 != 0)
    //        {
    //            c = d1 % 10;
    //            aRev = 10 * aRev + c;
    //            d1 = d1 / 10;
    //        }
    //        return aRev;
    //    }

    //    static public int FindNumberSumOfEvenNumeralGreatestOdds(int n)
    //    {
    //        int c = 0;
    //        int icrrnt;
    //        for (int i = 1; i <= n; i++)
    //        {
    //            int numOdd = 0;
    //            int numEven = 0;
    //            icrrnt = i;
    //            while (icrrnt != 0)
    //            {
    //                if ((icrrnt % 10) % 2 != 0)
    //                {
    //                    numOdd += (icrrnt % 10);
    //                }
    //                else
    //                {
    //                    numEven += (icrrnt % 10);
    //                }
    //                icrrnt = icrrnt / 10;

    //            }
    //            if (numEven > numOdd)
    //            {
    //                c++;
    //            }
    //        }
    //        return c;
    //    }

    //    static public bool ConfirIsThereSameNumerals(int a, int b)
    //    {
    //        bool result = false;
    //        do
    //        {
    //            int c = b;
    //            do
    //            {
    //                if ((a % 10) == (c % 10))
    //                {
    //                    result = true;
    //                }
    //                else
    //                {
    //                    c /= 10;
    //                }
    //            } while ((result == false) && (c != 0));
    //            a /= 10;
    //        } while ((result == false) && (a != 0));

    //        return result;
    //    }


    //}

    //static public class OneDimensionalArrays

    //{
    //    static public int[] CreateRandomArrayTo100(int n)
    //    {
    //        int[] a = new int[n];
    //        Random r = new Random();
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            a[i] = r.Next(100);
    //        }
    //        return a;
    //    }

    //    static public int[] CopyArray(int[] a)
    //    {
    //        int[] aCopy = new int[a.Length];
    //        Array.Copy(a, aCopy, a.Length);
    //        return aCopy;
    //    }


    //    static public int FindSmallestElement(int[] a)
    //        {
    //        int min = a[0];

    //        for (int i = 1; i < a.Length; i++)
    //        {
    //            if (a[i] < min)
    //            {
    //                min = a[i];
    //            }
    //        }
    //            return min;
    //        }

    //    static public int FindGreatestElement(int[] a)
    //    {
    //        int max = a[0];

    //        for (int i = 1; i < a.Length; i++)
    //        {
    //            if (a[i] > max)
    //            {
    //                max = a[i];
    //            }
    //        }
    //        return max;
    //    }

    //    static public int FindIndexOfSmallestElement(int[] a)
    //    {
    //        int min = a[0];
    //        int IDmin = 0;
    //        for (int i = 1; i < a.Length; i++)
    //        {
    //            if (a[i] < min)
    //            {
    //                min = a[i];
    //                IDmin = i;
    //            }
    //        }
    //        return IDmin;
    //    }

    //    static public int FindIndexOfGreatestElement(int[] a)
    //    {
    //        int max = a[0];
    //        int IDmax = 0;
    //        for (int i = 1; i < a.Length; i++)
    //        {
    //            if (a[i] > max)
    //            {
    //                max = a[i];
    //                IDmax = i;
    //            }
    //        }
    //        return IDmax;
    //    }

    //    static public int CountSumOddInexedElements(int[] a)
    //    {
    //        int sum = 0;
    //        for (int i = 1; i < a.Length; i += 2)
    //        {
    //            sum = sum + a[i];
    //        }
    //        return sum;
    //    }

    //    static public int[] ReverseArray(int[] a)
    //    {
    //        int[] aRev = CopyArray(a);

    //        int c = 0;

    //        for (int i = 0; i < aRev.Length / 2; i++)
    //        {
    //            c = aRev[i];
    //            aRev[i] = aRev[aRev.Length - 1 - i];
    //            aRev[aRev.Length - 1 - i] = c;
    //        }

    //        return aRev;
    //    }

    //    static public int CountNumberOfOddElements(int[] a)
    //    {
    //        int s = 0;
    //        for (int i = 0; i < a.Length; i++)
    //        {
    //            if (a[i] % 2 != 0)
    //            {
    //                s = s + 1;
    //            }
    //        }
    //        return s;
    //    }

    //    static public int[] SwapHalvesOfArray(int[] b)
    //    {
    //        int[] a = CopyArray(b);

    //        int c = 0;
    //        for (int i = 0; i < a.Length / 2; i++)
    //        {
    //            c = a[i];
    //            a[i] = a[(a.Length + 1) / 2 + i];
    //            a[(a.Length + 1) / 2 + i] = c;
    //        }
    //        return a;
    //    }

    //    static public int[] RangeArrayBySelect(int[] b)
    //    {
    //        int[] a = CopyArray(b);

    //        int temp;
    //        for (int i = 0; i < a.Length - 1; i++)
    //        {
    //            for (int j = 0; j < a.Length - 1 - i; j++)
    //            {
    //                if (a[j] > a[j + 1])
    //                {
    //                    temp = a[j];
    //                    a[j] = a[j + 1];
    //                    a[j + 1] = temp;
    //                }
    //            }
    //        }
    //        return a;
    //    }

    //    static public int[] RangeArrayByBubble(int[] b)
    //    {
    //        int[] a = CopyArray(b);

    //        for (int i = 0; i < a.Length - 1; i++)
    //        {
    //            int maxi = i;

    //            for (int j = i; j < a.Length; j++)
    //            {
    //                if (a[j] > a[maxi])
    //                {
    //                    maxi = j;
    //                }
    //            }
    //            int c = a[i];
    //            a[i] = a[maxi];
    //            a[maxi] = c;
    //        }
    //        return a;

    //    }

    //}

    //static public class TwoDimensionalArray
    //{
    //    static public int[,] CreateRandomArrayMxNTo100(int m, int n)
    //    {
    //        int[,] a = new int[4, 5];
    //        Random r = new Random();
    //        for (int i = 0; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                a[i, j] = r.Next(10);
    //            }
    //        }
    //        return a;
    //    }

    //    static public int[,] CopyArray(int[,] a)
    //    {
    //        int[,] aCopy = new int[a.GetLength(0), a.GetLength(1)];
    //        Array.Copy(a, aCopy, a.Length);
    //        return aCopy;
    //    }


    //    static public int FindSmallestElement(int[,] a)
    //    {
    //        int min = a[0, 0];

    //        for (int i = 1; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                if (a[i, j] < min)
    //                {
    //                    min = a[i, j];
    //                }
    //            }
    //        }
    //        return min;
    //    }

    //    static public int FindGreatestElement(int[,] a)
    //    {
    //        int max = a[0, 0];

    //        for (int i = 1; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                if (a[i, j] > max)
    //                {
    //                    max = a[i, j];
    //                }
    //            }
    //        }
    //        return max;
    //    }

    //    static public int[] FindIndexesOfSmallestElement(int[,] a)
    //    {
    //        int min = a[0, 0];
    //        int IDi = 0;
    //        int IDj = 0;
    //        for (int i = 1; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                if (a[i, j] < min)
    //                {
    //                    min = a[i, j];
    //                    IDi = i;
    //                    IDj = j;
    //                }
    //            }
    //        }
    //        int[] Indexes;
    //        Indexes = new int[2] { IDi, IDj };

    //        return Indexes;
    //    }

    //    static public int[] FindIndexesOfGreatestElement(int[,] a)
    //    {
    //        int max = a[0, 0];
    //        int IDi = 0;
    //        int IDj = 0;
    //        for (int i = 1; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                if (a[i, j] > max)
    //                {
    //                    max = a[i, j];
    //                    IDi = i;
    //                    IDj = j;
    //                }
    //            }
    //        }
    //        int[] Indexes;
    //        Indexes = new int[2] { IDi, IDj };

    //        return Indexes;
    //    }

    //    static public int CountElementsGreaterThenNeighbors(int[,] a)
    //    {
    //        int s = 0;

    //        for (int i = 0; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                if (((i - 1 < 0) || (a[i, j] > a[i - 1, j]))
    //                    && ((j - 1 < 0) || (a[i, j] > a[i, j - 1]))
    //                    && ((j + 1 > a.GetLength(1) - 1) || (a[i, j] > a[i, j + 1]))
    //                    && ((i + 1 > a.GetLength(0) - 1) || (a[i, j] > a[i + 1, j])))
    //                {
    //                    Console.WriteLine(a[i, j]);
    //                    s = s + 1;
    //                }
    //            }
    //        }
    //        return s;
    //    }

    //    static public int[,] TransposeArray(int[,] ar)
    //    {
    //        int[,] a = CopyArray(ar);

    //        int[,] b = new int[a.GetLength(1), a.GetLength(0)];

    //        Array.Copy(a, b, a.Length);

    //        Console.WriteLine();
    //        for (int i = 0; i < a.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < a.GetLength(1); j++)
    //            {
    //                b[j, i] = a[i, j];
    //            }
    //        }

    //        return b;

    //    }



    //}


}

