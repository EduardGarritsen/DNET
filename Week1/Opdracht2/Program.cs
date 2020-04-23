using System;

namespace Opdracht2
{
    class Opdracht2
    {
        static void Main(string[] args)
        {
            product p2 = new product("iPad1", 499.0);
            product p1 = new product("iPad2", 89.0);
            product[] products = { p1, p2 };
            foreach (product p in products)
            {
                Console.WriteLine("Product: {0} kost {1} euro en {2} dollar",
                    p.Name, p.PriceInEuros, p.PriceInDollars);
            }
            Console.ReadKey();
        }
    }
}
