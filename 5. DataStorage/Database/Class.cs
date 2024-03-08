using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Class
    {

        public int ClassID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<Student> Students { get; set; }

    }
}
