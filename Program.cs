using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        static async Task<Int32> Main(string[] args)
        {
            // Creating three task
            Random rng = new Random();
            Random rngTwo = new Random();
            Int32 waitTime = rng.Next(1000, 5000);
            int waitTimeTwo = rngTwo.Next(1000, 5000);
            // Creating a task that will wait
            await Task.Delay(waitTime);
            await Task.Delay(waitTimeTwo);
            // The program will end after the preceding task terminates
            Console.WriteLine("The task1 has waited " + waitTime);
            Console.WriteLine("The task2 has waited " + waitTimeTwo);
            return 0;
        }
    }
}
