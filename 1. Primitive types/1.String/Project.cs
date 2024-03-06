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
            bool check_num;
            string input;
            string number;

            String1 str1 = new String1();
            Int1 int1 = new Int1();

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
            string input1;
            do
            {
                Console.Write("Nhập chuỗi 1: ");
                input1 = Console.ReadLine();
                check = str1.CheckString(input1);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);
            string input2;
            do
            {
                Console.Write("Nhập chuỗi 2: ");
                input2 = Console.ReadLine();
                check = str1.CheckString(input2);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);
            Console.Write("Kết quả: ");
            new String7(input1, input2);
            Console.WriteLine("");

            Console.WriteLine("1.1.8. Như 7 nhưng không phân biệt hoa thường\n");
            do
            {
                Console.Write("Nhập chuỗi 1: ");
                input1 = Console.ReadLine();
                check = str1.CheckString(input1);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);
            do
            {
                Console.Write("Nhập chuỗi 2: ");
                input2 = Console.ReadLine();
                check = str1.CheckString(input2);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            }
            while (check == 1);
            Console.Write("Kết quả: ");
            new String8(input1, input2);
            Console.WriteLine("");

            Console.WriteLine("1.1.9. Như 1.\r\nThay thếcác đoạn \"ABC\" có trong chuỗi đầu vào bằng \"DEF\", CÓ phân biệt hoa thường");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String9(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.10. Như 1.\r\nHiển thị chuỗi: Kính chào ông input. Chúc ngon miệng.\r\n(Giả sử input = \"Vũ Văn Chiến\" -> \"Kính chào ông Vũ Văn Chiến. Chúc ngon miệng.\") ");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String10(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.11. Như 1.\r\nĐảo ngược các ký tự của chuỗi và in ra màn hình chuỗi đầu vào và chuỗi kết quả");
            Console.Write("Nhập chuỗi: ");
            input = Console.ReadLine();
            Console.Write("Kết quả: ");
            new String11(input);
            Console.WriteLine("");

            Console.WriteLine("1.1.12. Input: 1 chuỗi và 1 số (count)\r\nNếu chuỗi null -> Thông báo: Chuỗi bị null\r\nNếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng\r\nNếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space\r\nNếu số < 0 -> Thông báo: Số nhỏ hơn 0\r\nCòn lại: Bỏ các ký tự trắng ở đầu chuỗi, cắt lấycount ký tự ĐẦU và in kết quả ra màn hình\r\n");
            do
            {
                Console.Write("Nhập chuỗi: ");
                input = Console.ReadLine();
                check = str1.CheckString(input);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            } while (check == 1);

            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);

            } while (!check_num);
            Console.Write("Kết quả: ");
            new String12(input, number);
            Console.WriteLine("");

            Console.WriteLine("1.1.13. Như 12\r\nCòn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự ĐẦU và in kết quả ra \r\nmàn hình");
            do
            {
                Console.Write("Nhập chuỗi: ");
                input = Console.ReadLine();
                check = str1.CheckString(input);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            } while (check == 1);

            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);

            } while (!check_num);
            Console.Write("Kết quả: ");
            new String13(input, number);
            Console.WriteLine("");

            Console.WriteLine("1.1.14. Như 12\r\nCòn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự CUỐI và in kết quả ra \r\nmàn hình");
            do
            {
                Console.Write("Nhập chuỗi: ");
                input = Console.ReadLine();
                check = str1.CheckString(input);
                if (check == 1)
                {
                    Console.WriteLine("Chuỗi null, xin vui lòng nhập lại!");
                }
            } while (check == 1);

            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            new String14(input, number);
            Console.WriteLine("");

            Console.WriteLine("1.1. Int");
            Console.WriteLine("1.1.1. Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Nếu là số chẵn -> Thông báo: Số chẵn\r\nNếu là số lẻ -> Thông báo: Số lẻ");
            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            new Int1(number);
            Console.WriteLine("");

            Console.WriteLine("1.1.2. Input: 1 số (x)\r\nHiển thị trị tuyệt đối của x");
            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            new Int2(number);
            Console.WriteLine("");

            Console.WriteLine("1.1.3. Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Hiển thị 2 mũ x");
            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            new Int3(number);
            Console.WriteLine("");

            Console.WriteLine("1.1.4. Input: 2 số (X, Y) \r\nHiển thị kết quả: X chia Y bằng ... dư...");
            string number1;
            do
            {
                Console.Write("Nhập số thứ nhất: ");
                number1 = Console.ReadLine();
                check_num = int1.checkNumber(number1);
            } while (!check_num);

            string number2;
            do
            {
                Console.Write("Nhập số thứ hai: ");
                number2 = Console.ReadLine();
                check_num = int1.checkNumber(number2);
                if (check_num && int.Parse(number2) == 0)
                {
                    Console.WriteLine("Vui lòng nhập mẫu số khác không!");
                }
            } while (!check_num || int.Parse(number2) == 0);

            Console.Write("Kết quả: ");
            new Int4(number1, number2);
            Console.WriteLine("");

            Console.WriteLine("1.1.5. Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Nếu là số nguyên tố -> Thông báo: Số nguyên tố, ngược lại thông báo “Không phải số nguyên tố\r\n");
            do
            {
                Console.Write("Nhập số: ");
                number = Console.ReadLine();
                check_num = int1.checkNumber(number);
            } while (!check_num);
            Console.Write("Kết quả: ");
            new Int5(number);
            Console.WriteLine("");

            Console.WriteLine("1.1.6. Input: 1 chuỗi.\r\nNếu chuỗi là chuỗi số Int32 -> Thông báo: Chuỗi số.\r\nNgược lai -> Thông báo: Không phải chuỗi số");
            Console.Write("Nhập chuỗi số: ");
            number = Console.ReadLine();
            Console.Write("Kết quả: ");
            new Int6(number);
            Console.WriteLine("");
        }
    }
}
