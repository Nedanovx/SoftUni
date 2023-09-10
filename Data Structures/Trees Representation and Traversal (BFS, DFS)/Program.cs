using System;

namespace Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subtree = new Tree<int>(36,
                            new Tree<int>(42),
                            new Tree<int>(3)
                            );

            var tree = new Tree<int>(34,
                        subtree,
                        new Tree<int>(1,
                        new Tree<int> (8)),
                        new Tree<int>(5)
                );

            Console.WriteLine(string.Join(", ", tree.OrderDfs()));
            tree.Swap(36, 1);
            Console.WriteLine(string.Join(", ", tree.OrderDfs()));
        }
    }
}
