using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public int ComparisonMethod(T comparison) => Items.Count(x => x.CompareTo(comparison) > 0);
    }
}
