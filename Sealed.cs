using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
     public class Sealed
    {
        public Sealed() {
            Console.WriteLine("SEALED CLASS");
        }

        public virtual void Check()
        {
            Console.WriteLine("Sealed Method");
        }
    }

    public class ChildA: Sealed
    {
        public sealed override void Check()
        {
            Console.WriteLine("Child A");
        }
    }

    public class ChildB: ChildA
    {
        //override public void Check()
        //{
        //    Console.WriteLine("Child B");
        //}
    }
}
