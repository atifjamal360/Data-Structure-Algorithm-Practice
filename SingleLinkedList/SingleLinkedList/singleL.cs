using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class singleL
    {
        public node start;
        public singleL()
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
                while (p != null)
                {
                    Console.Write(p.info + " ");
                    p = p.link;
                }
            }
            Console.WriteLine();
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
                Console.WriteLine("Size of list is: " + size);
            }
        }
        public void search(int x)
        {
            node p = start;
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
            }
            else
            {
                while (p != null)
                {
                    if (p.info == x)
                    {
                        break;
                    }
                    p = p.link;
                }
            }
            if (p == null)
            {
                Console.WriteLine(x + " Not found in list.");
            }
            else
            {
                Console.WriteLine(x + " present in list.");
            }
        }
        public void insertAtBegin(int x)
        {
            node temp = new node(x);
            temp.link = start;
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
                while (p.link != null)
                {
                    p = p.link;
                }
                p.link = temp;
            }
        }
        public void createList()
        {
            int n, data;
            Console.Write("Enter Size of list: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element in list: ");
                data = Convert.ToInt32(Console.ReadLine());
                insertAtEnd(data);
            }
        }
        public void insertAfter(int x, int k)
        {
            node temp = new node(x);
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
                Console.WriteLine(x + " Not found in list.");
            }
            else
            {
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void insertBefore(int x, int k)
        {
            node temp = new node(x);
            if (isEmpty())
            {
                Console.WriteLine("list is empty.");
                return;
            }
            if (x == start.info)
            {
                temp.link = start;
                start = temp;
                return;
            }
            node p = start;
            while (p.link != null)
            {
                if (p.link.info == k)
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
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void insertAtPosition(int x, int k)
        {
            node temp = new node(x);
            if (k == 1)
            {
                temp.link = start;
                start = temp;
            }
            else
            {
                int i;
                node p = start;
                for (i = 1; i < k - 1 && p != null; i++)
                {
                    p = p.link;
                }
                if (p == null)
                {
                    Console.WriteLine("you can insert only upto " + i + "th position.");
                }
                else
                {
                    temp.link = p.link;
                    p.link = temp;
                }
            }
        }
        public void deleteFirstNode()
        {
            if (isEmpty())
            {
                return;
            }
            start = start.link;
        }
        public void deleteLastNode()
        {
            if (isEmpty())
            {
                return;
            }
            if (start.link == null)
            {
                start = null;
            }
            else
            {
                node p = start;
                while (p.link.link != null)
                {
                    p = p.link;
                }
                p.link = null;
            }
        }
        public void deleteNode(int x)
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            if (start.info == x)
            {
                if (start.link==null)
                {
                    start = null;
                }
                else
                {
                    start = start.link;
                }
            }
            node p = start;
            while (p.link!=null)
            {
                if (p.link.info == x)
                {
                    break;
                }
                p = p.link;
            }
            if (p.link==null)
            {
                Console.WriteLine(x+" Not found in list.");
            }
            else
            {
                p.link = p.link.link;
            }
        }
        public void sortData()
        {
            node p, q, end;
            int temp;
            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info>q.info)
                    {
                        temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Data is:");
            p = start;
                Console.Write("List is: ");
                while (p != null)
                {
                    Console.Write(p.info + " ");
                    p = p.link;
                }
            Console.WriteLine();
        }
    }
}
