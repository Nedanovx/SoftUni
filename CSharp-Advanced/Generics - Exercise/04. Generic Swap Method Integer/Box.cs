using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        public Box()
        {
            this.Item = new List<T>();
        }
        public List<T> Item { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            T item = this.Item[firstIndex];
            Item[firstIndex] = Item[secondIndex];
            Item[secondIndex] = item;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Item)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }

    }
}
