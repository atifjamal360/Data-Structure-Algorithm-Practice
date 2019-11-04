using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementationOfQueue
{
    class QueueL
    {
        private node front,rear;
        public QueueL()
        {
            front = null;
            rear = null;
        }
        public bool isEmpty()
        {
            return front == null;
        }
        public bool isFull()
        {
            return (front != null);
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            else
            {
                node p = front;
                Console.Write("Queue is: ");
                while (p!=null)
                {
                    Console.Write(p.info+" ");
                    p = p.link;
                }
                Console.WriteLine();
            }
        }
        public void Enqueue(int x)
        {
            node temp = new node(x);
            if (isEmpty())
            {
                temp.link = front;
                front = temp;
                rear = temp;
            }
            else
            {
                rear.link = temp;
                rear = temp;
            }
        }
        public void Dequeue()
        {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
            }
            else
            {
                x = front.info;
                front = front.link;
                Console.WriteLine("Dequeue Element is: "+x);
            }
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
            }
            else
            {
                Console.WriteLine("Top(peek) element is: "+front.info);
            }
        }
        public void contain()
        {
            int size = 0;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
            }
            node p = front;
            while (p != null)
            {
                size++;
                p = p.link;
            }
            Console.WriteLine("Size of Queue is: " + size);
        }
    }
}
