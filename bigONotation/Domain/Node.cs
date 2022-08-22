using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bigONotation.Domain
{
    public class Node
    {
        public int value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int value)
        {
            this.value = value;
        }
    }
    public class BinarySearchTree
    {
        public static Node Insert(Node root, int value)
        {
            if (root.value == value)
            {
                return root;
            }else if (value < root.value)
            {
                if (root.left != null)
                {
                    root.left = Insert(root.left, value);
                }
                else
                {
                    Node newNode = new Node(value);
                    root.left = newNode;
                }
            }
            else if (value > root.value)
            {
                if (root.right != null)
                {
                    root.right = Insert(root.right, value);
                }
                else
                {
                    Node newNode = new Node(value);
                    root.right = newNode;
                }
            }

            return root;
        }

        public static Node Search(Node root, int value)
        {
            if (root.value == value)
            {
                return root;
            }
            else if (value < root.value)
            {
                root = Search(root.left, value);
            }
            else if (value > root.value)
            {
                root = Search(root.right, value);
            }
            return root;
        }
    }
}