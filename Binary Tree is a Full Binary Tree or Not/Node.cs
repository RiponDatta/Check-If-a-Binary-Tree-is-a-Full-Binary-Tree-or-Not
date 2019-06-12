using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_is_a_Full_Binary_Tree_or_Not
{
    public class Node
    {
        public int Data;
        public Node Left, Right;

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
