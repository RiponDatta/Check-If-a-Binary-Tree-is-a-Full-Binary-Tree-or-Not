﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_is_a_Full_Binary_Tree_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Left = new Node(8);
            tree.Root.Right = new Node(2);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(9);
            tree.Root.Right.Right = new Node(10);
            tree.Root.Right.Right.Right = new Node(16);
            tree.Root.Right.Right.Left = new Node(6);

            var isFullBinaryTree = tree.IsFullBinaryTree();
            Console.WriteLine(isFullBinaryTree);
        }
    }
}
