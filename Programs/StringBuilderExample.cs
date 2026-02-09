using System;
using System.Diagnostics;
using System.Text;

namespace Programs
{
    internal class StringBuilderExample
    {
        public static void Main()
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string s = " ";
            for(int i=0;i<100000;i++)
            {
                s += i;
            }
            sw1.Stop();

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time taken for String "+sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken for String "+sw2.ElapsedMilliseconds);


        }
    }
}
