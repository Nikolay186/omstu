using System;

namespace LW2
{
    public class Node
    {
        public Node leftChild;
        public Node rightChild;
        public string Value { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int Release { get; set; }
        public int Count { get; set; }

        public void PrintNode()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Release Year: " + Release);
            Console.WriteLine("Quantity: " + Count);
        } 

        public void SetValue(string value, int id, string auth, string name, int rel, int count)
        {
            this.Value = value;
            this.Id = id;
            this.Author = auth;
            this.Name = name;
            this.Release = rel;
            this.Count = count;
        }

        public Node GetLeftChild()
        {
            return this.leftChild;
        }

        public void SetLeftChild(Node leftChild)
        {
            this.leftChild = leftChild;
        }

        public Node GetRightChild()
        {
            return this.rightChild;
        }

        public void SetRightChild(Node rightChild)
        {
            this.rightChild = rightChild;
        }

        public override string ToString()
        {
            return $"Node:\n" +
                $"Value = {Value}\n" +
                $"LC = {leftChild}" +
                $"RC = {rightChild}";
        }
    } 
}
