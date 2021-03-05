using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Dz3_task_1
{
    public class Program
    {

        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {

        public class PointClass
        {
            [Params(100)]
            public float X { get; set; }
            [Params(10)]
            public float Y { get; set; }


            public static float PointDistanceClass(PointClass pointOne, PointClass pointTwo)
            {

                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;

                return MathF.Sqrt((x * x) + (y * y));
            }
            [Benchmark]
            public void TestClassFloat()
            {

                PointClass point1 = new PointClass();
                point1.X = X;
                PointClass point2 = new PointClass();
                point2.Y = Y;

                PointDistanceClass(point1, point2);



            }



            public struct PointStruct
            {
                [Params(100)]
                public float X { get; set; }
                [Params(10)]
                public float Y { get; set; }
            }


            public static float PointDistanceStruct(PointStruct pointOne, PointStruct pointTwo)
            {

                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }
            [Benchmark]
            public void TestStructfloat()
            {

                PointStruct point1 = new PointStruct();
                point1.X = X;
                PointStruct point2 = new PointStruct();
                point2.Y = Y;

                PointDistanceStruct(point1, point2);



            }

            public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }
            [Benchmark]
            public void TestStructDouble()
            {

                PointStruct point1 = new PointStruct();
                point1.X = X;
                PointStruct point2 = new PointStruct();
                point2.Y = Y;

                PointDistanceDouble(point1, point2);


            }

            public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return (x * x) + (y * y);
            }
            [Benchmark]
            public void TestStruct()
            {

                PointStruct point1 = new PointStruct();
                point1.X = X;
                PointStruct point2 = new PointStruct();
                point2.Y = Y;

                PointDistanceShort(point1, point2);


            }
        }






            
        }
    }

    


