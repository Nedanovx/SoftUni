using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();
        }
        public string RandomString()
        {
            this.RemoveAt(random.Next(0, Count));
            return this[random.Next(0, Count)];
        }
    }
}
