using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, n, data;
            doublyL arr = new doublyL();
            arr.createList();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1.Display List.");
                Console.WriteLine("2.Count no of element in List.");
                Console.WriteLine("3.Search Element in List.");
                Console.WriteLine("4.Insert element in beginning of List.");
                Console.WriteLine("5.Insert element at end of List.");
                Console.WriteLine("6.Insert element After Node.");
                Console.WriteLine("7.Insert element before Node.");
                Console.WriteLine("8.Insert Node at particular Postion.");
                Console.WriteLine("9.Delete First Node from list.");
                Console.WriteLine("10.Delete Last Node from List.");
                Console.WriteLine("11.Delete node from list.");
                Console.WriteLine();
                Console.Write("Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 8)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        arr.display();
                        break;
                    case 2:
                        arr.contain();
                        break;
                    case 3:
                        Console.Write("Enter element from list: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        arr.search(n);
                        break;
                    case 4:
                        Console.Write("Enter element to insert at beginning of list: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        arr.insertAtBegin(n);
                        break;
                    case 5:
                        Console.Write("Enter element to insert at End of list: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        arr.insertAtEnd(n);
                        break;
                    case 6:
                        Console.Write("Enter element to list: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter " + n + " After: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        arr.insertAfter(n, data);
                        break;
                    case 7:
                        Console.Write("Enter element to list: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter " + n + " Before: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        arr.insertBefore(n, data);
                        break;
                    //case 8:
                    //    Console.Write("Enter element to list: ");
                    //    n = Convert.ToInt32(Console.ReadLine());
                    //    Console.Write("Enter " + n + " at position: ");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    arr.insertAtPosition(n, data);
                    //    break;
                    //case 9:
                    //    arr.deleteFirstNode();
                    //    break;
                    //case 10:
                    //    arr.deleteLastNode();
                    //    break;
                    //case 11:
                    //    Console.Write("Enter element to Delete: ");
                    //    n = Convert.ToInt32(Console.ReadLine());
                    //    arr.deleteNode(n);
                    //    break;
                    default:
                        Console.WriteLine("Wrong Choice.");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
