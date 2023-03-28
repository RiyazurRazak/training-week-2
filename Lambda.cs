using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
   
    internal class Lambda
    {
       public string name { get; set; }
       public int rollNo { get; set; }
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

      public int Count(Func<int, bool> callback)
      {
          return this.numbers.Count(callback);
      }
      
        //public int testmethod(int x, int y)
        //{
        //    var result = (int x, int y) =>
        //    {
        //        int total = 0;
        //        total = x + y;
        //        return total;
        //    };

        //    return result(x, y);

        //}

    }
}
