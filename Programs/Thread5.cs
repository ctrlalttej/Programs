using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class Numberhelper
    {
        private int Number;

        public Numberhelper(int number)
        {
            this.Number = number;
        }

        public void run()
        {
            for (int i = 0;i<Number;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Thread5
    {
        public static void Main()
        {
            Numberhelper n = new Numberhelper(5);

            ThreadStart threadStart = new ThreadStart(n.run);

            Thread t=new Thread(threadStart);
            t.Start();
        }
    }

}
