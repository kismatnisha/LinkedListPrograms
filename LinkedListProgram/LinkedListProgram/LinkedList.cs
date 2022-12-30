using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
  
        internal class LinkedList
        {
            internal Node head;
            internal void AddLast(int data)
            {
                Node Node = new Node(data);
                if (this.head == null)
                {
                    this.head = Node;
                }
                else
                {
                    Node temp = this.head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = Node;
                }
                Console.WriteLine("{0} is inserted into LinkedList", Node.data);
            }
            internal void AddFirst(int data)
            {
                Node Node = new Node(data);
                Node.next = this.head;
                this.head = Node;
                Console.WriteLine("{0} is inserted into LinkedList", Node.data);
            }
            public void Display()
            {
                Console.WriteLine("Displaying Nodes:");
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("LinkedList is Empty");
                    return;
                }
                else
                {
                    while (temp != null)
                    {
                        Console.Write(" " + temp.data + " ");
                        temp = temp.next;
                    }
                }
            }
        }
    }