using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public static class ProgressUpdate
    {
        public class Progress
        {
            private int _currentCount;
            public int CurrentCount
            {
                get
                {
                    return _currentCount;
                }
                set
                {
                    _currentCount = value;
                }
            }
        }

        public static int Update(int totalThreads, int totalCount)
        {
            var progress = new CSharpClassLibrary.Progress();
            var ids = Enumerable.Range(1, totalCount);     // Generate an array of totalCount elements

            var parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = totalThreads
            };

            Parallel.ForEach(
                ids,                    // sources
                parallelOptions,        // how many threads    
                id =>                   // action
                {
                    progress.CurrentCount++;
                });

            Console.WriteLine("Threads: {0}, Count: {1}", totalThreads, progress.CurrentCount);

            return progress.CurrentCount;
        }
    }

    [TestClass]
    public class CSharpExercise6
    {
        [TestMethod]
        public void Test1()
        {
            // If the output is not what expected, how to fix it
            int count = ProgressUpdate.Update(1, 10000);
            Assert.IsTrue(count == 10000);

            int count2 = ProgressUpdate.Update(5, 10000);
            Assert.IsTrue(count2 == 10000);
        }
    }
}
