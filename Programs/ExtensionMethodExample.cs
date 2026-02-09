using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    static class ExtensionMethodExample
    {
        public static long factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * factorial(x - 1);

        }

        public static void Main()
        {
            int i = 5;
            i.factorial();
            Console.WriteLine($"factorial of {i}: {i.factorial()} ");
            string name = "TeJesh Y N";
            Console.WriteLine(name.ToProper());
            Console.WriteLine(name.Split(' ').Count());
        }
    }
}
