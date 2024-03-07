using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj
{
    public class Teacher : Employee
    {
        private string Subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public string subject
        { get { return Subject; } }

        public new void ShowInfo()
        {
            Console.WriteLine($"Tôi là Giáo Viên, {Age} tuổi, tên là {Name}.");
        }

        public new void ExtInfo()
        {
            base.ExtInfo();
            Console.WriteLine($"Tôi là Giáo Viên tên {Name}, thuộc bộ môn {Subject}.");
        }
    }
}
