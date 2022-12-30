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
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Inserted into Linked List :  {0}", node.data);
        }

        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node temp = head;
            if (position < 1)
            {
                Console.WriteLine("Invalid Data");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        var node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position Out of Range");
                }
            }
            return head;
        }
        internal Node DeleteFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            return head;
        }
        public int DeleteLastNode()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("LinkedList id empty");
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            int delNode = temp.next.data;
            temp.next = null;
            return delNode;
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
        internal Node Search(int value)
        {
            int Count = 1;
            while (head != null)
            {
                if (head.data == value)
                {
                    Console.WriteLine($"\n The Value is {value} at {Count} position");
                    return head;
                }
                head = head.next;
                Count++;
            }
            return null;
        }

    }
}