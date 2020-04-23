using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String normal = "Camel cased string";
            String camelCased = MyTextUtil.CamelCase(normal);
            Console.WriteLine(camelCased);
            String unCamelCased = MyTextUtil.UnCamelCased(camelCased);
            Console.WriteLine(unCamelCased);
            Console.ReadKey();
        }
    }
}
