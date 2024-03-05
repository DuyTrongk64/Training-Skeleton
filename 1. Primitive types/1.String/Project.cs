using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PrimitiveTypes
{
    internal class Project
    {
        static void Main(string[] args)
        {
            int check = 0;
            string input;
            Console.OutputEncoding = Encoding.UTF8;
       
            Console.WriteLine("1. Primitive types");
            Console.WriteLine("1.1. String");
            Console.WriteLine("1.1.1. Input: 1 chuỗi.\r\nNếu chuỗi null -> Thông báo: Chuỗi bị null\r\nNếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng\r\nNếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space\r\nCòn lại: In chuỗi ký tự ra màn hình");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String1(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.2. Như 1.\r\nCòn lại: In chuỗi ký tự sau khi bỏ ký tự trắng ở đầu và cuối");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String2(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.3. Như 1.\r\nCòn lại: In chuỗi ký tự sau khi bỏ hết ký tự trắng");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String3(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.4. Như 1.\r\nCòn lại: In chuỗi ký tự sau khi chuyển thành chữ hoa các ký tự đứng sau dấu Space");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String4(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.5. Như 1.\r\nCòn lại: Đếm và thông báo số ký tự Space theo mẫu: Có [count] ký tự space");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String5(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.6. Như 1.\r\nCòn lại: Đếm và thông báo số ký tự không phải Space theo mẫu: Có [count] ký tự không \r\nphải space");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String6(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.7. Input: 2 chuỗi đầu vào (input1, input2)\r\nNếu 2 chuỗi giống nhau (Phân biệt hoa thường) -> Hiển thị kết quả: Chuỗi [input1] giống \r\nchuỗi [input2]\r\nNgược lại, Hiển thị kết quả: Chuỗi \"input1\"khác chuỗi \"input2\"");
            Console.Write("Nhập chuỗi 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Nhập chuỗi 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String6(input);
            Console.WriteLine("");
        }
    }
}
