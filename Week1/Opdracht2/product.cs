using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    class product
    {
        public product (string name, double priceInDollars)
        {
            Name = name;
            PriceInDollars = priceInDollars;
        }

        public string Name { get; set; }
        public double PriceInDollars { get; private set; }
        public double PriceInEuros
        {
            get
            {
                return 0.75 * PriceInDollars;
            }
        }
    }
}
