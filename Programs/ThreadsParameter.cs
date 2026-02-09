using System;
namespace Programs
{
    internal class ThreadsParameter
    {
        public static void run(object max)
        {
            Console.WriteLine("Thread 1 started");
            for(int i=0;i< (int)max;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 1 exit");
        }

        public static void Main(string[] args)
        {
            ParameterizedThreadStart d=new ParameterizedThreadStart(run);

            
            Thread thread = new Thread(d);
            thread.Start(10);

            Thread thread1 = new Thread(run);
            thread1.Start(20);
        }

    }
}
