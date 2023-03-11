﻿using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Food
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity {get; private set;}
    }
}
