using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{

    internal class Demo
    {
        public Demo()
        {
            Console.WriteLine("Initialized!!");
        }

        public void Display()
        {
            Test test = new Test();
            test.Add();
            Console.WriteLine("Displayed");
        }

        private void Update()
        {
            Console.WriteLine("Updated");
        }

        public class Test
        {
            public Test()
            {
                Console.WriteLine("Private class initialized");
            }

            protected internal void Add()
            {
                Console.WriteLine("Add method ");
            }
        }
    }
}
