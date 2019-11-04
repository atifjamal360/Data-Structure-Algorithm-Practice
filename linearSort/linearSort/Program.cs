using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 99, 55, 33, 77, 55, 44 };
            int minval, temp;
            Console.WriteLine("Display arraya:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length-1; i++)
            {
                minval = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minval])
                    {
                        minval = j;
                    }
                }
                if (i!=minval)
                {
                    temp = arr[i];
                    arr[i] = arr[minval];
                    arr[minval] = temp;
                }
            }
            Console.WriteLine("Display arraya:");
            for (int i = 0; i < arr.Length ; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
