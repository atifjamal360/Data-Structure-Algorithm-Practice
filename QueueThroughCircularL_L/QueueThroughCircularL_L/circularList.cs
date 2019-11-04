using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueThroughCircularL_L
{
    class circularList
    {
        node rear;
        public circularList()
        {
            rear = null;
        }
        public bool isEmpty()
        {
            return rear == null;
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
            }
            else
            {
                Console.Write("Queue is: ");
                node p = rear.link;
                do
                {
                    Console.Write(p.info+" ");
                    p = p.link;
                } while (p!=rear.link);
            }
        }
        public void contain()
        {
            int size=0;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
            }
            else
            {
                node p = rear.link;
                do
                {
                    size++;
                    p = p.link;
                } while (p!=rear.link);
                Console.WriteLine("Queue contains "+size+" elements.");
            }
        }
        public void Enqueue(int x)
        {
            node temp = new node(x);
            if (isEmpty())
            {
                rear = temp;
                rear.link = rear;
            }
            else
            {
                temp.link = rear.link;
                rear.link = temp;
                rear = temp;
            }
        }
        public void Dequeue()
        {
            node temp;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            if (rear.link == rear)
            {
                temp = rear;
                rear = null;
            }
            else
            {
                temp = rear.link;
                rear.link = rear.link.link;
            }
            Console.WriteLine("Dequeue element is: "+temp.info);
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("Top(peek) element is: "+rear.link.info);
            }
        }
    }
}
