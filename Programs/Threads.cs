using System;

namespace Programs
{
    internal class Threads
    {
        public static void test1()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine($"test1 : " + i);
            Console.WriteLine("Thread 1 Completed");
        }

        public static void test2()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine($"test2 : " + i);
            Console.WriteLine("Thread 2 Completed");
        }

        public static void test3()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine($"test3 : " + i);
            Console.WriteLine("Thread 3 Completed");
        }

        public static void Main()
        {
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Completed");
        }
    }
}
