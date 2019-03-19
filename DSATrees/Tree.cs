using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trees
{
    class Tree
    {
        public TreeNode root; 
        
        public TreeNode insert(TreeNode Current, int val)
        {
            if (Current == null)
            {
                Current = new TreeNode();
                Current.Val = val;
                if (root == null) root = Current;
                return Current;
            }
        
            else if (val <= Current.Val)
            {
                Current.left = insert(Current.left, val);
            }
            else
            {
                Current.right = insert(Current.right, val);
            }
            return Current;
        }
        
        public void treePrint(TreeNode node)
        {
            if (node != null)
                treePrint(node.left);
            if(node != null)
            System.Console.WriteLine("{0}", node.Val);
            if(node != null)
            treePrint(node.right);
            
        }    

        public TreeNode Find(TreeNode Node, int val)
        {
            if(Node == null)
                return null;
            if (Node.Val == val)
                return Node;
            else if (val <= Node.Val)
                return(Find(Node.left, val));
            else
                return(Find(Node.right, val));
        }
    }
    


    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int Val;
    }
}
