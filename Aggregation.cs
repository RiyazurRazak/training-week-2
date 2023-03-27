using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Aggregation
    {

    }

    public class Student
    {
         string name;
         int age;
         int rollNo;
         Marks mark;

        public Student(string name, int age, int rollNo, Marks mark)
        { 
            this.name = name;
            this.age = age;
            this.rollNo = rollNo;
            this.mark = mark;
        }

        public void Display()
        {
            this.mark.CalculatePercentage();
            Console.WriteLine($"{this.name} of {this.rollNo} has got {mark.percentage}% in his examination");
        }

    }

    public class Marks
    {
        public int totalMarks;
        public float percentage;
        public string grade;
        const int totalSubjects = 5;
        public Marks(int totalMarks) 
        {
            this.totalMarks = totalMarks;
           
        }

        public void CalculatePercentage()
        {
            this.percentage = (this.totalMarks / totalSubjects);
        }
    }
}
