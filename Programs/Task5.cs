using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Task5
    {
        public static void Main()
        {
            Task<string> task = Task.Run(() =>
            {
                return 10;
            }).ContinueWith(x => "Sum:"+x.Result).ContinueWith(y=>y.Result+" Final result");

            task.ContinueWith(y => Console.WriteLine("Result"));

            task.ContinueWith((info) =>
            {
                Console.WriteLine($"info: Iscompleted {info.IsCompleted} IsCancelled {info.IsCanceled}" +
                    $" IsFaulted{info.IsFaulted} {info.IsCompletedSuccessfully}");
            });

            task.ContinueWith((info) => {
                Console.Write("Task is Faulted");
            },TaskContinuationOptions.OnlyOnFaulted);

            task.ContinueWith((info) => {
                Console.Write("Task is Compltetion");
            }, TaskContinuationOptions.OnlyOnRanToCompletion); 


            Console.WriteLine(task.Result);
            Task.Delay(500).Wait();

            Console.ReadLine();
        }
    }
}
