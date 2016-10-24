using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 200, 3, 50, 7, 0, -5 };
            LinkedList linkedList = new LinkedList();
            foreach(var digit in array)
            {
                linkedList.AddNode(digit);
            }
            linkedList.AddFirst(500);
            linkedList.InsertAfter(50, -9);
            linkedList.PrintLinkedList();

            Console.Read();
        }
    }

    public class LinkedList
    {
        public Node Head { get; set; }

        public void AddNode(int data)
        {
            if(Head == null)
            {
                Head = new Node(data);
                return;
            }

            Node current = Head;
            while(current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
        }

        public void AddFirst(int data)
        {
            if(Head == null)
            {
                Head = new Node(data);
                return;
            }

            if(Head.Next == null)
            {
                Head.Next = new Node(data);
                return;
            }

            var newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertAfter(int afterValue, int value)
        {
            Node current = Head;
            while(current != null)
            {
                current = current.Next;
                if(current.Data == afterValue)
                {
                    var newNode = new Node(value);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
            }
        }

        public void PrintLinkedList()
        {
            if (Head.Next == null) Console.Write("List is Empty");
            Node current = Head;
            while(current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }

    public class Node
    {
        public int? Data { get; set; }
        public Node Next { get; set; }

        public Node(int? data)
        {
            Data = data;
        }
    }
}
