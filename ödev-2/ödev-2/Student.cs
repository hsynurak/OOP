using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2
{
    internal class Student
    {
        public int registrationNo { get; set; }
        public double GPA { get; set; }
        public Student() : base()
        {
            registrationNo = 0;
            GPA = 0;
        }
        public Student(int regNo, double gpa)
        {
            registrationNo = regNo;
            GPA = gpa;
        }
        public string calcGPA ()
        {
            if (GPA >= 3.40) return "A";
            else if (GPA >= 2.80) return "B";
            else if (GPA >= 2.40) return "C";
            else if (GPA >= 2.00) return "D";
            else return "F";
        }
    }
}
