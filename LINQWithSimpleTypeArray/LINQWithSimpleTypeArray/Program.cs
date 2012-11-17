using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQWithSimpleTypeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 9, 5, 0, 3, 7, 2, 4, 8, 5 };
            Console.Write("Original array:");
            foreach (var element in values)
                Console.Write(" " + element);
            var filtered =
                from value in values
                where value > 1
                select value;
            Console.Write("\nArray values greater than 1:");
            foreach (var element in filtered)
                Console.Write(" " + element);
            var sorted =
                from value in values
                orderby value descending
                select value;
            Console.Write("\nOriginal array,sorted:");
            foreach (int element in sorted)
                Console.Write(" " + element);
            

        }
    }
}
