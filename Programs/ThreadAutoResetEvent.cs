using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    
    internal class ThreadAutoResetEvent
    {
        static ManualResetEvent auto=new ManualResetEvent(true);
        public static void Main()
        {
            new Thread(SomeMethod).Start();
            Console.ReadLine();
            auto.Set();
            Console.ReadLine();
            auto.Set();
        }
        public static void SomeMethod()
        {
            Console.WriteLine("Starting1 ...");
            auto.WaitOne();
            Console.WriteLine("Finishing1...");
            Console.WriteLine("Starting2...");
            auto.WaitOne();
            Console.WriteLine("Finishing2...");
            auto.Reset();
            auto.WaitOne();
            Console.WriteLine("Starting3...");
            Console.WriteLine("Finishing3..");
        }
    }
}
