using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj
{
    internal class Project
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Employee person = new Employee("Người", 25);
            person.ShowInfo();
            person.ExtInfo();

            Student student = new Student("Sinh Viên A", 20, "Khoa Học Máy Tính");
            student.ShowInfo();
            student.ExtInfo();

            Teacher teacher = new Teacher("Giáo Viên B", 35, "Toán");
            teacher.ShowInfo();
            teacher.ExtInfo();
        }
    }
}
