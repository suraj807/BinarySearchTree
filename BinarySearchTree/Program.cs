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
            Node<int> root = new Node<int>(56); // Creating a root node having data as 56
            BinarySearchTree<int> bst = new BinarySearchTree<int>(root); // Creating object of BinarySearchTree Generic class 
            //calling insert method to add all the element
            bst.Insert(root, 30);
            bst.Insert(root, 70);
            bst.Insert(root, 22);
            bst.Insert(root, 40);
            bst.Insert(root, 60);
            bst.Insert(root, 95);
            bst.Insert(root, 11);
            bst.Insert(root, 65);
            bst.Insert(root, 3);
            bst.Insert(root, 16);
            bst.Insert(root, 63);
            bst.Insert(root, 67);
            Console.WriteLine("Inorder Traversal of given binary tree is : ");
            bst.InOrderTraversal(root); // Calling a method to display tree element in inorder
            bst.TreeSize(); // Calling a method to display tree size
            Console.ReadLine();
        }
    }
}
  
