namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class Tree<T> : IAbstractTree<T>
    {
        private List<Tree<T>> children; 
        public Tree(T key, params Tree<T>[] children)
        {
            this.Key = key;
            this.children = new List<Tree<T>>();
            foreach(var child in children)
            {
                this.AddChild(child);
                child.Parent = this;
            }
        }

        public T Key { get; private set; }

        public Tree<T> Parent { get; private set; }

        public IReadOnlyCollection<Tree<T>> Children => this.children.AsReadOnly();

        public void AddChild(Tree<T> child)
        {
            this.children.Add(child);
        }

        public void AddParent(Tree<T> parent)
        {
            this.Parent = parent;
        }

        public string AsString()
        {
            var sb = new StringBuilder();
            this.DfsAsString(sb, this, 0);
            return sb.ToString().Trim();
        }

        private void DfsAsString(StringBuilder sb, Tree<T>tree, int indent)
        {
            sb.Append(' ', indent)
                .AppendLine(tree.Key.ToString());

            foreach(var child in tree.children)
            {
                this.DfsAsString(sb, child, indent + 2);
            }
        }

        public IEnumerable<T> GetInternalKeys()
        {
            
            return this.BfsWithResultKey(tree => tree.children.Count > 0 && tree.Parent != null).
                Select(tree => tree.Key);
        }

        private IEnumerable<Tree<T>> BfsWithResultKey(Predicate<Tree<T>> predicate)
        {
            var result = new List<Tree<T>>();
            var queue = new Queue<Tree<T>>();

            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                var subtree = queue.Dequeue();

                if (predicate.Invoke(subtree))
                {
                    result.Add(subtree);
                }

                foreach (var child in subtree.children)
                {
                    queue.Enqueue(child); 
                }
            }
            return result;
        }

        public IEnumerable<T> GetLeafKeys()
        {
            return this.BfsWithResultKey(tree => tree.children.Count == 0).
                 Select(tree => tree.Key);
        }

        public T GetDeepestKey()
        {
            return GetDeepestNode().Key;
        }

        private Tree<T> GetDeepestNode()
        {
            var leafs = this.BfsWithResultKey(tree => tree.children.Count == 0);

            Tree<T> deepestNode = null;
            var maxDepth = 0;

            foreach(var leaf in leafs)
            {
                var depth = this.GetDeepth(leaf);

                if(depth > maxDepth)
                {
                    maxDepth = depth;
                    deepestNode = leaf;

                }
            }
            return deepestNode;
        }

        private int GetDeepth(Tree<T> leaf)
        {
            var depth = 0;
            var tree = leaf;
            while(tree.Parent != null)
            {
                depth++;
                tree = tree.Parent;
            }
            return depth;
        }

        public IEnumerable<T> GetLongestPath()
        {
            var path = new Stack<T>();
            var deepestNode = this.GetDeepestNode();
            path.Push(deepestNode.Key);
            while(deepestNode.Parent != null)
            {
                path.Push(deepestNode.Parent.Key);
                deepestNode = deepestNode.Parent;
            }
            return path;
           
        }
    }
}
