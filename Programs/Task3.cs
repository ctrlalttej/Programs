using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Task3
    {
        public static void Main()
        {
            int a = 30, b = 50;
            Console.WriteLine("Task started");
            Task<int> task = Task.Run(() =>
            {

                return a + b;
            }).ContinueWith((res) =>
            {
                return  res.Result + 100;
            }); 

            //ContinueWith works after Completin the task if any operations as to perform we can perform

            Console.WriteLine($"Sum of {a} and {b} = {task.Result}");

            Console.WriteLine("Task Ended");
        }
    }
}
