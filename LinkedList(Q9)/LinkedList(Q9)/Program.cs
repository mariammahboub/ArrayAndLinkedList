using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Q9_
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
            public bool check()
{

    if (head == null)
    {
        Console.WriteLine("empty");
        return true;
    }
    else
    {
        Console.WriteLine(" not empty");

        return false;
    }
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

            linkedList.check();
            int position = Convert.ToInt32(Console.ReadLine());



        }

    }
}
