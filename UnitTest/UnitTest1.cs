using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{

    [TestClass]
    public class SumArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] num = new double[5] { 3, 100, 45, 60, 1 };

            Assert.AreEqual(209, Class1.SumArray(num));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[] num = new double[5];

            Assert.AreEqual(0, Class1.SumArray(num));
        }
        [TestMethod]

        public void TestMethod3()
        {
            double[] num = new double[5] { 3, -100, 45, -60, 1 };

            Assert.AreEqual(-111, Class1.SumArray(num));
        }
        [TestMethod]

        public void TestMethod4()
        {
            double[] num = new double[5] { 8.5, 3.2, 8, 10, 1.67 };

            Assert.AreEqual(31.37, Math.Round(Class1.SumArray(num),2));
        }
    }


    [TestClass]
    public class MaxFromArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] num = new double[5] { 3, 100, 45, 60, 1 };

            Assert.AreEqual(100, Class1.MaxFromArray(num));
        }
        [TestMethod]
        public void TestMethod4()
        {
            double[] num = new double[5] { -3, -100, 45, -60, 1 };

            Assert.AreEqual(45, Class1.MaxFromArray(num));
        }
        [TestMethod]
        public void TestMethod5()
        {
            double[] num = new double[5];

            Assert.AreEqual(0, Class1.MaxFromArray(num));
        }
        [TestMethod]

        public void TestMethod6()
        {
            double[] num = new double[5] { double.MaxValue, -100, 45, int.MaxValue, 1 };

            Assert.AreEqual(double.MaxValue, Class1.MaxFromArray(num));
        }
    }


    [TestClass]
    public class MinFromArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] num = new double[5] { 3, 100, 45, 60, 1 };

            Assert.AreEqual(1, Class1.MinFromArray(num));
        }
        [TestMethod]
        public void TestMethod7()
        {
            double[] num = new double[5] { -3, -100, 45, -60, 1 };

            Assert.AreEqual(-100, Class1.MinFromArray(num));
        }
        [TestMethod]
        public void TestMethod8()
        {
            double[] num = new double[5];

            Assert.AreEqual(0, Class1.MinFromArray(num));
        }
        [TestMethod]
        public void TestMethod9()
        {
            double[] num = new double[5] { double.MaxValue, -100, 45, int.MinValue, 1 };

            Assert.AreEqual(int.MinValue, Class1.MinFromArray(num));
        }
    }


    [TestClass]
    public class AVGArrayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] num = new double[5] { 3, 100, 45, 60, 1 };

            Assert.AreEqual(41.8, Class1.AVGArray(num));
        }
        [TestMethod]

        public void TestMethod7()
        {
            double[] num = new double[5] { -3, -100, 45, -60, 1 };

            Assert.AreEqual(-23.4, Class1.AVGArray(num));
        }
        [TestMethod]
        public void TestMethod8()
        {
            double[] num = new double[5];

            Assert.AreEqual(0, Class1.AVGArray(num));
        }
        [TestMethod]
        public void TestMethod9()
        {
            double[] num = new double[5] { 0.4,-100, 45, 7.1, 1 };

            Assert.AreEqual(-9.3, Math.Round(Class1.AVGArray(num),2));
        }
    }


    [TestClass]
    public class TrianglAareaTest
    {
        [TestMethod]
        public void TestMethod9()
        {
            double a = 100;
            double b = 3;
            Assert.AreEqual(150, Geometry.TrianglAarea(a, b));
        }
        [TestMethod]
        public void TestMethod10()
        {
            double a = int.MaxValue;
            double b = 3;
            Assert.AreEqual(3221225470.5, Geometry.TrianglAarea(a, b));
        }
        [TestMethod]
        public void TestMethod11()
        {
            double a = -100;
            double b = 3;
            Assert.AreEqual(0, Geometry.TrianglAarea(a, b));
        }
        [TestMethod]
        public void TestMethod12()
        {
            double a = 0;
            double b = 3;
            Assert.AreEqual(0, Geometry.TrianglAarea(a, b));
        }
    }









    [TestClass]
    public class CtgTest
    {
        [TestMethod]
        public void TestMethod13()
        {
            double num = -10;

            Assert.AreEqual(Math.Tanh(-10), Trigonometry.Ctg(num));
        }
        [TestMethod]
        public void TestMethod22()
        {
            double num = -10;

            Assert.AreEqual(0, Trigonometry.Ctg(num));
        }

        [TestMethod]
        public void TestMethod14()
        {
            double num = int.MaxValue;

            Assert.AreEqual(Math.Tanh(double.MaxValue), Trigonometry.Ctg(num));
        }
        [TestMethod]
        public void TestMethod15()
        {
            double num = 2.3;

            Assert.AreEqual(Math.Tanh(2.3), Trigonometry.Ctg(num));
        }

    }
    [TestClass]
    public class TgnTest
    {
        [TestMethod]
        public void TestMethod16()
        {
            double num = -10;

            Assert.AreEqual(Math.Tan(num), Trigonometry.Tgn(num));
        }
        [TestMethod]
        public void TestMethod22()
        {
            double num = -10;

            Assert.AreEqual(Math.Tan(num), Trigonometry.Tgn(num));
        }
        [TestMethod]
        public void TestMethod17()
        {
            double num = int.MaxValue;

            Assert.AreEqual(Math.Tan(num), Trigonometry.Tgn(num));
        }
        [TestMethod]
        public void TestMethod18()
        {
            double num = 2.3;

            Assert.AreEqual(Math.Tan(num), Trigonometry.Tgn(num));
        }

    }
    [TestClass]
    public class CosTest
    {
        [TestMethod]
        public void TestMethod19()
        {
            double num = 0;

            Assert.AreEqual(0,Math.Round(Trigonometry.Cos(num),2));
        }
        [TestMethod]
        public void TestMethod22()
        {
            double num = -10;

            Assert.AreEqual(Math.Cos(num), Trigonometry.Cos(num));
        }
        [TestMethod]
        public void TestMethod20()
        {
            double num = int.MaxValue;

            Assert.AreEqual(Math.Cos(num), Trigonometry.Cos(num));
        }
        [TestMethod]
        public void TestMethod21()
        {
            double num = 2.3;

            Assert.AreEqual(Math.Cos(num), Trigonometry.Cos(num));
        }

    }
    [TestClass]
    public class SinTest
    {
        [TestMethod]
        public void TestMethod22()
        {
            double num = -10;

            Assert.AreEqual(Math.Sin(num), Trigonometry.Sin(num));
        }
        [TestMethod]
        public void TestMethod23()
        {
            double num = 0;

            Assert.AreEqual(0, Trigonometry.Sin(num));
        }

        [TestMethod]
        public void TestMethod24()
        {
            double num = int.MaxValue;

            Assert.AreEqual(Math.Sin(num), Trigonometry.Sin(num));
        }
        [TestMethod]
        public void TestMethod25()
        {
            double num = 2.3;

            Assert.AreEqual(Math.Sin(num), Trigonometry.Sin(num));
        }



        [TestClass]
        public class AnotherTriangleArea
        {
            [TestMethod]
            public void TestMethod25()
            {
                double a = long.MaxValue;
                double b = 3;
                Assert.AreEqual(0, Geometry.AnotherTrianglAarea(a, b, 1));
            }
            [TestMethod]
            public void TestMethod26()
            {
                double a = -10;
                double b = 3;
                Assert.AreEqual(0,Geometry.AnotherTrianglAarea(a, b, 1));
            }
            [TestMethod]
            public void TestMethod27()
            {
                double a = 0;
                double b = 3;
                Assert.AreEqual(3.91, Math.Round(Geometry.AnotherTrianglAarea(a, b, 1),2));
            }
         
        }




        [TestClass]
        public class SquareAreaTest
        {
            [TestMethod]
            public void TestMethod28()
            {
                double a = 5.8;
              
                Assert.AreEqual(33.64,Geometry.SquareArea(a));
            }
            [TestMethod]
            public void TestMethod29()
            {
                double a = -100;
              
                Assert.AreEqual(9, Geometry.SquareArea(a));
            }
            [TestMethod]
            public void TestMethod30()
            {
                double a = 0;
                Assert.AreEqual(0, Geometry.SquareArea(a));
            }


            [TestClass]
            public class RectangAreaaTest
            {
                [TestMethod]
                public void TestMethod31()
                {
                    double a = 0.5;
                    double b = 3;
                    Assert.AreEqual(1.5, Geometry.RectangleArea(a, b));
                }
                [TestMethod]
                public void TestMethod32()
                {
                    double a = -100;
                    double b = 3;
                    Assert.AreEqual(-300, Geometry.RectangleArea(a, b));
                }
                [TestMethod]
                public void TestMethod33()
                {
                    double a = 0;
                    double b = 3;
                    Assert.AreEqual(0, Geometry.RectangleArea(a, b));
                }


                [TestClass]
                public class RhombusAreaTest
                {
                    [TestMethod]
                    public void TestMethod34()
                    {
                        double a = 8.4;
                        double b = 3;
                        Assert.AreEqual(12.6 , Math.Round(Geometry.RhombusArea(a, b),2));
                    }
                    [TestMethod]
                    public void TestMethod35()
                    {
                        double a = -100;
                        double b = 3;
                        Assert.AreEqual(-150, Geometry.RhombusArea(a, b));
                    }
                    [TestMethod]
                    public void TestMethod36()
                    {
                        double a = 0;
                        double b = 3;
                        Assert.AreEqual(0, Geometry.RhombusArea(a, b));
                    }



                    [TestClass]
                    public class CircleAreaTest
                    {
                        [TestMethod]
                        public void TestMethod37()
                        {
                            double a = 0.2;
                            
                            Assert.AreEqual(0.13, Math.Round(Geometry.CircleArea(a),2));
                        }
                        [TestMethod]
                        public void TestMethod38()
                        {
                            double a = -100;
                            double b = 3;
                            Assert.AreEqual(28.27, Math.Round(Geometry.CircleArea(b),2));
                        }
                        [TestMethod]
                        public void TestMethod39()
                        {
                            double a = 0;
                            double b = 3;
                            Assert.AreEqual(0, Geometry.CircleArea(a));
                        }

                    }
                }
            }
        }
    }
}










