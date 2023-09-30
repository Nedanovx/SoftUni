namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerTree : Tree<int>, IIntegerTree
    {
        public IntegerTree(int key, params Tree<int>[] children)
            : base(key, children)
        {
        }

        public IEnumerable<IEnumerable<int>> GetPathsWithGivenSum(int sum)
        {
            var result = new List<List<int>>();
            var currentPath = new LinkedList<int>();
            currentPath.AddFirst(this.Key);
            int currentSum = this.Key;
            this.Dfs(this, result, currentPath, ref currentSum, sum);
            return result;

        }

        private void Dfs(Tree<int> integerTree, List<List<int>> result, LinkedList<int> currentPath, ref int currentSum, int wantedSum)
        {
            foreach(var child in integerTree.Children)
            {
                currentSum += child.Key;
                currentPath.AddLast(child.Key);
                this.Dfs(child, result, currentPath,ref currentSum, wantedSum);
            }
            if(currentSum == wantedSum)
            {
                result.Add(new List<int> (currentPath));
            }
            currentSum -= integerTree.Key;
            currentPath.RemoveLast();
        }

        public IEnumerable<Tree<int>> GetSubtreesWithGivenSum(int sum)
        {
            var roots = new List<Tree<int>>();
            SubTreeSumDfs(this, sum, roots);
            return roots;
        }

        private int SubTreeSumDfs(IntegerTree node, int targetSum, List<Tree<int>> roots)
        {
            var currentSum = Convert.ToInt32(node.Key);

            foreach(var child in node.Children)
            {
                currentSum += SubTreeSumDfs ((IntegerTree)child, targetSum, roots);
            }

            if(currentSum == targetSum)
            {
                roots.Add(node);
                
            }
            return currentSum;
        }
    }
}
