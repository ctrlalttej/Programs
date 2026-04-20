using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class TickTock
    {
        object _lock = new object();
        public void Tick(bool IsRunning)
        {
            lock (_lock)
            {
                if (!IsRunning)
                {
                    Monitor.Pulse(_lock);
                    return;
                }
                Console.Write("Tick ");
                Monitor.Pulse(_lock);
                Monitor.Wait(_lock);

            }
        }

        public void Tock(bool IsRunning)
        {
            lock (_lock)
            {
                if (!IsRunning)
                {
                    Monitor.Pulse(_lock);
                    return;
                }
                Console.WriteLine("Tock ");
                Monitor.Pulse(_lock);
                Monitor.Wait(_lock);
            }
        }
        public void Time(bool IsRunning)
        {
            lock (_lock)
            {
                if (!IsRunning)
                {
                    Monitor.Pulse(_lock);
                    return;
                }
                Console.WriteLine("Time ");
                Monitor.Pulse(_lock);
                Monitor.Wait(_lock);
            }
        }
    }

    class MyTickTock
    {
        public Thread thread;
        TickTock tickTock;

        public MyTickTock(string Name,TickTock tt)
        {
            thread = new Thread(this.Run);
            tickTock = tt;
            thread.Name = Name;
            thread.Start();
        }

        void Run()
        {
            if (thread.Name == "Tick")
            {
                for (int i = 0; i < 5; i++) tickTock.Tick(true);
                tickTock.Tick(false);
            }
            if (thread.Name == "Tock")
            {
                for (int i = 0; i < 5; i++) tickTock.Tock(true);
                tickTock.Tock(false);
            }
            if (thread.Name == "Time")
            {
                for (int i = 0; i < 5; i++) tickTock.Time(true);
                tickTock.Tock(false);
            }
        }
    }
    internal class ThreadTickTok
    {
        public static void Main()
        {
            TickTock t = new TickTock();
            MyTickTock my = new MyTickTock("Tick", t);
            MyTickTock my1 = new MyTickTock("Tock", t);
            //MyTickTock my2 = new MyTickTock("Time", t);

            //my.thread.Join();
            //my1.thread.Join();

           // Console.WriteLine("Clock Stopped");
        }
    }
}
