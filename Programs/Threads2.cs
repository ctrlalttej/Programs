
namespace Programs
{
    internal class Threads2
    {
        public static void run()
        {
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine("count " + i);
            }
        }

        public static void Main()
        {
            //ThreadStart  thread=new ThreadStart(run);

            //ThreadStart thread = run; //using direct method name

            ThreadStart thread = delegate //using ananyomous methods
            {
                run();
            };

            ThreadStart thread1 = () => //Using lambda expression
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("count " + i);
                }
            };
            Thread t=new Thread(thread1);

            Thread t1 = new Thread(run); //clr will automatically creates a delegate
            t.Start();
        }
    }
}
