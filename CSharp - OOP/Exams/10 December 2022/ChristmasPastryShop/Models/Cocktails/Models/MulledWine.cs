using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails.Models
{
    public class MulledWine : Cocktail
    {
        private const double mulledWineBasePrice = 13.50;
        public MulledWine(string name, string size) : base(name, size, mulledWineBasePrice)
        {
        }
    }
}
