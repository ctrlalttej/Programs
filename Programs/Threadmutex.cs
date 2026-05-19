using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Threadmutex
    {
        public static Mutex _mutex = new Mutex();

        public static void Main()
        {
            Thread t1 = new Thread(Print);
            Thread t2 = new Thread(Print);
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t1.Start();
            t2.Start();
        }

        public static void Print()
        {
            _mutex.WaitOne();
            Console.WriteLine(Thread.CurrentThread.Name+" Entering");
            Thread.Sleep(500);
            Console.WriteLine(Thread.CurrentThread.Name + " Existing");
            _mutex.ReleaseMutex();
        }
        public static void Divide()
        {
            Random r=new Random();
            for(int i = 0;i<1000;i++)
            {
                _mutex.WaitOne();
                int dividedent = r.Next(2, 10);
                int divisor=r.Next(2, 10);

                int res=dividedent/divisor;
                dividedent = 0;
                    divisor = 0;
                _mutex.ReleaseMutex();
            }
        }
    }
}
