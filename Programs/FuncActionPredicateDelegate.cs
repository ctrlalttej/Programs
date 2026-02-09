using System;
namespace Programs
{
    internal class FuncActionPredicateDelegate
    {
        public static void Main()
        {
            Func<int,float,double,double> ad = (x,y,z) => x+ y + z;
            Console.WriteLine(ad(10, 28.5f, 23.940));

            Action<int,float,double> ads = (x,y,z) => Console.WriteLine(x+ y + z);
            ads(10, 28.5f, 23.940);

            Predicate<string> ch =(s)=>
            {
                if (s.Length > 4)
                    return true;
                return false;
            };
            Console.WriteLine(ch("tejesh"));
        }
    }
}
