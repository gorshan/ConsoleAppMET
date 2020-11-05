using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    static public class IfElse
    {
        static public int DoSomeMath(int a, int b)
        {
            int c;
            if (a > b)
            {
                c = a + b;
            }
            else if (a < b)
            {
                c = a - b;
            }
            else c = a * b;
            return c;
        }

        static public string FindQuarter(int x, int y)
        {
            string Quarter;
            if ((x > 0) && (y > 0))
                Quarter = "I четверть";
            else if ((x < 0) && (y > 0))
                Quarter = "II четверть";
            else if ((x < 0) && (y < 0))
                Quarter = "III четверть";
            else if ((x > 0) && (y < 0))
                Quarter = "IV четверть";
            else
                Quarter = "на оси";
            return Quarter;

        }

        static public int[] Sort3ToBig(int a, int b, int c)
        {
            int[] Sor;
            if (a < b && a < c)
            {
                if (b < c)
                    Sor = new int[3] { a, b, c };
                else
                    Sor = new int[3] { a, c, b };
            }
            else if (b < a && b < c)
            {
                if (a < c)
                    Sor = new int[3] { b, a, c };
                else
                    Sor = new int[3] { b, c, a };
            }
            else if (a < b)
                Sor = new int[3] { c, a, b };
            else
                Sor = new int[3] { c, b, a };

            return Sor;
        }

        static public double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Parameter a can't be 0");
            }

            double d;
            double x, x1, x2;
            double[] Root;

            d = b * b - 4 * a * c;
            if (d < 0)
                Root = new double[0];
            else if (d == 0)
            {
                x = (-1 * b) / (2 * a);
                Root = new double[1] { x };
            }
            else
            {
                x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                Root = new double[2] { x1, x2 };
            }
            return Root;
        }

        static public string ConvertTwoDigitNumberToString(int a)
        {
            if (a > 99 || a < 10)
            {
                throw new Exception("Not a two-digit number!");
            }

            if (a == 10)
            {
                Console.WriteLine("десять");
            }
            string x;
            string y;
            string aString;
            int d;
            int c;
            x = "";
            y = "";
            d = a / 10;
            c = a % 10;

            if (d == 1)
            {
                y = "надцать";
                switch (c)
                {
                    case 1:
                        x = "один";
                        break;
                    case 2:
                        x = "две";
                        break;
                    case 3:
                        x = "три";
                        break;
                    case 4:
                        x = "четыр";
                        break;
                    case 5:
                        x = "пят";
                        break;
                    case 6:
                        x = "шест";
                        break;
                    case 7:
                        x = "сем";
                        break;
                    case 8:
                        x = "восемь";
                        break;
                    case 9:
                        x = "девят";
                        break;

                }
                c = -1;

            }

            switch (d)
            {
                case 2:
                    x = "двадцать ";
                    break;
                case 3:
                    x = "тридцать ";
                    break;
                case 4:
                    x = "сорок ";
                    break;
                case 5:
                    x = "пятьдесят ";
                    break;
                case 6:
                    x = "шестьдесять ";
                    break;
                case 7:
                    x = "семьдесят ";
                    break;
                case 8:
                    x = "восемдесят ";
                    break;
                case 9:
                    x = "девяносто ";
                    break;
            }

            switch (c)
            {
                case 0:
                    y = "";
                    break;
                case 1:
                    y = "один";
                    break;
                case 2:
                    y = "два";
                    break;
                case 3:
                    y = "три";
                    break;
                case 4:
                    y = "четыре";
                    break;
                case 5:
                    y = "пять";
                    break;
                case 6:
                    y = "шесть";
                    break;
                case 7:
                    y = "семь";
                    break;
                case 8:
                    y = "восемь";
                    break;
                case 9:
                    y = "девять";
                    break;

            }


            //Console.WriteLine(x + y);
            aString = x + y;
            return aString;
        }

    }
}
