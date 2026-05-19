using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadPools
    {
        public static void Main()
        {
            for(int i= 0; i<5; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolMethod));
            }

            Console.WriteLine(Environment.ProcessorCount);
            Console.ReadLine();
        }

        public static void ThreadPoolMethod(object obj)
        {
            Thread currentThread=Thread.CurrentThread;

            Console.WriteLine($"Background : {currentThread.IsBackground}  " +
                $"ThreadPool : {currentThread.IsThreadPoolThread}" +
                $" ThreadId : {currentThread.ManagedThreadId} ");
        }
    }
}
