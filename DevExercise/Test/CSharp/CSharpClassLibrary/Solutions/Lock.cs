using System;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpClassLibrary
{
    public static class ProgressUpdate2
    {
        private static readonly object LockObject = new object();

        public static void Update(int totalThreads, int totalCount)
        {
            var progress = new Progress();
            var ids = Enumerable.Range(1, totalCount);

            var parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = totalThreads
            };

            Parallel.ForEach(
                ids,                    // sources
                parallelOptions,        // how many threads    
                id =>                   // action
                {
                    lock(LockObject)
                    {
                        progress.CurrentCount++;
                    }

                });

            Console.WriteLine("Threads: {0}, Count: {1}", totalThreads, progress.CurrentCount);
        }
    }    
}
