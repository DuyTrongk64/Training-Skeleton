using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Project
    {
        static void Main()
        {
            Class myClass = new Class
            {
                ClassID = 1,
                Name = "Class A",
                Desc = "Description of Class A",
                Students = new List<Student>
            {
                new Student { StudentID = 1, ClassID = 1, Name = "Student 1", DOB = DateTime.Now, Code = "SV0001", Math = 80, Phys = 85 },
                new Student { StudentID = 2, ClassID = 1, Name = "Student 2", DOB = DateTime.Now, Code = "SV0002", Math = 75, Phys = 90 },
                new Student { StudentID = 3, ClassID = 1, Name = "Student 3", DOB = DateTime.Now, Code = "SV0003", Math = 88, Phys = 92 },
                new Student { StudentID = 4, ClassID = 1, Name = "Student 4", DOB = DateTime.Now, Code = "SV0004", Math = 95, Phys = 78 },
                new Student { StudentID = 5, ClassID = 1, Name = "Student 5", DOB = DateTime.Now, Code = "SV0005", Math = 85, Phys = 87 }
            }
            };

        }
    }
}
