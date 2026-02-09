using System.Diagnostics;
using System.Threading;

namespace Programs
{
    internal class ThreadsPerformance
    {
        public static void Increment1()
        {
            int count = 1;         
            for(int i=0;i<10000000;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        public static void Increment2()
        {
            int count = 1;  
            for(int i=0;i<10000000;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        public static void Main()
        {
            Stopwatch st1 = new Stopwatch();
            st1.Start();
            Increment1();
            Increment2();
            st1.Stop();
            Stopwatch st2 = new Stopwatch();
            st2.Start();
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);
            t1.Start();t2.Start();
            t1.Join();t2.Join();
            st2.Stop();
            Console.WriteLine("Time taken to complete using single thread : " + st1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete using multi thread : " + st2.ElapsedMilliseconds);
        }
    }
}
