﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace Collection
{
    internal class Project
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> numberList;
            string number;
            bool check_num;

            Console.WriteLine("2.1. List");
            Console.WriteLine("2.1.1. Input: None\r\nTạo 1 danh sách số int\r\nThêm vào danh sách 10 số bất kỳ\r\nIn kết quả ra màn hình và trả về danh sách vừa tạo");
            Console.Write("Kết quả: ");
            numberList = Tool.crateList();
            new List1(numberList);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.2. Input: danh sách 10 số bất kỳ\r\nSắp xếp danh sách theo thứ tự tăng dần, in kết quả ra màn hình");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nKết quả: ");
            new List2(numberList);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.3. Input: danh sách 10 số bất kỳ\r\nĐảo ngược vị trí các số trong danh sách, in kết quả ra màn hình");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nKết quả: ");
            new List3(numberList);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.4. Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số nhỏ hơn X khỏi danh sách, in kết quả ra màn hình");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
            } while (!check_num);
            Console.Write("\nKết quả: ");
            new List4(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.5. Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số chia hết cho X khỏi danh sách, in kết quả ra màn hình");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
                if (check_num && int.Parse(number) == 0)
                {
                    Console.WriteLine("Vui lòng nhập số khác 0!");
                }
            } while (!check_num || int.Parse(number) == 0);
            Console.Write("\nKết quả: ");
            new List5(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.6. Input: danh sách 10 số bất kỳ và 1 số (X)\r\nVới mỗi số trong danh sách, nếu nhỏ hơn X thì cộng với X\r\nIn kết quả ra màn hình");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
            } while (!check_num);
            Console.Write("\nKết quả: ");
            new List6(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.7. Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
                if (check_num && int.Parse(number) <= 0)
                {
                    Console.WriteLine("Vui lòng nhập lớn hơn 0!");
                }
            } while (!check_num || int.Parse(number) <= 0);
            Console.Write("\nKết quả: ");
            new List7(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.8. Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình theo chiều ngược lại");
            numberList = Tool.crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
                if (check_num && int.Parse(number) <= 0)
                {
                    Console.WriteLine("Vui lòng nhập lớn hơn 0!");
                }
            } while (!check_num || int.Parse(number) <= 0);
            Console.Write("\nKết quả: ");
            new List8(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.9. Input: 1 số lớn hơn 0 (X)\r\nin ra dãy (tối đa 10 giá trị) số thuộc dãy fibonaci < số nhập vào");
            numberList = Tool.crateList();
            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = Tool.checkNumber(number);
                if (check_num && int.Parse(number) <= 0)
                {
                    Console.WriteLine("Vui lòng nhập lớn hơn 0!");
                }
            } while (!check_num || int.Parse(number) <= 0);
            Console.Write("\nKết quả: ");
            new List9(number);
            Console.WriteLine("\n");

            Console.WriteLine("2.2. Dictionary");
            Console.WriteLine("2.2.1. Tạo 1 Dictionary chứa key chưa mã Sinh viên kiểu int, value là Tên SV\r\nThêm vào Dictionary 5 giá trị\r\nTrả về Dictionary vừa tạo");
            new Dict1();

            Console.WriteLine("2.2.2. Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, in tên SV đó\r\nNgược lại thông báo: Không có SV có mã...\r\n");
            new Dict2();

            Console.WriteLine("2.2.3. Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm \r\nSV có mã..., tên... vào Dictionary\r\nNgược lại thông báo: Đã có SV có mã...trong Dictonary\r\n");
            new Dict3();

            Console.WriteLine("2.2.4. Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm \r\nSV có mã..., tên... vào Dictionary\r\nNgược lại thay tên SV cũ bằng tên SV mới, thông báo: Đãthaytên SV có mã...trong \r\nDictonary từ... thành...\r\n");
            new Dict4();

            Console.WriteLine("2.2.5. Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, bỏ mã SV đó khỏi Dictionary\r\nNgược lại thông báo: Không có SV có mã..");
            new Dict5();
        }
    }
}
