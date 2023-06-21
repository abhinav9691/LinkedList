using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedList1
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                //Console.WriteLine("{0} new Node inserted into LinkedList", data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("{0} new Node inserted into LinkedList", newnode.data);
        }

        public void AddList(int data)

        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} new Node inserted into LinkedList", newnode.data);
        }

        public void Append(int data)
        {
            AddLast(data);
        }

        public void InsertBetween(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;

            if (position < 1)
            {
                Console.WriteLine("Position sholud be greater");
            }
            else if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                {
                    Node temp = new Node(data);
                    temp = this.head;
                    while (position > 2)
                    {
                        temp = temp.next;
                        position--;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }

        }

        public void DeleteFirst()
        {
            if (head == null)
                Console.WriteLine("Linked List is Empty");
            else
            {
                Node temp = head;
                head = temp.next;
                Console.WriteLine("Removed {0} from Linked List", temp.data);
            }
        }


        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }

            }
        }
    }
}
