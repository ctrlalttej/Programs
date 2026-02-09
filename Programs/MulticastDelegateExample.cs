using System;

namespace Programs
{
    public delegate void Rectangle(int len, int br);
    internal class MulticastDelegateExample
    {
        public void AreaofRectangle(int length, int breadth)
        {
            Console.WriteLine("Area of Rectangle:" + (length * breadth));
        }

        public void PerimeterOfRectangle(int length, int breadth)
        {
            Console.WriteLine("Perimeter of rectangle:" + (2 * (length + breadth)));
        }
        static void Main()
        {
            MulticastDelegateExample e = new MulticastDelegateExample();
            Rectangle r = e.AreaofRectangle;

            r += e.PerimeterOfRectangle;
            r(5, 6);
        }
    }

    
}
