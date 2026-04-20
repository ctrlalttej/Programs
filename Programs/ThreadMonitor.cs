using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadMonitor
    {
        public static int sum = 0;
        private static Object _lock=new object();
        public static void Addition()
        {
             bool lockTakeDown=false;
            Monitor.Enter(_lock,ref lockTakeDown);
            try
            {
                for (int i = 0; i < 10000000; i++)
                    sum++;
            }
            finally
            {
                if(lockTakeDown)
                Monitor.Exit(_lock);
            }
            
        }
        public static void Main()
        {
            Thread t1 = new Thread(Addition);
            Thread t2 = new Thread(Addition);

            t1.Start();t2.Start();

            t1.Join();t2.Join();

            Console.WriteLine("Sum:" + sum);
        }
    }
}
