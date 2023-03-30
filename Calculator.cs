using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public class NormalCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Subtract(int a, int b, int c)
        {
            return a - b - c;
        }
    }

    public class OppositeCalculator : NormalCalculator
    {
        public new int Add(int a, int b)
        {
            return base.Subtract(a, b);
        }

        public new int Add(int a, int b, int c)
        {
            return base.Subtract(a, b,c);
        }

        public new int Subtract(int a, int b, int c)
        {
            return base.Add(a, b, c);
        }
    }
    internal class Calculator
    {
        static void main(string[] args)
        {
            NormalCalculator normalCalculator = new NormalCalculator();
            OppositeCalculator oppositeCalculator = new OppositeCalculator();
            Console.WriteLine(normalCalculator.Add(1, 2));
            Console.WriteLine(normalCalculator.Add(1, 2, 3));
            Console.WriteLine(normalCalculator.Subtract(3, 2));
            Console.WriteLine(normalCalculator.Subtract(5, 2,1));
            Console.WriteLine(oppositeCalculator.Add(1, 2));
            Console.WriteLine(oppositeCalculator.Subtract(3, 2));
            Console.WriteLine(oppositeCalculator.Subtract(3, 2));
            Console.WriteLine(oppositeCalculator.Subtract(5, 2, 1));
        }
    }
}
