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
        public void AddList(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} new Node inserted into the LinkedList", data);
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
            Console.WriteLine("{0} new Node inserted into the LinkedList", newnode.data);
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
