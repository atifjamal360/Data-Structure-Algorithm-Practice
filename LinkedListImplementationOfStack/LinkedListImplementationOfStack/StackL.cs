using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementationOfStack
{
    class StackL
    {
        private node top;
        public StackL()
        {
            top = null;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public void display()
        {
            if (isEmpty())
                Console.WriteLine("Stack is UnderFlow.");
            else
            {
                node p = top;
                Console.Write("Stack is : ");
                while (p!=null)
                {
                    Console.Write(p.info+" ");
                    p = p.link;
                }
                Console.WriteLine();
            }
        }
        public void contains()
        {
            int size = 0;
            if (isEmpty())
                Console.WriteLine("Stack is Underflow.");
            else
            {
                node p = top;
                while (p != null)
                {
                    size++;
                    p = p.link;
                }
                Console.WriteLine("Stack Contains "+size+" elements.");
            }
        }
        public void push(int x)
        {
            node temp = new node(x);
            temp.link = top;
            top = temp;
        }
        public void pop()
        {
            if (isEmpty())
                Console.WriteLine("Stack is Underflow.");
            else
            {
                Console.Write("Pop element is: " + top.info);
                top = top.link;
            }
        }
        public void peek()
        {
            if (isEmpty())
                Console.WriteLine("Stack is Underflow.");
            else
                Console.WriteLine("Top element is: " + top.info);
        }
    }
}
