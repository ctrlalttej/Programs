using System;
namespace Programs
{
    internal class DelegateExample
    {
        public delegate void AddDelegate(int x, int y);
        public delegate void HelloDelegate(string s);
        public void AddNum(int a,int b)
        {
            Console.WriteLine($"Sum of {a},{b}={a + b}");
        }

        public static void Hello(string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }

        public static void Main()
        {
            DelegateExample e = new DelegateExample();
            //e.AddNum(10, 20);
            //Hello("Tej");
            AddDelegate ad = new AddDelegate(e.AddNum);
            HelloDelegate hd = new HelloDelegate(Hello);
            ad(10, 20);
            hd("Tej");

            ad.Invoke(10, 20);
            hd.Invoke("Tej");
        }
    }
}
