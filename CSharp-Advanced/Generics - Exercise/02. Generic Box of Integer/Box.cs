using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofInteger
{
    public class Box<T>
    {
        public Box()
        {
           this.List = new List<T>();
        }
        public List<T> List { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in List)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }
    }
}
