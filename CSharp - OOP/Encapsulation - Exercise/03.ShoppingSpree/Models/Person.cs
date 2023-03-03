﻿namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public string Add(Product product)
        {
            if(Money < product.Price)
            {
                return($"{Name} can't afford {product}");
            }                  
                products.Add(product);

                Money -= product.Price;

                return $"{Name} bought {product}";
            

        }
        public override string ToString()
        {
            string productsToString = products.Any()
                ? string.Join(", ", products)
                : "Nothing bought";
            return $"{Name} - {productsToString}";
        }
    }
}
