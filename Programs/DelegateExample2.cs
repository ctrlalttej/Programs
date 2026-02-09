using System;
using System.Security.Cryptography.X509Certificates;
namespace Programs
{
    internal class DelegateExample2
    {
        public delegate string strMod(string input);
        static string ReplaceWithHypens(string input)
        {
            return input.Replace(' ', '-');
        }

        static string RemovingWhiteSpaces(string input)
        {
            string temp = "";
            for (int i = 0; i <=input.Length - 1; i++)
            {
                if(input[i] != ' ')
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
            for(int i = input.Length-1;i>=0;i--)
            {
                temp += input[i];
            }
            return temp;
        }
        public static void Main()
        {
            strMod s = new strMod(ReplaceWithHypens);
            Console.WriteLine(s("Tejesh Y N"));
            strMod remove = new strMod(RemovingWhiteSpaces);
            Console.WriteLine(remove("Tejesh Y N"));
            strMod reverse = new strMod(ReverseString);
            Console.WriteLine(reverse("Tejesh"));

            strMod del = ReplaceWithHypens;
            Console.WriteLine(del("Tejesh Y N"));
            del = RemovingWhiteSpaces;
            Console.WriteLine(del("Tejesh Y N"));
            del = ReverseString;
            Console.WriteLine(del("Tejesh Y N"));
        }

    }
}
