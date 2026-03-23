//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programs
//{
//    public interface IText
//    {
//        public void Print();
//    }

//    public class Format:IText
//    {

//        public void Print()
//        {
//            Console.WriteLine("Constructor Dependecy Injection is called");
//        }

//    }

//    public class ConstructionInjection
//    {
//        private IText _text;

//        public ConstructionInjection(IText text)
//        {
//            this._text = text;
//            this._text.Print();
//        }
//    }

//    internal class DependencyConstructionInjection
//    {
//        public static void Main()
//        {
//            ConstructionInjection c = new ConstructionInjection(new Format());

//        }

//    }
//}
