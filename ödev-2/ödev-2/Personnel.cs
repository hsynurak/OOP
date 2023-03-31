using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_2
{
    internal class Personnel
    {
        public string name { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int birthDay { get; set; }
        public int birthMonth { get; set; }
        public int birthYear { get; set; }

        public Personnel()
        {
            name = "";
            middleName = "";
            lastName = "";
            birthDay = 0;
            birthMonth = 0;
            birthYear = 0;
        }
    }
}
