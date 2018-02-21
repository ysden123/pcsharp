using System;
using System.Threading;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.MultiThreading
{
    /// <summary>
    /// Playing with async and await
    /// </summary>
    public class AsyncEx1
    {
        /// <summary>
        /// Some long process
        /// </summary>
        /// <returns>result</returns>
        public async Task<int> LongProcess1()
        {
            Console.WriteLine($"==>LongProcess1 ({Thread.CurrentThread.ManagedThreadId})");
            int result = await Task.Run(() =>
            {
                Console.WriteLine($"Running long process 1 ({Thread.CurrentThread.ManagedThreadId})");
                // Compute total count of digits in strings.
                int size = 0;
                for (int z = 0; z < 100; z++)
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        string value = i.ToString();
                        if (value == null)
                        {
                            return 0;
                        }
                        size += value.Length;
                    }
                }
                Console.WriteLine($"Completed long process 1 ({Thread.CurrentThread.ManagedThreadId})");
                return size;
            });
            Console.WriteLine($"<==LongProcess1 ({Thread.CurrentThread.ManagedThreadId})");
            return result;
        }

        /// <summary>
        /// Executes a long process 1.
        /// </summary>
        public void Test1()
        {
            Console.WriteLine($"==>Test1 ({Thread.CurrentThread.ManagedThreadId})");

            Console.WriteLine($"Call LongProcess1 ({Thread.CurrentThread.ManagedThreadId})");
            var result = LongProcess1();
            Console.WriteLine($"Do some actions inside Test1 method ({Thread.CurrentThread.ManagedThreadId})");
            Console.WriteLine($"Waiting...  ({Thread.CurrentThread.ManagedThreadId})");
            result.Wait();
            Console.WriteLine($"Result is {result.Result}  ({Thread.CurrentThread.ManagedThreadId})");
            Console.WriteLine($"<==Test1  ({Thread.CurrentThread.ManagedThreadId})");
        }
    }
}
