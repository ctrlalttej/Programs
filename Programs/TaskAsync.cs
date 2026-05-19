using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class TaskAsync
    {
        public static async Task Main()
        {
            Task task = Task.Run(async () =>
            {
                Console.WriteLine("Task1 completed");
            });

            Task task1 = Task.Run( async () =>
            {
                Console.WriteLine("Task2 completed");
            });

            Console.WriteLine("Waiting for task to complete");

           await Task.WhenAll(task,task1);
            //task1.Wait();

            Console.WriteLine("Main Thread Executed");
        }

        public async static Task  Print()
        {
            Console.WriteLine("Processing the File");
            Task<int> task = new Task<int>(Count);
            task.Start();
            var res = await task;

            Console.WriteLine("Process completed"+ res);
            Console.ReadLine();           

        }
        public static int Count()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Task got Complted");
            
            return Task.CurrentId.Value;
        }
    }
}
