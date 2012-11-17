using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a[,,,]=new string[7,7,7];
            Random rd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                
                int value = rd.Next(1, 100);
                Console.Write(value+" ");
            }
        }
    }
}
