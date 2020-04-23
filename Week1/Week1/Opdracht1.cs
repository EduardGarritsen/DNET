using System;

namespace Opdracht1
{
    class Opdracht1
    {
        static void Main(string[] args)
        {
            String normal = "Camel cased string";
            String camelCased = MyTextUtil.CamelCase(normal);
            Console.WriteLine(camelCased);
            String UnCamelCased = MyTextUtil.UnCamelCased(camelCased);
            Console.WriteLine(UnCamelCased);
            Console.ReadKey();
        }
    }
}
