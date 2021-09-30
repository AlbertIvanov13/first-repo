using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            numbers.RemoveAll(n => n < 0);

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join("  ", numbers));
            }
        }
    }
}
