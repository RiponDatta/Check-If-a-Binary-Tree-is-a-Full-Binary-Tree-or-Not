using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_is_a_Full_Binary_Tree_or_Not
{
    public class BinaryTree
    {
        public Node Root;

        public bool IsFullBinaryTree()
        {
            return IsFullBinaryTree(Root);
        }

        private bool IsFullBinaryTree(Node node)
        {
            if(node == null)
            {
                return true;
            }

            if(node.Left == null && node.Right == null)
            {
                return true;
            }

            if(node.Left != null && node.Right != null)
            {
                return IsFullBinaryTree(node.Left) && IsFullBinaryTree(node.Right);
            }

            return false;
        }
    }
}
