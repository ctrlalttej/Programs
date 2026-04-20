using System;

namespace Programs
{
    class MyThreads
    {
        string ThreadName { get; set; }

        public int Count {  get; set; }

        public MyThreads(string ThreadName,int Count)
        {
            this.ThreadName = ThreadName;
            this.Count = Count;
        }

        public void Run()
        {
            Console.WriteLine($"{ThreadName} Started");
            do
            {
                Console.WriteLine($"In {ThreadName}, Count is {Count}");
                Count++;
            } while (Count < 10);
            Console.WriteLine($"{ThreadName} terminating");
        }
    }
    internal class Threads
    {
        public int Test1()
        {
            Console.WriteLine("Test 1 started");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("Test1 : "+i);
                //Thread.Sleep(500);
            }
            Console.WriteLine("Test 1 ended");
            return 1;
        }

        public void Test2()
        {
            Console.WriteLine("Test 2 Started");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Test2 : " + i);
                //Thread.Sleep(500);
            }
            Console.WriteLine("Test 2 Ended");
        }
        public void Test3(object n)
        {
            Console.WriteLine("Test 3 Started");
            for (int i = 1; i <= (int)n; i++)
            {
                Console.WriteLine("Test3 : " + i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Test 3 ended");
        }

        public static void Main()
        {
            Threads t = new Threads();



            //ThreadStart threadStart = new ThreadStart(t.Test2);
            //Thread thread = new Thread(threadStart);
            //thread.Start();

            //ParameterizedThreadStart parameterizedThreadStart= new ParameterizedThreadStart(t.Test3);
            //Thread thread1 = new Thread(parameterizedThreadStart);
            //thread1.Start(15);

            //ThreadStart t = new ThreadStart();



        }
    }
}
