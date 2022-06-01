using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> originalRoot; // Creating a local variable for root
        public int leftCount, rightCount; // Creatinga variable to count left nodes and right nodes
        //Creating a constructor and store the root to local variable
        public BinarySearchTree(Node<T> root)
        {
            originalRoot = root;
        }
        //Creating a method to insert element in tree
        public Node<T> Insert(Node<T> root, T data)
        {
            Node<T> newNode = new Node<T>(data); // Create a new node for new data
            if (root.data.Equals(data)) // If new eleemnt is equal to root then no need to insert
            {
                Console.WriteLine($"{data} is already present in Binary search tree");
                return root;
            }
            else if (data.CompareTo(root.data) < 0) //Checking that new element is less than root data
            {
                if (root.left != null) // If left node of root is not null then make root left node as root and again call the insert method
                {
                    root.left = Insert(root.left, data);
                }
                else // If left node of root is null then add new element at left side of current root
                {
                    root.left = newNode;
                }
            }
            else if (data.CompareTo(root.data) > 0) //Checking that new element is greater than root data
            {
                if (root.right != null) // If right node of root is not null then make root right node as root and again call the insert method
                {
                    root.right = Insert(root.right, data);
                }
                else // If right node of root is null then add new element at right side of current root
                {
                    root.right = newNode;
                }
            }
            return root;
        }
        public void InOrderTraversal(Node<T> root)
        {
            // Inorder traversal - print left->root->right
            if (root.left != null)
            {
                InOrderTraversal(root.left);
                leftCount++;
            }
            Console.Write(root.data + " ");
            if (root.right != null)
            {
                InOrderTraversal(root.right);
                rightCount++;
            }
        }
        //Creating a method to search element in BST
        public Node<T> Search(Node<T> root, T data)
        {
            if (root == null) //If root is null that means element not found
            {
                Console.WriteLine($"\n{data} is not founded in Binary search tree");
                return null;
            }
            if (root.data.Equals(data))//If element is equal to root value that means element founded
            {
                Console.WriteLine($"\n{data} is founded in Binary search tree");
                return root;
            }
            else if (data.CompareTo(root.data) < 0) //Checking that new element is less than root data
            {
                root.left = Search(root.left, data);
            }
            else if (data.CompareTo(root.data) > 0) //Checking that new element is greater than root data
            {
                root.right = Search(root.right, data);
            }
            return root;
        }
        public void TreeSize()
        {
            Console.WriteLine($"\n\nThe size of binary search tree is : {1 + leftCount + rightCount}");
        }
    }
}
