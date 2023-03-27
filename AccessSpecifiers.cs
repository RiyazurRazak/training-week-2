using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public class AccessSpecifiers
    {
        protected internal string name = "Riyaz";
        internal int count = 10;
        protected void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
