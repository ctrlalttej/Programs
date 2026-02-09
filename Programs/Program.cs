//namespace Programs
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Hello, World!");

//            string s1 = "abcd";
//            string s2 = "abcde";
//            List<string> listS1 = new List<string>();
//            List<string> listS2 = new List<string>();
//            for(int i=1;i<=s1.Length;i++)
//            {
//                for(int j=0;j<=s1.Length-i;j++)
//                {
//                    listS1.Add(s1.Substring(j,i));
//                }
//            }

//            Console.WriteLine("List of substring in S1"+s1);
//            foreach (var item in listS1)
//            {
//                Console.WriteLine(item);
//            }



//            for (int i = 1; i <= s2.Length; i++)
//            {
//                for (int j = 0; j <= s2.Length - i; j++)
//                {
//                    listS2.Add(s2.Substring(j, i));
//                }
//            }
//            Console.WriteLine("List of substring in S2:"+s2);
//            foreach (var item in listS2)
//            {
//                Console.WriteLine(item);
//            }
//            int largest = 0;
//            string Commonsubstring = string.Empty;
//            foreach(var substring1 in listS1)
//            {
//                foreach (var substring2 in listS2)
//                {
//                    if(substring1==substring2)
//                    {
//                        if(substring1.Length>largest)
//                        {
//                            largest = substring1.Length;
//                            Commonsubstring= substring2;
//                        }
//                    }
//                }
//            }

//            Console.WriteLine($"Largest substring count{largest} and common substring: {Commonsubstring}");
//        }
//    }
//}
using System;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcd";
            string s2 = "abcde";

            for(int i=0;i<s1.Length;i++)
            {
                for(int j=i+1;j<s1.Length;j++)
                {
                    Console.WriteLine(s1.Substring(i,j-i));
                }
            }
            int index = 0;

            int[] arr = new int[] { 1, 2, 0, 3, 4, 0, 9, 0, 0 };
            for(int i=0;i< arr.Length;i++)
            {
                int temp = arr[i];
                if (arr[i]!=0)
                {
                    arr[i] = arr[index];
                    arr[index] = temp;
                    index++;
                }
            }
            var r=arr.Reverse();
            foreach (var item in r)
            {
                Console.Write(item);
            }
        }
    }
}
