using System;
namespace Programs
{
    internal class ThreadsLock
    {
        public void display()
        {
            lock(this)
            {
                Console.Write("C# is an");
                Thread.Sleep(3000);
                Console.WriteLine(" Object oriented");
            }
            
        }
        public static void Main()
        {
            ThreadsLock l = new ThreadsLock();
            Thread t1=new Thread(l.display);
            Thread t2=new Thread(l.display);
            Thread t3=new Thread(l.display);
            t1.Start(); t2.Start();t3.Start();
        }
    }
}
