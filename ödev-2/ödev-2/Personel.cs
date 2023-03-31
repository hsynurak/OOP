using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2
{
    internal class Personel
    {
        public string name { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int birthDay { get; set; }
        public int birthMonth { get; set; }
        public int birthYear { get; set; }

        public Personel()
        {
            name = "";
            middleName = "";
            lastName = "";
            birthDay = 0;
            birthMonth = 0;
            birthYear = 0;
        }
        public Personel(int birthDay, int birthMonth, int birthYear)
        {
            this.birthDay = birthDay;
            this.birthMonth = birthMonth;
            this.birthYear = birthYear;
        }
    }
}
