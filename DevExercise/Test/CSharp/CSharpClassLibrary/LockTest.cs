using System;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpClassLibrary
{
    public static class ProgressUpdate
    {
        public static void Update(int totalThreads, int totalCount)
        {
            var progress = new Progress();
            var ids = Enumerable.Range(1,  totalCount);     // Generate an array of totalCount elements

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
        }
    }

    public class Progress
    {
        private readonly object _lock = new object();
        private int _currentCount;

        public int CurrentCount
        {
            get
            {
                //lock (_lock)
                {
                    return _currentCount;
                }
            }
            set
            {
                //lock (_lock)
                {
                    _currentCount = value;
                }
            }
        }
    }
}
