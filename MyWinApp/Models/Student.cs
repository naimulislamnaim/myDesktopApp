using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }

        public int DistrictID { get; set; }

        //
        public string District { get; set; }

    }
}
