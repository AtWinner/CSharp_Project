﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
            //显示结果0,2,4,6
        }
    }
}
