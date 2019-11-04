using System;

namespace priorityQuene
{
    class PriorityQ
    {
        public node front;
        public PriorityQ()
        {
            front = null;
        }
        public bool isEmpty()
        {
            return (front == null);
        }
        public void insert(int i,int priority)
        {
            node temp = new node(i, priority);
            if (isEmpty()|| priority<front.priority)
            {
                temp.link = front;
                front = temp;
            }
            else
            {
                node p = front;
                while(p.link != null && p.link.priority <= priority)
                {
                    p = p.link;
                }
                temp.link = p.link;
                p.link = temp;
            }
        }
        public void delete()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is underflow");
                return;
            }
            else
            {
                Console.WriteLine("Delete element is:"+front.info);
                front = front.link;
            }
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue in underflow.");
                return;
            }
            else
            {
                node p = front;
                Console.WriteLine("Queue is:");
                while (p!=null)
                {
                    Console.WriteLine(p.info+"  "+p.priority);
                    p = p.link;
                }
            }
            Console.WriteLine();
        }
    }
}
