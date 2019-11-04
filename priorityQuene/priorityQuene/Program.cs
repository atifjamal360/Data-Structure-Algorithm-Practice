using System;

namespace priorityQuene
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, element, priority;
            PriorityQ q = new PriorityQ();
            while (true)
            {
                Console.WriteLine("1.Insert an element.");
                Console.WriteLine("2.Delete an element.");
                Console.WriteLine("3.display all element.");
                Console.WriteLine("4.Quit.");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be inserted.");
                        element = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the priority of element");
                        priority = Convert.ToInt32(Console.ReadLine());
                        q.insert(element, priority);
                        break;
                    case 2:
                        q.delete();
                        break;
                    case 3:
                        q.display();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
    }
}
