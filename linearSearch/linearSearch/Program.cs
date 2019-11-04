using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,value,i;
            Console.WriteLine("Enter size of ARRAY?");
            n = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[n];
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter number to search in array");
            value = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (arr[i]>=value)
                {
                    break;
                }
            }
            if (i==n)
            {
                Console.WriteLine(value + " not found");
            }
            else
            {
                Console.WriteLine(value + " Present in Array");

            }
            Console.ReadLine();
        }
    }
}
