using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Q2_
{
    internal class Program
    {


        public class Node
        {
            public int data;
            public Node next;

            public Node(int value)
        {
            data = value;
            next = null;
        }
    }

    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void AddNode(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
    current.next = newNode;
                }
            }

            public void DisplayReverse()
{
    ReversePrint(head);
}

private void ReversePrint(Node node)
{
    if (node == null)
        return;

    ReversePrint(node.next);
    Console.Write(node.data + " ");
}
    }


    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        // Add nodes to the linked list
        linkedList.AddNode(1);
        linkedList.AddNode(2);
        linkedList.AddNode(3);
        linkedList.AddNode(4);
        linkedList.AddNode(5);

        Console.WriteLine("Singly Linked List (Reverse Order):");
        linkedList.DisplayReverse();
    }
}
    }

