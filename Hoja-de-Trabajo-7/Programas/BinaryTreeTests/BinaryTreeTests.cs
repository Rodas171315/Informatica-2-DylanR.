using System;
using Xunit;

namespace BinaryTreeTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void TestSumar()
        {
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

            Assert.Equal(51, sut.Sumar());            
        }

        [Fact]
        public void TestInsert()
        {
            IBinTree sut = new BinaryTree(100);
            sut.Insert(95);
            sut.Insert(85);
            sut.Insert(75);
            sut.Insert(65);
            sut.Insert(55);
            sut.Insert(45);
            sut.Insert(35);
            sut.Insert(25);
            sut.Insert(15);
            sut.Insert(5);

            int[] result = sut.ToArray();

            Assert.Equal(new int[] { 5,15,25,35,45,55,65,75,85,95,100 }, result);
        }
    }
}
