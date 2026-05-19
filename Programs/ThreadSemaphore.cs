using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadSemaphore
    {
        static Semaphore semaphore=new Semaphore(2,2);
        public static void Print()
        {
            semaphore.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name + " Entered");
            Thread.Sleep(500);
            Console.WriteLine(Thread.CurrentThread.Name + " Existing");
            semaphore.Release();
        }

        public static void Main() {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Print);
                t.Name = "Thread " + i;
                t.Start();  
            }
        }

    }
}
