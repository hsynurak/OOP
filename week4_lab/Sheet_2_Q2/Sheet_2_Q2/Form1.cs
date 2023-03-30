using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sheet_2_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Personnel
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class Employee : Personnel
    {
        public int ID { get; set; }
        public int Salary { get; set; }
    }

    public class Students : Personnel
    {
        public int regisNo { get; set; }
        public int GPA { get; set; }
    }
}
