using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Student
    {
        public int StudentID { get; set; }
        public int? ClassID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Code { get; set; }
        public int? Math { get; set; }
        public int? Phys { get; set; }
    }
}
