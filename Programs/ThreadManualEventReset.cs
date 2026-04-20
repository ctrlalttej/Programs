using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ThreadManualEventReset
    {
        static ManualResetEvent manualReset = new ManualResetEvent(false);
        public static void Write()
        {
            Console.WriteLine("Writing the Document");
            manualReset.Reset();

            Console.WriteLine("Write has been completed");
            manualReset.Set();
        }
        public static void Read()
        {
            Console.WriteLine("Reading the Document started");
            manualReset.WaitOne();
            Console.WriteLine("Reading Completed...");
        }

        public static void Main()
        {
            Thread t1 = new Thread(Write);
            t1.Start();


            for(int i=0;i<5;i++)
            {
                new Thread(Read).Start();
            }

        }
    }
}
