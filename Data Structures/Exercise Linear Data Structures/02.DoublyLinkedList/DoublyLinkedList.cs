namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public T Value { get; set; }

            public Node(T value)
            {    
                this.Value = value;
            }
        }

        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var node = new Node(item);

            if(this.head == null)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                this.head.Previous = node;
                node.Next = this.head;
                this.head = node;
            }
            this.Count++;
        }

        public void AddLast(T item)
        {
            var node = new Node(item);
            if(this.tail == null)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                node.Previous = this.tail;
                this.tail.Next = node;
                this.tail = node;               
            }
            this.Count++;
        }

        public T GetFirst()
        {
            if(this.head == null)
            {
                throw new InvalidOperationException();
            }

            return this.head.Value;
        }

        public T GetLast()
        {
            if(this.tail == null)
            {
                throw new InvalidOperationException();
            }

            return this.tail.Value;
        }

        public T RemoveFirst()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }
            var node = this.head;
            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newHead = node.Next;
                node.Next = null;
                this.head = newHead;
            }
            this.Count--;
            return node.Value;
        }

        public T RemoveLast()
        {
            if (this.tail == null)
            {
                throw new InvalidOperationException();
            }
            var node = this.tail;
            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var newLastNode = node.Previous;
                newLastNode.Next = null;
                this.tail = newLastNode;
            }
            this.Count--;
            return node.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;
            while(node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}