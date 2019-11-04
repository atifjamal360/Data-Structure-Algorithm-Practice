using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, value, first, last, mid, k=0,temp;
            Console.Write("Enter size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n-1; i++)
            {
                for (int l = i+1; l < n; l++)
                {
                    if (arr[l]<arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[l];
                        arr[l] = temp;
                    }
                }
            }
            Console.WriteLine("Display array:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("Enter number to search in list?");
            value = Convert.ToInt32(Console.ReadLine());

            first = 0;
            last = n - 1;
            while (first<=last)
            {
                mid = (first + last) / 2;
                if (value < arr[mid])
                {
                    last = mid - 1;
                }
                else if (value > arr[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    k++;
                    Console.WriteLine(value+" Present in list");
                    break;
                }
            }
            if (k==0)
            {
                Console.WriteLine(value + " Not Found");                  
            }
            Console.ReadKey();
        }
    }
}
