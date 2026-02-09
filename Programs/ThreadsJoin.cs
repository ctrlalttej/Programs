using System;
namespace Programs
{
    internal class ThreadsJoin
    {
        public static void test1()
        {
            Console.WriteLine("Thread 1 started");
            for (int i=0;i<10;i++)
                Console.Write(i + " ");
            Console.WriteLine("Thread 1 exit");
        }

        public static void test2()
        {
            Console.WriteLine("Thread 2 started");
            for (int i = 0; i < 10; i++)
                Console.Write(i+" ");
            Console.WriteLine("Thread 2 exit");
        }

        public static void test3()
        {
            Console.WriteLine("Thread 3 started");
            for (int i = 0; i < 10; i++)
                Console.Write(i + " ");
            Console.WriteLine("Thread 3 exit");
        }

        public static void Main()
        {
            Console.WriteLine("Main thead Started");
            Thread t1=new Thread(test1);
            Thread t2=new Thread(test2);
            Thread t3=new Thread(test3);
            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();
            Console.WriteLine("main thread exit");
        }
    }
}
