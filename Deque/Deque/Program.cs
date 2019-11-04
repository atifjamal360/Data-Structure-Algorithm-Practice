using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, n, x;
            Console.Write("Enter Size of the Stack : ");
            n = Convert.ToInt32(Console.ReadLine());
            Deque arr = new Deque(n);
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1. Push element from Rear End in Queue.");
                Console.WriteLine("2. Push element from Front End in Queue.");
                Console.WriteLine("3. See Peek element from Queue.");
                Console.WriteLine("4. No. of element in stack.");
                Console.WriteLine("5. Display all element of stack.");
                Console.WriteLine("6. Pop element from Rear End from Queue.");
                Console.WriteLine("7. Pop element from Front End from Queue.");
                Console.WriteLine();
                Console.WriteLine("TO STOP PROGRAM PRESS 8");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 8)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter no. to push in Rear End of Queue: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        arr.insertRear(x);
                        break;
                    case 2:
                        Console.Write("Enter no. to push in Front End of Queue: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        arr.insertFront(x);
                        break;
                    case 3:
                        arr.peek();
                        break;
                    case 4:
                        arr.contain();
                        break;
                    case 5:
                        arr.display();
                        break;
                    case 6:
                        arr.deleteRear();
                        break;
                    case 7:
                        arr.deleteFront();
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
