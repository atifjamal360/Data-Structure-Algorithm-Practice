using System;

namespace Linear_Search_TwoWay_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int start = 0, end = arr.Length - 1, count = 0;

            Console.WriteLine("Your Array:");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine("\n\nWhich no. you want to search from array?");
            int value = int.Parse(Console.ReadLine());
            do
            {
                if (arr[start]==value || arr[end]==value) //two way linear search
                {
                    Console.WriteLine("OH YASSSS!\n{0} is present in array", value);
                    count = 1;
                    break;
                }
                else
                {
                    start++;
                    end--;
                }
            } while (start<end);
            if (count == 0)
            {
                Console.WriteLine("{0} is not present in array ", value);
            }
            Console.ReadKey();
        }
    }
}
