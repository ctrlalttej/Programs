using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadSync
    {
        public static int sum = 0;  

        public static void SumOfNumbers()
        {
            for(int i=1;i<=1000000;i++)
            {
               sum++;
            }
        }
        public static void Main()
        {
            Thread t1 = new Thread(SumOfNumbers);
            Thread t2 = new Thread(SumOfNumbers);
            t1.Start();
            t2.Start();

            //t1.Join();
            //t2.Join();
            Console.WriteLine("sum : " + sum);
        }
    }
}
