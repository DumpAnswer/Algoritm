using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dz4Task2.TreeNode;

namespace Dz4Task2
{
    class Tree : ITree
    {
        public int Count { get; set; }
        public TreeNode _head { get; set; }
        
       
       
        public void AddItem(int value)
        {
            TreeNode treeNode = new TreeNode { Value = value };
            if (_head == null)
            {
                _head = treeNode;
            }
            else
            {
                AddNextTree(_head, value);
            }
            Count++;
        }
        public void AddNextTree(TreeNode node, int value)
        {
            var newKnot = new TreeNode { Value = value };
            var nextTree = _head;
            if (nextTree.Value > newKnot.Value)
            {
                if(node.LeftChild == null)
                {
                    node.LeftChild = newKnot;
                }
                else
                {
                    AddNextTree(node.LeftChild, value);
                }
            }
            else 
            {
             if(node.RightChild == null)
                {
                    node.RightChild = newKnot;
                }
                else
                {
                    AddNextTree(node.RightChild, value);
                }
            }
            

        }

        public TreeNode GetNodeByValue(int value)
        {
            
            TreeNode findTree = new TreeNode { Value = value };
            
            var parrent = _head;

            while (parrent != null)
            {
                int result = parrent.Value;
                if (result > findTree.Value)
                {
                    findTree = parrent;
                    parrent = findTree.LeftChild;
                }
                else if (result < findTree.Value)
                {
                    findTree = parrent;
                    parrent = findTree.RightChild;
                }
                else
                    break;
                }
            return findTree;
            }
        
        

        public TreeNode GetRoot()
        {
            TreeNode getTree = new TreeNode();
            getTree = _head;
            return getTree;
        }

     


        public void PrintTree()
        {
           
        }
      

        public void RemoveItem(int value)
        {
            TreeNode parent = new TreeNode { Value = value };
           var current = GetNodeByValue(value);
            if (current == null)
            {
                return;
            }
            Count--;
            if (current.RightChild == null)
            {

                if (parent == null)
                {
                    _head = current.LeftChild;
                }
                else
                {
                    int result = parent.Value;
                    if (result < current.Value)
                    {
                        parent.LeftChild = current.LeftChild;
                    }
                    else if (result > current.Value)
                    {
                        parent.RightChild = current.LeftChild;
                    }
                }
            }
            else if (current.RightChild.LeftChild == null)
            {
                current.RightChild = current.LeftChild;

                if (parent == null)
                {
                    _head = current.RightChild;
                }
                else
                {
                    int result = parent.Value;
                    if (result < current.Value)
                    {
                        parent.LeftChild = current.RightChild;
                    }
                    else if (result > current.Value)
                    {
                        parent.RightChild = current.RightChild;
                    }


                }
            }
            else
            {
                TreeNode leftMost = current.RightChild.LeftChild;
                TreeNode leftMostParent = current.RightChild;
                while (leftMost.LeftChild == null)
                {
                    leftMostParent = leftMost;
                    leftMost = leftMost.LeftChild;
                }
                leftMostParent.LeftChild = leftMost.RightChild;
                leftMost.LeftChild = current.LeftChild;
                leftMost.RightChild = current.RightChild;
                if (parent == null)
                {
                    _head = leftMost;
                }
                else
                {
                    int result = parent.Value;
                    if (result < current.Value)
                    {
                        parent.LeftChild = leftMost;
                    }
                    else if(result >current.Value)
                    {
                        parent.RightChild = leftMost;
                    }
                }
            }
            
            
            
        } 

        
    }

}
