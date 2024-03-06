using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj
{
    public class Student : Employee
    {
        private string Major;

        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Tôi là Sinh Viên.");
        }

        public new void ExtInfo()
        {
            base.ExtInfo();
            Console.WriteLine($"Tôi là Sinh viên tên {Name}, học chuyên ngành {Major}.");
        }
    }
}
