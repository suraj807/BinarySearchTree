using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(56);
            BinarySearchTree<int> bst = new BinarySearchTree<int>(root);
            bst.Insert(30);
            bst.Insert(70);
            Console.WriteLine("Inorder Traversal of given binary tree is : ");
            bst.InOrderTraversal(root);
            bst.TreeSize();
            Console.ReadLine();
        }
    }
}
