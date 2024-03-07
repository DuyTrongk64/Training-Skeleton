using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Obj
{
    internal class Project
    {

        static List<Employee> employeeList = new List<Employee>();
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            employeeList.Add(new Employee("Nguyen Van A", 20));
            employeeList.Add(new Employee("Nguyen Van B", 22));
            employeeList.Add(new Employee("Nguyen Van C", 24));

            employeeList.Add(new Student("Hoang Van A", 19, "CNTT"));
            employeeList.Add(new Student("Hoang Van B", 21, "DDT"));
            employeeList.Add(new Student("Hoang Van C", 23, "CNHH"));

            employeeList.Add(new Teacher("Le Thi D", 40, "Toan"));
            employeeList.Add(new Teacher("Le Thi E", 43, "Van"));
            employeeList.Add(new Teacher("Le Thi F", 46, "Anh"));

            while (true)
            {
                Console.WriteLine("\n------ Menu ------");
                Console.WriteLine("1. Thêm người");
                Console.WriteLine("2. Hiện danh sách");
                Console.WriteLine("3. Hiển thị thông tin");
                Console.WriteLine("0. Thoát");

                Console.Write("Chọn chức năng (0-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        ShowList();
                        break;
                    case "3":
                        ShowDetails();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Console.WriteLine("\n1. Thêm Người");
            Console.WriteLine("2. Thêm Sinh Viên");
            Console.WriteLine("3. Thêm Giáo Viên");
            Console.WriteLine("4. Quay lại Menu chính");
            Console.Write("Chọn loại người cần thêm (1-4): ");
            string typeChoice = Console.ReadLine();

            string name;
            string age;
            string major;
            bool check;

            switch (typeChoice)
            {
                case "1":
                    do
                    {
                        Console.Write("Nhập tên Người: ");
                        name = Console.ReadLine();
                        check = Tool.CheckString(name);
                    } while (!check);

                    do
                    {
                        Console.Write("Nhập tuổi Người: ");
                        age = Console.ReadLine();
                        check = Tool.checkNumber(age);
                    } while (!check);

                    employeeList.Add(new Employee(name, int.Parse(age)));
                    Console.WriteLine("Người đã được thêm vào danh sách.");
                    break;
                case "2":
                    do
                    {
                        Console.Write("Nhập tên Sinh Viên: ");
                        name = Console.ReadLine();
                        check = Tool.CheckString(name);
                    } while (!check);

                    do
                    {
                        Console.Write("Nhập tuổi Sinh Viên: ");
                        age = Console.ReadLine();
                        check = Tool.checkNumber(age);
                    } while (!check);

                    do
                    {
                        Console.Write("Nhập chuyên ngành của Sinh Viên: ");
                        major = Console.ReadLine();
                        check = Tool.CheckString(major);
                    } while (!check);


                    employeeList.Add(new Student(name, int.Parse(age), major));

                    Console.WriteLine("Sinh Viên đã được thêm vào danh sách.");
                    break;
                case "3":
                    do
                    {
                        Console.Write("Nhập tên Giáo Viên: ");
                        name = Console.ReadLine();
                        check = Tool.CheckString(name);
                    } while (!check);

                    do
                    {
                        Console.Write("Nhập tuổi Giáo Viên: ");
                        age = Console.ReadLine();
                        check = Tool.checkNumber(age);
                    } while (!check);

                    do
                    {
                        Console.Write("Nhập bộ môn của Giáo Viên: ");
                        major = Console.ReadLine();
                        check = Tool.CheckString(major);
                    } while (!check);

                    employeeList.Add(new Teacher(name, int.Parse(age), major));
                    Console.WriteLine("Giáo Viên đã được thêm vào danh sách.");
                    break;
                case "4":

                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        static void ShowList()
        {
            Console.WriteLine("\n1. Hiện danh sách Người");
            Console.WriteLine("2. Hiện danh sách Sinh Viên");
            Console.WriteLine("3. Hiện danh sách Giáo Viên");
            Console.WriteLine("4. Quay lại Menu chính");
            Console.Write("Chọn loại danh sách cần hiển thị (1-4): ");
            string typeChoice = Console.ReadLine();

            switch (typeChoice)
            {
                case "1":
                    Console.WriteLine("Danh sách Người:");
                    foreach (var Employee in employeeList)
                    {
                        if (Employee is Employee)
                            Employee.ShowInfo();
                    }
                    break;
                case "2":
                    Console.WriteLine("Danh sách Sinh Viên:");
                    foreach (var student in employeeList)
                    {
                        if (student is Student)
                            Console.WriteLine($"- {student.name} ({((Student)student).major})");
                    }
                    break;
                case "3":
                    Console.WriteLine("Danh sách Giáo Viên:");
                    foreach (var teacher in employeeList)
                    {
                        if (teacher is Teacher)
                            Console.WriteLine($"- {teacher.name} ({((Teacher)teacher).subject})");
                    }
                    break;
                case "4":
                    // Không cần làm gì, sẽ quay lại menu chính tự động.
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        static void ShowDetails()
        {
            Console.WriteLine("\n1. Xem thông tin Người");
            Console.WriteLine("2. Xem thông tin Sinh Viên");
            Console.WriteLine("3. Xem thông tin Giáo Viên");
            Console.WriteLine("4. Quay lại Menu chính");
            Console.Write("Chọn loại thông tin cần xem (1-4): ");
            string typeChoice = Console.ReadLine();

            switch (typeChoice)
            {
                case "1":
                    ShowDetailsOfType<Employee>("Người");
                    break;
                case "2":
                    ShowDetailsOfType<Student>("Sinh Viên");
                    break;
                case "3":
                    ShowDetailsOfType<Teacher>("Giáo Viên");
                    break;
                case "4":
                    // Không cần làm gì, sẽ quay lại menu chính tự động.
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        static void ShowDetailsOfType<T>(string typename) where T : Employee
        {
            Console.Write($"Nhập tên {typename} để xem thông tin chi tiết: ");
            string nameToFind = Console.ReadLine();
            T Employee = employeeList.Find(p => p.name == nameToFind) as T;

            if (Employee != null)
            {
                Console.WriteLine($"Thông tin chi tiết của {typename} {nameToFind}:");
                Employee.ExtInfo();
            }
            else
            {
                Console.WriteLine($"Không tìm thấy {typename} có tên là {nameToFind} trong danh sách.");
            }
        }
    }
}

