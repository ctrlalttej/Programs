using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Task4
    {
        public static void Main()
        {
            Console.WriteLine("Main Task Started");
            Task.Run(() => Method1());

            //Method1();
            Console.WriteLine("Main Task Ended");

            Console.ReadLine();
        }

        public static async void Method1()
        {
            Console.WriteLine("Method 1 Started");
            Method2();
            Console.WriteLine("After callling method");
            Console.WriteLine("Method 1 Ended");
        }

        public  static async void Method2()
        {
            Console.WriteLine("Method 2 Started");
             Task.Delay(1000);

            Console.WriteLine("Method 2 Ended");
        }


    }
}
