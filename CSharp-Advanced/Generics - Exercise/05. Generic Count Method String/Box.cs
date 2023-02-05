using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public int ComparisonMethod(T comparingItem)
        {
            int count =0;
            foreach(T item in Items)
            {
                if(item.CompareTo(comparingItem) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
