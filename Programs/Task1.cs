using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Task1
    {

        public static void Main()
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");

            //Task task = new Task(Print);
            //task.Start();

            //or
            //Task task = Task.Factory.StartNew(Print);

            //or

            Task task1 = Task.Run(() => { Print(); });

            task1.Wait(); //Before completing the main task, it will wait child thread to complete
            
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadLine();
        }

        public static void Print()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine($"Count : {i}");
            }
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
        }
    }
}
