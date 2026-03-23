using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Threads4
    {
        //Passing the type safe parameter to the threads without using the object as input parameter with the help of the another helper class

        public static void Main()
        {
            Int32.TryParse(Console.ReadLine(),out int t2);

            NumberHelper n = new NumberHelper(t2);

            ThreadStart obj = new ThreadStart(n.ShowNumber);

            Thread t = new Thread(obj);
            t.Start();

        }
    }

    public class NumberHelper
    {
        private int _number;

        public NumberHelper(int number)
        {
            this._number = number;
        }

        public void ShowNumber()
        {
            for(int i=0;i<_number;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
