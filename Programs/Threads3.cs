using System.Threading;

namespace Programs
{
    public class ThreadTest1
    {
        public int count;
        string ThreadName;

        public ThreadTest1(string ThreadName)
        {
            count = 0;
            this.ThreadName=ThreadName;
        }

        public void run()
        {
            Console.WriteLine($"{ThreadName} Started");
            do
            {
                Console.WriteLine($"{ThreadName} : {count}");
                Thread.Sleep(500);
                Thread.SpinWait(500);
                Thread.ResetAbort(); 
                count++;
            } while (count < 10);
        }

        public void ThreadRun(object i)
        {
            Console.WriteLine($"{ThreadName} Started");
            do
            {
                Console.WriteLine($"{ThreadName} : {count}");
                Thread.Sleep(500);
                count++;
            } while (count < 10);
        }
    }
    internal class Threads3
    {

        private static void print1()
        {
            Console.WriteLine("Thread 1 started");
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 1 Compelted");

        }

        private static void print2()
        {
            Console.WriteLine("Thread 2 Started");
            for (int i = 0; i <=20; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 2 Compelted");

        }

        private static void print3()
        {
            Console.WriteLine("Thread 3 Started");
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread 3 Compelted");

        }

        static void Main()
        {
            //Thread t1 = new Thread(print1);
            //Thread t2 = new Thread(print3);
            //Thread t3 = new Thread(print3);

            //t1.Start();
            //t2.Start();
            //t3.Start();



            //Console.WriteLine(t.Name +" " + t.ToString());
            Thread MainThread = Thread.CurrentThread;

            MainThread.Name = "Parent Thread";


            
            ThreadTest1 ChildClass = new ThreadTest1("Child Thread");
            ThreadStart t = new ThreadStart(ChildClass.run);
            Thread t1 = new Thread(t);

            //or 


            ThreadStart thr = ChildClass.run;
            Thread t2=new Thread(thr);


            //or
            Thread th = new Thread(ChildClass.run);  // clr will automatically delegate and pass


            ParameterizedThreadStart s = new ParameterizedThreadStart((object j) =>
            {
                for(int i=0;i<10;i++)
                {
                    Console.WriteLine("Count "+i);
                }
            });

            Thread t4 = new Thread(s);



            Thread ChildThread = new Thread(ChildClass.run);
            ChildThread.Start();

            do
            {
                Console.WriteLine($"{MainThread.Name} : {ChildClass.count}");
                Thread.Sleep(500);

            } while (ChildClass.count != 10);




        }
    }

    
}
