using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueueArray
{
    class circularQueue
    {
        public int[] QueueA;
        public int front;
        public int rear;
        public circularQueue()
        {
            QueueA = new int[5];
            front = -1;
            rear = -1;
        }
        public circularQueue(int size)
        {
            QueueA = new int[size];
            front = -1;
            rear = -1;
        }
        public bool isEmpty()
        {
            return front == -1;
        }
        public bool isFull()
        {
            return ((front == 0 && rear == QueueA.Length-1)|| (front == rear+1));
        }
        public void Enqueue(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is Overflow.");
                return;
            }
            if (isEmpty())
            {
                front = 0;
            }
            if (rear == QueueA.Length-1)
            {
                rear = 0;
            }
            else
	        {
                rear++;
	        }
            QueueA[rear] = x;
        }
        public void Dequeue()
        {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            x = QueueA[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == QueueA.Length-1)
            {
                x = QueueA[front];
                front = 0;
            }
            else
            {
                x = QueueA[front];
                front++;
            }
            Console.WriteLine("Deleted Element is: "+x);
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow");
            }
            else
            {
                Console.WriteLine("Top(peek) element is: "+QueueA[front]);
            }
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            int j;
            if (front<=rear)
            {
                Console.Write("Queue is: ");
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(QueueA[i]+" ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("Queue is: ");
                for (int i = front; i <= QueueA.Length-1; i++)
                {
                    Console.Write(QueueA[i] + " ");
                }
                
                for ( j = 0; j <= rear; j++)
                {
                    Console.Write(QueueA[j]+" ");
                }
                Console.WriteLine();
            }
        }
        public void contain()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            if (isFull())
            {
                Console.WriteLine("Size of Queue is: " + QueueA.Length);
                return;
            }
            int s=0;
            int j;
            if (front <= rear)
            {
                //Console.Write("Queue is: ");
                for (int i = front; i <= rear; i++)
                {
                    s++;
                    //Console.Write(QueueA[i] + " ");
                }
                Console.WriteLine("Size of Queue is: "+s);
            }
            else
            {
                s = 0;
                //Console.Write("Queue is: ");
                for (int i = front; i <= QueueA.Length - 1; i++)
                {
                    s++;
                }

                for (j = 0; j <= rear; j++)
                {
                    s++;
                }
                Console.WriteLine("Size of Queue is: " + s);
            }
        } 
    }
}
