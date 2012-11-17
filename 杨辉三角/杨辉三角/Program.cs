using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;//要输出的行数
            int[,] a;
            while (true)
            {
                quantity = Convert.ToInt32(Console.ReadLine());
                a = new int[quantity, quantity];
                for (int i = 0; i < quantity; i++)//i表示行,j表示列
                {
                    for (int j = 0; j < quantity; j++)
                    {
                        if (j == 0)
                            a[i, j] = 1;
                        else
                            a[i, j] = 0;
                    }
                }
                for (int i = 1; i < quantity; i++)
                {
                    for (int j = 1; j < quantity; j++)
                    {
                        a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
                    }
                }
                for (int i = 0, table = quantity; i < quantity; i++, table--)
                {
                    for (int j = 0; j < quantity && i >= j; j++)
                    {
                        Console.Write(a[i, j] + "\t");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
