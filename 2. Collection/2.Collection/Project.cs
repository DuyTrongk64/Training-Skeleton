using System;
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
        static List<int> crateList()
        {
            List<int> numberList = new List<int>();

            // Thêm 10 số bất kỳ vào danh sách
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = new Random().Next(1, 100); // Số nguyên ngẫu nhiên từ 1 đến 100
                numberList.Add(randomNumber);
            }

            return numberList;
        }

        static bool checkNumber(string number)
        {
            try
            {
                int num = int.Parse(number);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng không hợp lệ. Hãy nhập một số nguyên.");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Số quá lớn hoặc quá nhỏ để được biểu diễn bởi kiểu int. Hãy nhập một số nguyên.");
                return false;
            }
        }
        static void Main(string[] args)
        {
            List<int> numberList;
            string number;
            bool check_num;

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("2.1. List");
            Console.WriteLine("2.1.1. Input: None\r\nTạo 1 danh sách số int\r\nThêm vào danh sách 10 số bất kỳ\r\nIn kết quả ra màn hình và trả về danh sách vừa tạo");
            Console.Write("Kết quả: ");
            numberList = crateList();
            new List1(numberList);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.2. Input: danh sách 10 số bất kỳ\r\nSắp xếp danh sách theo thứ tự tăng dần, in kết quả ra màn hình");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nKết quả: ");
            new List2(numberList);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.3. Input: danh sách 10 số bất kỳ\r\nĐảo ngược vị trí các số trong danh sách, in kết quả ra màn hình");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nKết quả: ");
            new List3(numberList);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.4. Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số nhỏ hơn X khỏi danh sách, in kết quả ra màn hình");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }
            
            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = checkNumber(number);
            } while (!check_num);
            Console.Write("\nKết quả: ");
            new List4(numberList,number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.5. Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số chia hết cho X khỏi danh sách, in kết quả ra màn hình");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = checkNumber(number);
                if (check_num&&int.Parse(number) == 0)
                {
                    Console.WriteLine("Vui lòng nhập số khác 0!");
                }
            } while (!check_num|| int.Parse(number) == 0);
            Console.Write("\nKết quả: ");
            new List5(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.6. Input: danh sách 10 số bất kỳ và 1 số (X)\r\nVới mỗi số trong danh sách, nếu nhỏ hơn X thì cộng với X\r\nIn kết quả ra màn hình");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = checkNumber(number);
            } while (!check_num);
            Console.Write("\nKết quả: ");
            new List6(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.7. Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = checkNumber(number);
                if (check_num&&int.Parse(number) <= 0)
                {
                    Console.WriteLine("Vui lòng nhập lớn hơn 0!");
                }
            } while (!check_num || int.Parse(number) <= 0);
            Console.Write("\nKết quả: ");
            new List7(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.8. Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình theo chiều ngược lại");
            numberList = crateList();
            Console.Write("Chuỗi: ");
            foreach (int num in numberList)
            {
                Console.Write(num + " ");
            }

            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = checkNumber(number);
                if (check_num&&int.Parse(number) <= 0)
                {
                    Console.WriteLine("Vui lòng nhập lớn hơn 0!");
                }
            } while (!check_num || int.Parse(number) <= 0);
            Console.Write("\nKết quả: ");
            new List8(numberList, number);
            Console.WriteLine("\n");

            Console.WriteLine("2.1.9. Input: 1 số lớn hơn 0 (X)\r\nin ra dãy (tối đa 10 giá trị) số thuộc dãy fibonaci < số nhập vào");
            numberList = crateList(); 
            do
            {
                Console.Write("\nNhập số: ");
                number = Console.ReadLine();
                check_num = checkNumber(number);
                if (check_num&&int.Parse(number) <= 0)
                {
                    Console.WriteLine("Vui lòng nhập lớn hơn 0!");
                }
            } while (!check_num || int.Parse(number) <= 0);
            Console.Write("\nKết quả: ");
            new List9(number);
            Console.WriteLine("\n");
        }
    }
}
