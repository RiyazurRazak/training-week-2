using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public class SalaryCalculator
    {
        public double GetTotalPayForADay(double[] data)
        {
            double salary = 0.0;
            double startTime = data[0];
            double endTime = data[1];
            double salaryPerHour = data[2];
            double overtimeBonous = data[3];

            if(endTime > 17)
            {
                double overTimeWorked = endTime - 17;
                endTime -= overTimeWorked;
                salary += overTimeWorked * (overtimeBonous * salaryPerHour);
            }

            Console.WriteLine(startTime + " " +endTime);
            double totalHoursWorked = endTime - startTime;
            salary += totalHoursWorked * salaryPerHour;
            return salary;
        }
    }
}
