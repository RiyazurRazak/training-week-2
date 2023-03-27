using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public class Car
    {
        private int maxSpeed = 100;
        public void Start()
        {
            Console.WriteLine($"Engine Started!! with the maxspeed of {this.maxSpeed} kmph");
        }

        public void Stop() 
        { 
            Console.WriteLine("ABS Applied"); 
        }

        public void LimitMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
    }

    public class Ford: Car
    {
        public Ford()
        {
            this.LimitMaxSpeed(180);
        } 

        public void Stop()
        {
            Console.WriteLine("Ford car stoped");
        }
    }

    public class Mustang : Ford
    {
        public Mustang()
        {
            this.LimitMaxSpeed(220);
        }

        public void EnableNitroBoost()
        {
            this.LimitMaxSpeed(260);

        }
    }
}
