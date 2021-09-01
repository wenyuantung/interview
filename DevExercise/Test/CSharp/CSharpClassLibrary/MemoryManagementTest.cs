using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpClassLibrary
{
    public interface IMeanCalculation
    {
        double GetAverage(int start, int end);
    }


    public class MeanCalculationImplemenation1 : IMeanCalculation
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
}
