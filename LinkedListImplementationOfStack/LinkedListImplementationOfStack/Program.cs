using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementationOfStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice,n,x;
            StackL arr = new StackL();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1. Push element in stack.");
                Console.WriteLine("2. Pop element from stack.");
                Console.WriteLine("3. See Peek element from stack.");
                Console.WriteLine("4. No. of element in stack.");
                Console.WriteLine("5. Display all element of stack.");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter no. to push in stack: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        arr.push(x);
                        break;
                    case 2:
                        arr.pop();
                        break;
                    case 3:
                        arr.peek();
                        break;
                    case 4:
                        arr.contains();
                        break;
                    case 5:
                        arr.display();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
