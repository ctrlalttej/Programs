using System;
using System.Threading;

namespace Programs
{
    internal class Threadspriorities
    {
        public static int count1;
        public static int count2;
        public static void Incrementcount1()
        {
            count1++;
        }

        public static void Incrementcount2()
        {
            count2++;
        }

        public static void Main()
        {
            Thread t1 = new Thread(Incrementcount2);
            Thread t2 = new Thread(Incrementcount2);
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();t2.Start();
        
            Thread.Sleep(1000);
            
            t1.Abort(); t2.Abort();//Main thread to stop after 3 sec using abort method  

            Console.WriteLine("Count 1: " + count1);
            Console.WriteLine("Count 2: " + count2);

            
        }
    }
}
