using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2
{
    internal class Employee : Personel
    {
        public int ID { get; set; }
        public double salaryPerYear { get; set; }
        public double workingHour { get; set; }
        public Employee() : base()
        {
            ID = 0;
            salaryPerYear = 0;
            workingHour = 0;
        }
        public Employee(int ıD, double salary, double workHour)
        {
            ID = ıD;
            salaryPerYear = salary;
            workingHour = workHour;
        }
        
    }
}
