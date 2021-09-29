using System;
using System.Linq;
using System.Collections.Generic;

namespace Zadacha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
