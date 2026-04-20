using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadInterlockedIncrement
    {
        public static int sum = 0;
        public static void Addition()
        {
            int y = 4;
            for(int i=0;i<10;i++)
            {
                Interlocked.CompareExchange(ref sum, 5,6);

            }
        }
        public static void Main()
        {
            //Thread t1 = new Thread(Addition);

            //Thread t2 = new Thread(Addition);
            //t1.Start();
            //t2.Start();

            //t1.Join();
            //t2.Join();

            int y = 6;

            Interlocked.CompareExchange(ref y, 10, 7);
            Console.WriteLine(y);

            Console.WriteLine("Sum:" + sum);


        }
    }
}
