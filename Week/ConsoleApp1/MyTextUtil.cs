using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyTextUtil
    {
        public static string CamelCase(string s)
        {
            string str = "";
            Boolean whiteSpace = false;
            foreach (Char c in s)
            {
                if (c == ' ')
                {
                    whiteSpace = true;
                }
                else
                {
                    if (whiteSpace)
                    {
                        char.ToUpper(c);
                        str += c;
                        string.ToUpper(str);
                    }
                    else
                    {
                        char.ToUpper(c);
                        str += c;
                    }
                }


            }
            return str;
        }

        public static string UnCamelCased(string s)
        {
            return s;
        }
    }
}