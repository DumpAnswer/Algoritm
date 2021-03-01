using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static AlgoritmDz2.Node;

namespace AlgoritmDz2
{
    class NodeArganaize : ILinkedList
    {
        public int Count
        {
            get;
            set;
        }
        public Node Startnode
        {
            get;
            set;
        }
        public Node Endnode
        {
            get;
            set;
        }

        
        public void AddNode(int value)
        {
            Node node = new Node { Value = value };
            if (Startnode == null)
            {
                Startnode = node;
            }
            else
            {
                Endnode.NextNode = node;
                node.PrevNode = Endnode;
            }
            Endnode = node;
            Count++;


        }


        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var nextItem = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextItem;

        }
        public void PrintList(Node node)
        {

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.NextNode;
            }
        }
        
        public Node FindNode(int searchValue)
        {
            var findNode = Startnode;
            while (findNode != null)
            {
                if (findNode.Value.Equals(searchValue))

                    return findNode;

                 findNode = findNode.NextNode;

            }
            return null;

        }

        public int GetCount()
        {

            return Count;
        }


        
        public void RemoveNode(int index)
        {
           if(index == 0)
            {
                var newStarNode = Startnode.NextNode;
                Startnode.NextNode = null;
                 
            }
            int current = 0;
            var currentNode = Startnode;
            while (currentNode != null)
            {
                if(current == index - 1) 
                {
                    RemoveNode(currentNode);
                    
                }
                currentNode = currentNode.NextNode;
                current++;
            }
            
           
            
        }
        
        public void RemoveNode(Node node)
        {
            var current = Startnode;
            while (current != null)
            {
                if (current == node)
                {

                    if (current == Endnode)
                    {
                        current.PrevNode.NextNode = null;
                        Endnode = current.PrevNode;
                        Count--;
                        return;
                    }
                    if (current == Startnode)
                    {

                        Startnode = current.NextNode;
                        Count--;
                        return;
                    }
                    if (current == null)
                    {
                        return;
                    }

                    current.PrevNode.NextNode = current.NextNode;
                    current.NextNode.PrevNode = current.PrevNode;

                    Count--;
                    return;
                }
                current = current.NextNode;


            }
        }

    }
}

