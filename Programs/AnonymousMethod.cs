using System;

namespace Programs
{
    internal class AnonymousMethod
    {
        public delegate string Greetings(string Name);
        public static void Main()
        {
            Greetings g = delegate (string Name)
            {
                return "Hello " + Name + " Good morning!!..";
            };

            Console.WriteLine(g("Tej"));
        }
    }
}
