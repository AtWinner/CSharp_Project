using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_2012_11_12
{
    public class myClass
    {
        public readonly string Name;
        private int intValue;
        public int Val
        {
            get
            {
                return intValue;
            }
            set
            {
                if (value > 0 && value <= 10)
                {
                    intValue = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("Val",value,"Val must be assigned a value between 0 and 10"));
                }
            }
        }
        public override string ToString()
        {
            return "Name:" + Name + " Val:" + Val;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
