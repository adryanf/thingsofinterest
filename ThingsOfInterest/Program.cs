using System;
using ThingsOfInterest.DataStructures;

namespace ThingsOfInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var avlTree = new GenericAvlTree<int, string>();

            avlTree.Insert(5,"5");
            avlTree.Insert(3, "3");
            avlTree.Insert(7, "7");
            avlTree.Insert(2, "2"); 
            avlTree.Insert(10, "10");
            avlTree.Insert(8, "8");
            avlTree.Insert(1, "1");
            avlTree.Delete(10);

            foreach (var avlNode in avlTree) {
                Console.WriteLine(avlNode);
            }


            AVL tree = new AVL();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(10);
            tree.Add(8);
            tree.Add(1);
            tree.Delete(10);
            tree.DisplayTree();
        }
    }
}
