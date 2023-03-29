using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    delegate void PrintSomeStufs();
    internal class BuiltInDelegate
    {

        public static void Print()
        {
            Console.WriteLine("printed");
        }
        public static void main(string[] args)
        {
            //PrintSomeStufs Fn = Print;
            //Fn.Invoke();
            //void delegate
            //Action<string> ConsoleDelegate = (msg) => Console.WriteLine(msg);
            //ConsoleDelegate("hai from build in delegate");
            // return delegate
            //Func<int, int, int> Sum = (a, b) => a + b;
            //Console.WriteLine(Sum(1, 2));

            Predicate<int> Checker = (int a) => a == 5;
            Console.WriteLine(Checker(5));

            
        }

    }
}
