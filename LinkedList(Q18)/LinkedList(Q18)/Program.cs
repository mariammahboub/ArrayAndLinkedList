using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Q18_
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

            public void check(int value)
            {
                bool flag = false;
                Node current = head;
                while (current != null)
                {
                    if (current.data == value)
                    {
                        flag = true;
                    }
                    current = current.next;
                }
                if (flag)
                {
                    Console.WriteLine("item found");

                }
                else
                    Console.WriteLine("item not  found");


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
            Console.Write("enter value :");
            int value = Convert.ToInt32(Console.ReadLine());
            linkedList.check(value);
        }
    }
}
