using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 汉诺塔
{
    class Program
    {
        public static int i;//输出行号
        static void move(char x, char y)
        {
            i++;
            Console.WriteLine(i+":"+x + "->" + y);
        }

        static void hanoi(int n, char one, char two, char three)
        {
            if (n == 1)
                move(one, three);
            else
            {
                hanoi(n - 1, one, three, two);
                move(one, three);
                hanoi(n - 1, two, one, three);
            }
        }
        static void Main(string[] args)
        {
            int m;
            while (true)
            {
                i = 0;
                Console.Write("Input the quantity:");
                m = Convert.ToInt16(Console.ReadLine());
                if (m == 111)
                    break;
                else 
                    hanoi(m, 'A', 'B', 'C');
            }
        }
    }
}
