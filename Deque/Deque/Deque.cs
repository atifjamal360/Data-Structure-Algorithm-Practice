using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    class Deque
    {
        public int[] DequeA;
        public int front;
        public int rear;
        public Deque(int size)
        {
            DequeA = new int[size];
            front = -1;
            rear = -1;
        }
        public bool isEmpty()
        {
            return front == -1;
        }
        public bool isFull()
        {
            return ((front == 0 && rear == DequeA.Length - 1) || front == rear + 1);
        }
        public void insertRear(int x)
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
            if (rear == DequeA.Length-1)
            {
                rear = 0;
            }
            else
            {
                rear++;
            }
            DequeA[rear] = x;
        }
        public void insertFront(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is Overflow.");
                return;
            }
            if (isEmpty())
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
            {
                front = DequeA.Length - 1;
            }
            else
            {
                front--;
            }
            DequeA[front] = x;
        }
        public void deleteFront()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            int temp = DequeA[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == DequeA.Length-1)
            {
                front = 0;
            }
            else
            {
                front++;
            }
            Console.WriteLine("Pop element from FRONT END is: "+temp);
        }
        public void deleteRear()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            int temp = DequeA[rear];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (rear == 0)
            {
                rear = DequeA.Length - 1;
            }
            else
            {
                rear--;
            }
            Console.WriteLine("Pop element from REAR END is: " +temp);
        }
        public void peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            Console.WriteLine("Top(peek) element is: "+DequeA[front]);
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            if (front<=rear)
            {
                Console.Write("Queue is: ");
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(DequeA[i]+" ");
                }
            }
            else
            {
                Console.Write("Queue is: ");
                for (int j = front; j <=DequeA.Length-1; j++)
                {
                    Console.Write(DequeA[j]+" ");
                }
                for (int j = 0; j <= rear; j++)
                {
                    Console.Write(DequeA[j]+" ");
                }
            }
        }
        public void contain()
        {
            int size = 0;
            if (isEmpty())
            {
                Console.WriteLine("Queue is Underflow.");
                return;
            }
            if (front <= rear)
            {
                //Console.Write("Queue is: ");
                for (int i = front; i <= rear; i++)
                {
                    size++;
                    //Console.Write(DequeA[i] + " ");
                }
                Console.WriteLine("Size of Queue is: "+size);
            }
            else
            {
                //Console.Write("Queue is: ");
                for (int j = front; j <= DequeA.Length - 1; j++)
                {
                    size++;
                    //Console.Write(DequeA[j] + " ");
                }
                for (int j = 0; j <= rear; j++)
                {
                    size++;
                    //Console.Write(DequeA[j] + " ");
                }
                Console.WriteLine("Size of Queue is: "+size);
            }
        }
    }
}
