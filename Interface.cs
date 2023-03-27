using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public interface Iparent
    {
        public void Show();
        public void Display()
        {
            Console.WriteLine("Displayed!");
        }
    }

    public class App : Iparent
    {
        public void Show()
        {
           
            Console.WriteLine("show");
        }


    }
}
