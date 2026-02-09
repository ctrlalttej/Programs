using System;
using System.Security.Cryptography.X509Certificates;


namespace Programs
{
    public delegate int Increment(int count);
    public delegate int Factorial(int n);
    internal class LambdaExpression
    {
        public static void Main()
        {
            //Increment inc = count => count + 2; //Delegate(lambda expression)
            //int x = 0;
            //while(x<20)
            //{
            //    Console.WriteLine(x);
            //    x = inc(x);
            //}
            StatementLambda();

        }
        public static void StatementLambda()
        {
            Factorial fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                {
                    r *= i;
                }
                return r;
            };
            Console.WriteLine($"Factorial of Number {fact(3)} ");
            Console.WriteLine($"Factorial of Number {fact(5)} ");
            

        }
    }

    
}
