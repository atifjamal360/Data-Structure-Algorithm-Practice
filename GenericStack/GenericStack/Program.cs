using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class Stack<T>
    {
        T[] arr;
        int top;
        

        public Stack(int size)
        {
            arr = new T[size];
            top = 0;
        }

        public void Push(T value)
        {
            arr[top] = value;
            top++;
        }

        public T Pop()
        {
            top--;
            return arr[top];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(3);
            stack.Push("Atif");
            stack.Push("Huzaifa");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine();

            Stack<int> stack2 = new Stack<int>(3);
            stack2.Push(1);
            stack2.Push(2);
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.ReadKey();

        }
    }
}
