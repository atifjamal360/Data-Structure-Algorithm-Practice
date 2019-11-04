using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class doublyL
    {
        public node start;
        public doublyL()
        {
            start = null;
        }
        public bool isEmpty()
        {
            return start == null;
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
            }
            else
            {
                node p = start;
                Console.Write("List is: ");
                while (p!=null)
                {
                    Console.Write(p.info+" ");
                    p = p.link;
                }
            }
        }
        public void contain()
        {
            int size = 0;
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
            }
            else
            {
                node p = start;
                //Console.Write("List is: ");
                while (p != null)
                {
                    size++;
                    //Console.Write(p.info + " ");
                    p = p.link;
                }
                Console.WriteLine("Size of list is: "+size);
            }
        }
        public void search(int x)
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
            }
            else
            {
                node p = start;
                while (p != null)
                {
                    if (p.info == x)
                    {
                        break;
                    }
                    p = p.link;
                }
                if (p == null)
                {
                    Console.WriteLine(x + " Not found in list.");
                }
                else
                {
                    Console.WriteLine(x + " is present in list.");
                }
            }
        }
        public void insertAtBegin(int x)
        {
            node temp = new node(x);
            temp.link = start;
            start.prev = temp;
            start = temp;
        }
        public void insertAtEnd(int x)
        {
            node temp = new node(x);
            if (isEmpty())
            {
                start = temp;
                return;
            }
            else
            {
                node p = start;
                while (p.link!=null)
                {
                    p = p.link;
                }
                temp.prev = p;
                p.link = temp;
            }
        }
        public void createList()
        {
            int n, data;
            Console.Write("Enter length of list.");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write("Enter element is list: ");
                data = Convert.ToInt32(Console.ReadLine());
                insertAtEnd(data);
            }
        }
        public void insertAfter(int x , int k)
        {
            node temp = new node(x);
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            else
            {
                node p = start;
                while (p != null)
                {
                    if (p.info == k)
                    {
                        break;
                    }
                    p = p.link;
                }
                if (p == null)
                {
                    Console.WriteLine(k + " Not found in List.");
                }
                else
                {
                    temp.prev = p;
                    temp.link = p.link;
                    if (p.link != null)
                        p.link.prev = temp;
                    p.link = temp;
                }
            }
        }
        public void insertBefore(int x, int k)
        {
            node temp = new node(x);
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            if (start.info == k)
            {
                temp.link = start;
                start.prev = temp;
                start = temp;
                return;
            }
            else
            {
                node p = start;
                while (p != null)
                {
                    if (p.info == k)
                    {
                        break;
                    }
                    p = p.link;
                }
                if (p==null)
                {
                    Console.WriteLine(k+" Not found in List.");
                }
                else
                {
                    temp.prev = p.prev;
                    temp.link = p;
                    p.prev.link = temp;
                    p.prev = temp;
                }
            }
        }

    }
}
