using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    abstract public class Abstraction
    {
        abstract public void Display(int x, int y);
        public void Check()
        {
            Console.WriteLine("Hurray!!");
        }
    }

    public class Testing: Abstraction
    {
        override public void Display(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = " + (x+y));
        }
    }
}
