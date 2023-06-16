using System;

namespace LinkedList_Q12_
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

            public void Counter()
            {
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
            linkedList.AddNode(6);

            Console.WriteLine("Length is: ");
            linkedList.Counter();
        }
    }
}
