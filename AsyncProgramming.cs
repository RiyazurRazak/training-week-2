using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class AsyncProgramming
    {
        public async Task Print()
        {
            Console.WriteLine("Method Print Initiated!");
            //int num = Task.WaitAny(IntensiveMethod());
            int num = await IntensiveMethod();
            Console.WriteLine("Method Print Done!" + num);
        }


        public async Task<int> IntensiveMethod()
        {
            double x = 0;
            await Task.Run(() => {
                for (int i = 0; i < 1000000000; i++) {x= Math.Sqrt(i * i); };
            });
            Console.WriteLine("Task Over!! Returning");
            return (int) x;
        }
        public void Sum()
        {
            Console.WriteLine("Method Sum Initiated!");
            Console.WriteLine("Method Sum Done!");
        }
    }
}
