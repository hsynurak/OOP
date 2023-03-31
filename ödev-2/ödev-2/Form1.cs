using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_2
{
    public partial class Form1 : Form
    {
        Employee my_employee = new Employee(1,10000,10);
        Personel my_personel = new Personel(12,09,2001);
        Student my_student = new Student(2,5);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGPA_Click(object sender, EventArgs e)
        {
            txtGPA.Text = my_student.calcGPA().ToString();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
          
            txtSalaryPerHour.Text = (my_employee.salaryPerYear / my_employee.workingHour).ToString();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            txtAge.Text = ((DateTime.Now.Year) - (my_personel.birthYear)).ToString();
        }
    }
}
