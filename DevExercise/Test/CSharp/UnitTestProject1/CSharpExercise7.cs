using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class MeanCalculationImplemenation1 
    {
        public double GetAverage(int start, int end)
        {
            var values = new List<double>();
            for (int index = start; index <= end; index++)
            {
                values.Add(index);
                if (index % 10000000 == 0)
                    Console.WriteLine("Retrieved {0:N0} items of data.", index);
            }
            return values.Average();
        }
    }
    [TestClass]
    public class CSharpExercise7
    {
        [TestMethod]
        public void Test2()
        {
            // What is the expected output
            var meanCalculation = new MeanCalculationImplemenation1();
            // Average all the number between 1 to 200000000
            var value = meanCalculation.GetAverage(1, 200000000);
            Console.WriteLine("mean: {0}", value);
            Assert.AreEqual(value, 100000000.5);
        }
    }
}
