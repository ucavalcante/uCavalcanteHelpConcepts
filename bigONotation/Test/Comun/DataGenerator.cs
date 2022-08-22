using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bigONotation.Domain;

namespace bigONotation.Test.Comun
{
    public static class DataGenerator
    {
        public static int[] GetInts()
        {
            var result = new int[] { 1, 2, 3 };
            return result;
        }
        public static Node DefaultTree()
        {
            Node root = new Node(30);
            Node n1 = new Node(15);
            Node n2 = new Node(45);
            Node n3 = new Node(6);
            Node n4 = new Node(41);
            Node n5 = new Node(54);
            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n2.left = n4;
            n2.right = n5;
            return root;
        }
    }
}