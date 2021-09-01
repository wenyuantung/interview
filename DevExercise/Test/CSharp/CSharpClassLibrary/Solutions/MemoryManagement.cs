using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpClassLibrary
{
    public class MeanCalculationImplemenation2 : IMeanCalculation
    {
        public double GetAverage(int start, int end)
        {
            var values = new List<double>();
            int count = end - start + 1;
            var means = new List<Tuple<int, double>>();

            int lastPosition = start;
            int segmentCount = 1000000;

            while (lastPosition < end)
            {
                int endPos = Math.Min(end + 1, lastPosition + segmentCount);

                for (int index = lastPosition; index < endPos; index++)
                {
                    values.Add(index);
                }
                means.Add(new Tuple<int, double>(endPos - lastPosition, values.Average()));
                values.Clear();
                lastPosition += segmentCount;
                Console.WriteLine("Retrieved {0:N0} items of data.", lastPosition - start);
            }

            double total = means.Sum(mean => mean.Item1 * mean.Item2);
            return total / count;
        }
    }

    public class MeanCalculationImplemenation3 : IMeanCalculation
    {
        public double GetAverage(int start, int end)
        {
            double sum = 0;
            int count = end - start + 1;

            for (int index = start; index <= end; index++)
            {
                sum += index;
            }
            return sum / count;
        }
    }
}
