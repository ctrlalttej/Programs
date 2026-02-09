using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class MyPriority
    {
        public int count;
        public Thread thread;

        public static bool stop;

        static string CurrentName;

        public MyPriority(string Name)
        {
            thread = new Thread(this.run);
            count = 0;
            CurrentName = Name;
            thread.Name = CurrentName;
        }

        public void run()
        {
            Console.WriteLine($"{thread.Name} staring");
            do
            {
                count++;
                if (CurrentName != thread.Name)
                {
                    CurrentName = thread.Name;
                    Console.WriteLine("In " + CurrentName);
                }
            } while (!stop && count < 10000000);
            stop = true;
            Console.WriteLine($"{thread.Name} terminating");
        }
    }
    internal class ThreadsPriorities2
    {
        static void Main()
        {
            MyPriority mt1 = new MyPriority("High Priority");
            MyPriority mt2 = new MyPriority("Low Priority");
            // Set the priorities.
            mt1.thread.Priority = ThreadPriority.AboveNormal;
            mt2.thread.Priority = ThreadPriority.BelowNormal;
            // Start the threads.
            mt1.thread.Start();
            mt2.thread.Start();
            mt1.thread.Join();
            mt2.thread.Join();
            Console.WriteLine();
            Console.WriteLine(mt1.thread.Name + " thread counted to " + mt1.count);
            Console.WriteLine(mt2.thread.Name + " thread counted to " + mt2.count);

        }
    }
}
