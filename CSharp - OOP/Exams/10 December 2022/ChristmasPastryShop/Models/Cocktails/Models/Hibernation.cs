using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails.Models
{
    public class Hibernation : Cocktail
    {
        private const double hibernationBasePrice = 10.50;
        public Hibernation(string name, string size) : base(name, size, hibernationBasePrice)
        {
        }
    }
}
