using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Q7_
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

            public Node GetNode(int position)
            {
                Node current = head;
                int currentPosition = 0;

                while (current != null)
                {
                    if (currentPosition == position)
                    {
                        return current;
                    }
                    current = current.next;
                    currentPosition++;
                }

                return null;
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

            int position = Convert.ToInt32(Console.ReadLine());
            Node node = linkedList.GetNode(position);

                if (node != null)
                {
                    Console.WriteLine("Node at position {0}: {1}", position, node.data);
                }
                else
                {
                    Console.WriteLine("Node not found at position {0}", position);
                }
            }
    }
}
