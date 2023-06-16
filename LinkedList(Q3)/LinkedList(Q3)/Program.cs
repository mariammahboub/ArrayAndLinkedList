using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Q3_
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
        public int count = 0;


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
count++;

            }

            public void DisplayList()
{
    Node current = head;
    while (current != null)
    {
        Console.Write(current.data + " ");
        current = current.next;
    }
    Console.WriteLine();
    Console.WriteLine(count);

}
        }

        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);
            linkedList.AddNode(7);
            linkedList.AddNode(9);



            Console.WriteLine("Singly Linked List:");
            linkedList.DisplayList();
        }
    }



}
