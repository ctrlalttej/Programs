using System;

namespace Programs
{
    public delegate string strMod(string input);
    internal class MulticasteDelegateExample3
    {
        static string ReplaceWithHypens(string input)
        {
            return input.Replace(' ', '-');
        }

        static string RemovingWhiteSpaces(string input)
        {
            string temp = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] != ' ')
                {
                    temp += input[i];
                }
            }
            return temp;
        }

        static string ReverseString(string input)
        {
            string temp = "";
            //int j = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                temp += input[i];
            }
            return temp;
        }

        public static void Main()
        {
            strMod s = ReplaceWithHypens;
            s +=RemovingWhiteSpaces;
            s += ReverseString;

            Console.WriteLine(s("Tejesh Y N"));
            s -= RemovingWhiteSpaces;
            s -= ReverseString;
            Console.WriteLine(s("Tejesh Y N"));

        }
    }
}
