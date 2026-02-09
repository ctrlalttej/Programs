using System;

namespace Programs
{
    public delegate int CountIt(int count);
    internal class AnonymousMethodOuterVariable
    {
        public static CountIt Counter()
        {
            int sum = 0;

            CountIt ct = delegate (int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
                return sum;
            };
            return ct;
        }

        public static int count(int end)
        {
            int sum = 0;
            for(int i=0;i<=end;i++)
            {
                sum += i;
                Console.WriteLine(i);

            }
            return sum;
        }

        public static CountIt count()
        {
            CountIt c = new CountIt(count);           
            return c;
        }

        public static void Main()
        {
            //CountIt it = Counter();
            //Console.WriteLine("summation of 3: " + it(3));
            //Console.WriteLine("Summation of 5:" + it(5));

            CountIt r = count();
            Console.WriteLine("sum: "+r(3));
        }
    }
}
