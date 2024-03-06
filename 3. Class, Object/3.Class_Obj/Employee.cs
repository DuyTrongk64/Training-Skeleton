using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj
{
    public class Employee
    {
        protected string Name;
        protected int Age;
        protected DateTime CreatedAt;

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedAt = DateTime.Now;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Tôi tên là {Name}, {Age} tuổi.");
        }

        public void ExtInfo()
        {
            Console.WriteLine($"Tôi tên là {Name}, được tạo ra lúc {CreatedAt.ToString("HH:mm:ss")}.");
        }
    }
}
