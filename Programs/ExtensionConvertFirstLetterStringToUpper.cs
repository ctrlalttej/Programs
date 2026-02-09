using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    static class ExtensionConvertFirstLetterStringToUpper
    {
        public static string ToProper(this string str)
        {
            if(str.Trim().Length>0)
            {
                string newStr = null;

                str = str.ToLower();
                string[] ArrayStr = str.Split(' ');
                foreach (var item in ArrayStr)
                {
                    char[] CharArray = item.ToCharArray();
                    CharArray[0]=char.ToUpper(CharArray[0]);

                    if(newStr==null)
                    newStr = new string(CharArray);
                    else
                        newStr += " "+ CharArray[0];
                }
                return newStr;

            }
            return str;
        }
    }
}
