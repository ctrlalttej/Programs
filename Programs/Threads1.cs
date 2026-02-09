using System;
namespace Programs
{
    class Mythread
    {
        string threadName;
        public int count;

        public Mythread(string name)
        {
            threadName = name;
            count = 0;
        }

        public void run()
        {
            Console.WriteLine(threadName +" thread Starting");
            do
            {
                Thread.Sleep(500);
                Console.WriteLine($"In {threadName}, count is: {count}");
                count++;
            } while (count < 10);

        }
    }
    internal class Threads1
    {
        public static void Main()
        {
            Console.WriteLine("Main Thread is running");
            Mythread m = new Mythread("Child #1");
            ThreadStart t;
            ParameterizedThreadStart p;

            Thread newThread = new Thread(m.run);
            newThread.Start();

            do
            {
                Console.WriteLine("Main thread, count is :"+m.count);
                Thread.Sleep(500);
            } while (m.count != 10);

            Console.WriteLine("Main Thread is terminating");

        }
    }
}
