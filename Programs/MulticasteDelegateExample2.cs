using System;

namespace Programs
{
    public delegate void StrOpr(string input);
    internal class MulticasteDelegateExample2
    {
        void ReplaceWithHypens(string input)
        {
            Console.WriteLine("Replacingm space with -" +input.Replace(' ', '-'));
        }

        void RemovingWhiteSpaces(string input)
        {
            string temp = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] != ' ')
                {
                    temp += input[i];
                }
            }
            Console.WriteLine("Removing the white Space:"+ temp);
        }

        void ReverseString(string input)
        {
            string temp = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp += input[i];
            }
            Console.WriteLine("reveese of string "+temp);
        }

        public static void Main()
        {
            MulticasteDelegateExample2 e=new MulticasteDelegateExample2();
            StrOpr s = e.ReplaceWithHypens;
            s += e.RemovingWhiteSpaces;
            s += e.ReverseString;
            s("Tejesh Y N");

        }
    }
}
