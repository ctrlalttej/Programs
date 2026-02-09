using System;

namespace Programs
{
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor is called");
        }

        public static void Main()
        {
            Console.WriteLine("Main method is called");
        }
    }
}
