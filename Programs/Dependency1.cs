using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public interface IText
    {
        void Print();
    }

    public class Format:IText
    {
        public void Print()
        {
            Console.WriteLine("Constructor Injection is Called");
        }
    }

    public class TextFormat
    {
        IText text;

        public TextFormat(IText text)
        {
            this.text = text;
            this.text.Print();
        }
    }
    internal class Dependency1
    {
        public static void Main()
        {
            IText f = new Format();
            TextFormat t = new TextFormat(f);
        }
    }
}
