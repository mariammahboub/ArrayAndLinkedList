using System;
using System.Collections.Generic;
using System.Linq;


namespace LinkedList_Q15_
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

        public int[] convert()
        {
            List<int> list = new List<int>();
            Node current = head;
            while (current != null)
            {
                list.Add(current.data);
                current = current.next;
            }

            return list.ToArray();
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
        linkedList.AddNode(1231);

        foreach (int item in linkedList.convert())
        {
            Console.Write(item + " ");
        }
    }
}
}
