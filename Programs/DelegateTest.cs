using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class DelegateTest
    {
        public delegate int SquareOfNumber(int x);

        public  int square(int x)
        {
            return x * x;
        }
        public static void Main()
        {
            DelegateTest delegateTest= new DelegateTest();
            SquareOfNumber squareOf = new SquareOfNumber(delegateTest.square);

            Console.WriteLine(squareOf.GetMethodInfo());
            Console.WriteLine(squareOf.Target);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Square of number {i}:{squareOf.Invoke(i)}");
            }

            //SquareOfNumber squareOf = square;

            //SquareOfNumber squareOf= delegate(int x)
            //{
            //    return x*x; 
            //};

            //SquareOfNumber squareOf = x => x * x;

            //Func<int, int> squareOf = x => x * x;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Square of number {i}:{squareOf.Invoke(i)}");
            }
        }

    }
}
