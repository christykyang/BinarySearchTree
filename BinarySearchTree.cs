using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BinarySearchTree
    {
        //member variables (HAS A)
        Node rootNode;
        bool searchNodeExists;

        //constructor (SPAWNER)
        public BinarySearchTree()
        {
            rootNode = new Node();
            searchNodeExists = false;
        }

        //member methods (CAN DO)
        public void Add(Node node)
        {
            Add(node, rootNode);
        }
        public void Add(Node node, Node tempNode)
        {
            //root null?

            if (node.DataType >= tempNode.DataType)
            {
                if (tempNode.rightLink == null)
                {
                    tempNode.rightLink = node;
                    return;
                }
                else
                {
                    tempNode = tempNode.rightLink;
                    Add(node, tempNode);
                }
                
            }
            else //if (node.DataType <= rootNode.DataType)
            {
                if (tempNode.leftLink == null)
                {
                    tempNode.leftLink = node;
                    return;
                }
                else
                {
                    tempNode = tempNode.leftLink;
                    Add(node, tempNode);
                }
            }
        }
        public void Search(Node node, Node searchNode)
        {
            if (node == searchNode)
            {
                searchNodeExists = true;
            }
            else if (node.DataType >= searchNode.DataType)
            {
                searchNode = searchNode.rightLink;
                Search(node, searchNode);
            }
            else if (node.DataType <= searchNode.DataType)
            {
                searchNode = searchNode.leftLink;
                Search(node, searchNode);
            }
            else
            {
                searchNodeExists = false;
            }
        }
    }
}
