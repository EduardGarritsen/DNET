using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class MyTextUtil
    {
        public static string CamelCase(string s)
        {
            String str = "";
            Boolean whiteSpace = false;
            foreach(char c in s)
            {
                if(c == ' ')
                {
                    whiteSpace = true;
                }
                else
                {
                    if(whiteSpace)
                    {
                        whiteSpace = false;
                        str += char.ToUpper(c);
                    }
                    else
                    {
                        str += c;
                    }
                }
                
            }
            return str;
        }
        public static string UnCamelCased(string s)
        {
            String str = "";
            Boolean upperCase = false;
            foreach (char c in s)
            {
                if (c == char.ToUpper(c))
                {
                    upperCase = true;
                    str += ' ';
                    str += char.ToLower(c);
                }
                else
                {
                    str += c;
                }

            }
            str = str.TrimStart(' ');
            str = char.ToUpper(str[0]) + str.Substring(1);
            return str;
        }
    }
}
