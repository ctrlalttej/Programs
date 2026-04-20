namespace Programs
{
    public delegate void SumOfNumbers(int sum);
    class NumHelper
    {
        private int Max;
        private SumOfNumbers sumOfNumbersDelegate;

        public NumHelper(int max,SumOfNumbers sumOf)
        {
            this.Max = max;
            this.sumOfNumbersDelegate = sumOf;
        }

        public void run()
        {
            Console.WriteLine("Thread started");
            int sum = 0;
            for(int i=0;i<Max;i++)
            {

                Console.WriteLine(i);
                sum += i;
            }
            if (sumOfNumbersDelegate != null)
                sumOfNumbersDelegate(sum);
            Console.WriteLine("Thread ended");
        }
    }
    internal class ThreadCallback
    {
        public static void sum(int sum)
        {
            Console.WriteLine("Sum : " + sum);
        }
        public static void Main()
        {
            Console.WriteLine("Main thread started");
            SumOfNumbers s = new SumOfNumbers(sum);
            NumHelper number = new NumHelper(10,s);
            //ThreadStart st = new ThreadStart(number.run);
            //Thread th = new Thread(number.run);
            //th.Start();

            Thread th = new Thread(number.run);
            th.Start();
            th.IsBackground = true;
            th.Join();
            Console.WriteLine("Main Thread Ended");


        }
    }
}
