using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IBinTree sut = new BinaryTree(
                2,
                new BinaryTree(
                    5,
                    new BinaryTree(
                        9,
                        new BinaryTree(4),
                        null
                    ),
                    null
                ),
                new BinaryTree(
                    7,
                    new BinaryTree(2),
                    new BinaryTree(
                        6,
                        new BinaryTree(5),
                        new BinaryTree(11)
                    )
                )
            );

            Console.WriteLine(bTree);
            Console.WriteLine(bTree.Sumar());                        
        }
    }
}
