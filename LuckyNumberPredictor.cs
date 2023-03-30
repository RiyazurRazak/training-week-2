using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{

    abstract class NumberPredictor
    {
        private List<int> fibonacciSeries = new();
        const int maxFibonacciRange = 10;

        private void GenerateFibonnaciSeries()
        {
            int x1 = 0, x2 = 1;

            for (int i = 3; i <= maxFibonacciRange; i++)
            {
                int x3 = x1 + x2;
                fibonacciSeries.Add(x3);
                x1 = x2;
                x2 = x3;
            }   
        }
        protected NumberPredictor() { 
            this.fibonacciSeries.Add(0);
            this.fibonacciSeries.Add(1);
            this.GenerateFibonnaciSeries();
        }
        protected int GetLuckyNumber(int date)
        {
            int luckyNumber = date;
            foreach(int sequence in fibonacciSeries)
            {
                if(Math.Max(date, sequence) != date)
                {
                    luckyNumber = sequence;
                    break;
                }
            };
            return luckyNumber;
        }

        abstract public void IdentifyUnluckyNumber(int date);

    }

    internal class LuckyNumberPredictor : NumberPredictor
    {
        LuckyNumberPredictor() : base() { }
        public new int GetLuckyNumber(int date)
        {
            return base.GetLuckyNumber(date);
        }

        public override void IdentifyUnluckyNumber(int date)
        {

        }

        public static void main(string[] args)
        {
            LuckyNumberPredictor predictor = new LuckyNumberPredictor();
            Console.WriteLine(predictor.GetLuckyNumber(23));
        }
    }
}
