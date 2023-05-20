using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{


    static public class Class1
    {
        static public double SumArray(double[] num)
        {
            double result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result = result + num[i];
            }
            return result;
        }

        static public double MaxFromArray(double[] arr)
        {
            return arr.Max();
        }
        static public double MinFromArray(double[] arr)
        {
            return arr.Min();
        }

        static public double AVGArray(double[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                return SumArray(arr) / arr.Length;
            }
        }
    }

    static public class Geometry
    {
        static public double TrianglAarea(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                return 0;
            }
            return a * b / 2;
        }
        static public double AnotherTrianglAarea(double a, double b, double c)
        {
            double p = a + b + c / 2;
            if (p > 0)
            {
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else { return 0; }
        }
        static public double SquareArea(double a)
        {
            return a * a;
        }

        static public double RectangleArea(double a, double b)
        {
            return a * b;
        }
        static public double RhombusArea(double a, double b)
        {
            return a * b / 2;
        }
        static public double CircleArea(double r)
        {
            return Math.PI * r * r;

        }
    }
    static public class Trigonometry
    {
        static public double Sin(double corner)
        {
            return Math.Sin(corner);
        }
        static public double Cos(double corner)
        {
            return Math.Cos(corner);
        }
        static public double Tgn(double corner)
        {
            return Math.Tan(corner);
        }
        static public double Ctg(double corner)
        {
            return Math.Tanh(corner);
        }
    }
}
  