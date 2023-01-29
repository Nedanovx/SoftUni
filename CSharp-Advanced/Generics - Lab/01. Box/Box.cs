using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list = new List<T>();
        
        public Box()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Remove()
        {
            T removedItem = list.Last();
            list.RemoveAt(list.Count-1);
            return removedItem;
        }

        public int Count => list.Count;
    }
}
