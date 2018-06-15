using System;
using ThingsOfInterest.DataStructures;

namespace ThingsOfInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            var gavlTree = new GenericAvlTree<int, string>();

            gavlTree.Insert(5,"5");
            gavlTree.Insert(3, "3");
            gavlTree.Insert(7, "7");
            gavlTree.Insert(2, "2");
            gavlTree.Insert(10, "10");
            gavlTree.Insert(8, "8");
            gavlTree.Insert(1, "1");
            gavlTree.Delete(10);

            foreach (var avlNode in gavlTree) {
                Console.WriteLine(avlNode);
            }


            AVL avlTree = new AVL();
            avlTree.Add(5);
            avlTree.Add(3);
            avlTree.Add(7);
            avlTree.Add(2);
            avlTree.Add(10);
            avlTree.Add(8);
            avlTree.Add(1);
            avlTree.Delete(10);
            avlTree.DisplayTree();

            RedBlackTree rbTree = new RedBlackTree();
            rbTree.Insert(5);
            rbTree.Insert(3);
            rbTree.Insert(7);
            rbTree.Insert(1);
            rbTree.Insert(9);
            rbTree.Insert(-1);
            rbTree.Insert(11);
            rbTree.Insert(6);
            rbTree.DisplayTree();
            rbTree.Delete(-1);
            rbTree.DisplayTree();
            rbTree.Delete(9);
            rbTree.DisplayTree();
            rbTree.Delete(5);
            rbTree.DisplayTree();

            Console.ReadLine();

        }
    }
}
