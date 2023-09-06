namespace Problem01.CircularQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CircularQueue<T> : IAbstractQueue<T>
    {
        private T[] elements;
        private int startIndex;
        private int endIndex;
       public CircularQueue(int capacity = 4)
        {
            this.elements = new T[capacity];
        }
        public int Count { get; private set; }

        public T Dequeue()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var element = elements[this.startIndex];
            this.startIndex = this.startIndex + 1;
            this.Count--;
            return element;
        }

        public void Enqueue(T item)
        {
           if(this.Count >= elements.Length)
            {
                this.Grow();
            }

            this.elements[this.endIndex] = item;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < this.Count; i++)
            {
                yield return this.elements[(this.startIndex + i) % this.elements.Length];
            }
        }

        public T Peek()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return this.elements[this.startIndex];
        }

        public T[] ToArray()
        {
            var newArray = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[(this.startIndex + i) % this.elements.Length];

            }

            return newArray;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void Grow()
        {
           var newArray = new T[this.elements.Length * 2];

            for(int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[(this.startIndex + i) % this.elements.Length];
                
            }
            
            this.elements = newArray;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }
    }
}
