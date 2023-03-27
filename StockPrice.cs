using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class StockPrice
    {
        public void Run()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int maxProfit = 0;
            int pointer = 0;

            for(int day=0; day< prices.Length; day++)
            {
                int buyStock = prices[pointer];
                int sellStock = prices[day];

                if(buyStock < sellStock)
                {
                    maxProfit = Math.Max(maxProfit, sellStock - buyStock);
                }
                else
                {
                    pointer = day;
                }
            }

            Console.WriteLine(maxProfit);
        }
    }
}
