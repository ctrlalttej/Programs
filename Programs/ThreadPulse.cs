using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadPulse
    {
        static object _lock = new object();

        public static void Write()
        {
            Monitor.Enter(_lock);
            for (int i = 0; i < 5; i++)
            {
               
                Console.WriteLine($"Write Thread is excuting...{i}");
                Console.WriteLine($"Write Thread is completed...{i}");
                Monitor.Pulse(_lock);
                if (i<5)

                 Monitor.Wait(_lock);
            }
            Monitor.Exit(_lock);
        }

        public static void Read()
        {
            Monitor.Enter(_lock);
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine($"Read Thread is executing...{i}");
                Console.WriteLine($"Read Thread is completed...{i}");

                Monitor.Pulse(_lock);
                if (i<5)
                 Monitor.Wait(_lock);
            }
            Monitor.Exit(_lock);
        }
        public static void Close()
        {
            Monitor.Enter(_lock);
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Close Thread is excuting...{i}");
                Console.WriteLine($"Close Thread is completed...{i}");
                Monitor.Pulse(_lock);
                if (i < 5)
                    Monitor.Wait(_lock);
            }
            Monitor.Exit(_lock);
        }

        public static void Main()
        {
            Thread t1 = new Thread(Write);
            Thread t2 = new Thread(Read);
            //Thread t3 = new Thread(Close);

            t1.Start(); t2.Start(); //t3.Start();

            t1.Join(); t2.Join();//t3.Join();
            Console.ReadLine();
        }
    }
}
