using System;
namespace Programs
{
    class Method
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 is called");

        }
        public void Method2()
        {
            Console.WriteLine("Method 2 is called");
        }
    }

    static class ExtensionMethods
    {
        public static void Method3(this Method m)
        {
            Console.WriteLine("Extension Method 3 is called");
        }
        public static void Method4(this Method m,int p)
        {
            Console.WriteLine("method 4 is callled with parameter p value:" + p);
            
        }
    }

    class MethodMain
    {
        public static void Main()
        {
            Method m = new Method();
            m.Method1();
            m.Method2();
            m.Method3();
            m.Method4(10);
        }
    }

    
}
