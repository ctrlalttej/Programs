using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class DelegateTest
    {
        //public delegate int SquareOfNumber(int x);

        public static int square(int x)
        {
            return x * x;
        }
        public static void Main()
        {
            //SquareOfNumber squareOf = new SquareOfNumber(square);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Square of number {i}:{squareOf.Invoke(i)}");
            //}

            //SquareOfNumber squareOf = square;

            //SquareOfNumber squareOf= delegate(int x)
            //{
            //    return x*x; 
            //};

            //SquareOfNumber squareOf = x => x * x;

            Func<int, int> squareOf = x => x * x;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Square of number {i}:{squareOf.Invoke(i)}");
            }
        }

    }
}
