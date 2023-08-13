using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories.Models
{
    public class CocktailRepository : IRepository<ICocktail>
    {
        private List<ICocktail> cocktails;

        public CocktailRepository()
        {
            this.cocktails = new List<ICocktail>();
        }

        public IReadOnlyCollection<ICocktail> Models => this.cocktails;

        public void AddModel(ICocktail model)
        {
            this.cocktails.Add(model);
        }
    }
}
