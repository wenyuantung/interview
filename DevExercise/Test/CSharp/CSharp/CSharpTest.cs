using System;
using CSharpClassLibrary;

namespace CSharp
{
    public static class CSharpTest
    {
        public static void Test4()
        {
            IMeanCalculation meanCalculation = new MeanCalculationImplemenation1();
            var value = meanCalculation.GetAverage(1, 200000000);
            Console.WriteLine("mean: {0}", value);
        }

        public static void Test3()
        {
            // What is the expected output?
            // If the output is not what expected, how to fix it
            ProgressUpdate.Update(5, 10000);
        }

        public static void TestVirtualFunction()
        {
            // What is the output?
            new Child();
        }

        public static void TestExxeption1()
        {

                ExceptionTest.Exception1();            
        }

        public static void TestExxeption2()
        {
            // What is the output?

             ExceptionTest.Exception2();

        }

        public static void TestExxeption3()
        {

                ExceptionTest.Exception3();

        }

    }
}
