using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{

    delegate int DelegateSum(int x, int y);
    internal class Delegates
    {
        public int Sum(int x, int y)
        {
            // Console.WriteLine(x+y);
            return x + y;
        }

        public int Difference(int x, int y)
        {
            // Console.WriteLine(x - y);
            return x - y;
        }
    }
}
