using System;
using System.Collections;

namespace LW2
{
    public class BTree
    {
        private Node rootNode;

        public BTree()
        {
            rootNode = null;
        }

        public Node FindNodeByValue(int rel)
        {
            Node currentNode = rootNode;
            while (currentNode.Release.CompareTo(rel) != 0)
            {
                if (rel.CompareTo(currentNode.Release) < 0)
                {
                    currentNode = currentNode.GetLeftChild();
                }
                else
                { 
                    currentNode = currentNode.GetRightChild();
                }
                if (currentNode == null)
                {
                    return null;
                }
            }
            return currentNode;
        }
        public void InsertNode(string value, int id, string auth, string name, int yr, int count)
        {
            Node newNode = new Node();
            newNode.SetValue(value, id, auth, name, yr, count);
            if (rootNode == null)
            {
                rootNode = newNode;
            }
            else
            {
                Node currentNode = rootNode;
                Node parentNode;
                while (true)
                {
                    parentNode = currentNode;
                    if (value == currentNode.Value)
                    {
                        return;
                    }
                    else if (yr.CompareTo(currentNode.Release) < 0)
                    {
                        currentNode = currentNode.GetLeftChild();
                        if (currentNode == null)
                        {
                            parentNode.SetLeftChild(newNode);
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.GetRightChild();
                        if (currentNode == null)
                        { 
                            parentNode.SetRightChild(newNode);
                            return;
                        }
                    }
                }
            }
        }
        public Node GetRootNode()
        {
            Node node;
            node = rootNode;
            return node;
        }

        public void PrintTree()
        {
            Stack globalStack = new Stack();
            globalStack.Push(rootNode);
            int gaps = 32;
            bool isRowEmpty = false;
            string separator = "-----------------------------------------";
            Console.WriteLine(separator);
            while (isRowEmpty == false)
            {
                Stack localStack = new Stack();
                isRowEmpty = true;

                for (int j = 0; j < gaps; j++)
                    Console.Write(' ');
                while (globalStack.Count != 0)
                {
                    Node temp = (Node)globalStack.Pop();
                    if (temp != null)
                    {
                        Console.Write(temp.Release);
                        localStack.Push(temp.GetLeftChild());
                        localStack.Push(temp.GetRightChild());
                        if (temp.GetLeftChild() != null ||
                                temp.GetRightChild() != null)
                            isRowEmpty = false;
                    }
                    else
                    {
                        Console.Write("__");
                        localStack.Push(null);
                        localStack.Push(null);
                    }
                    for (int j = 0; j < gaps * 2 - 2; j++)
                        Console.Write(' ');
                }
                Console.WriteLine();
                gaps /= 2;
                while (localStack.Count != 0)
                    globalStack.Push(localStack.Pop());
            }
            Console.WriteLine(separator);
        }
        public bool DeleteNode(string value)
        {
            Node currentNode = rootNode;
            Node parentNode = rootNode;
            bool isLeftChild = true;
            while (currentNode.Value.CompareTo(value) != 0)
            {
                parentNode = currentNode;
                if (value.CompareTo(currentNode.Value) < 0)
                {
                    isLeftChild = true;
                    currentNode = currentNode.GetLeftChild();
                }
                else
                {
                    isLeftChild = false;
                    currentNode = currentNode.GetRightChild();
                }
                if (currentNode == null)
                    return false;
            }

            if (currentNode.GetLeftChild() == null && currentNode.GetRightChild() == null)
            {
                if (currentNode == rootNode)
                    rootNode = null;
                else if (isLeftChild)
                    parentNode.SetLeftChild(null);
                else
                    parentNode.SetRightChild(null);
            }
            else if (currentNode.GetRightChild() == null)
            {
                if (currentNode == rootNode)
                    rootNode = currentNode.GetLeftChild();
                else if (isLeftChild)
                    parentNode.SetLeftChild(currentNode.GetLeftChild());
                else
                    parentNode.SetRightChild(currentNode.GetLeftChild());
            }
            else if (currentNode.GetLeftChild() == null)
            {
                if (currentNode == rootNode)
                    rootNode = currentNode.GetRightChild();
                else if (isLeftChild)
                    parentNode.SetLeftChild(currentNode.GetRightChild());
                else
                    parentNode.SetRightChild(currentNode.GetRightChild());
            }
            else
            {
                Node ancestor = ReceiveAncestor(currentNode);
                if (currentNode == rootNode)
                    rootNode = ancestor;
                else if (isLeftChild)
                    parentNode.SetLeftChild(ancestor);
                else
                    parentNode.SetRightChild(ancestor);
            }
            return true;
        }

        private Node ReceiveAncestor(Node node)
        {
            Node parentNode = node;
            Node ancestorNode = node;
            Node currentNode = node.GetRightChild();
            while (currentNode != null)
            {
                parentNode = ancestorNode;
                ancestorNode = currentNode;
                currentNode = currentNode.GetLeftChild();
            }
            
            if (ancestorNode != node.GetRightChild())
            {
                parentNode.SetLeftChild(ancestorNode.GetRightChild());
                ancestorNode.SetRightChild(node.GetRightChild());
            }
            return ancestorNode;
        }
        public void Print(Node startNode)
        {
            if (startNode != null)
            {
                Print(startNode.leftChild);
                startNode.PrintNode();
                Print(startNode.rightChild);
            }
        }
    }
}
