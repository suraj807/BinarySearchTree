using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node<T>
    {
        public T data; // data variable
        public Node<T> left; // declaring a left node
        public Node<T> right; // declaring a right node
        public Node(T data) // Cratinf constructor havind node data as parameter
        {
            this.data = data;
        }
    }
}
