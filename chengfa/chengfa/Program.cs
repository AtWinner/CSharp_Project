using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chengfa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] han = { "十", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int temp = i * j;
                    if (temp < 10)
                    {
                        Console.Write(han[temp] + " ");
                        if (j == 2)
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(han[temp / 10] + han[0] + han[temp % 10] + " ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
} 
