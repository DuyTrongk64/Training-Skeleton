using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    internal class Project
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string inputFile = "C:\\Users\\admin\\Documents\\Training Skeleton\\5. DataStorage\\5.DataStorage\\InPut.txt";
            string outputFile = "C:\\Users\\admin\\Documents\\Training Skeleton\\5. DataStorage\\5.DataStorage\\OutPut.txt";

            try
            {
                if (File.Exists(outputFile))
                {
                    ProcessInputFile(inputFile, outputFile);
                    Console.WriteLine("Xử lý thành công.");
                }
                else
                {
                    Console.WriteLine($"Lỗi: File đầu ra {outputFile} không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xảy ra lỗi: {ex.Message}");
            }
        }

        static void ProcessInputFile(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line;
                    int lineNumber = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;

                        try
                        {
                            string[] numbers = SplitByMultipleSpaces(line);
                            int[] parsedNumbers = new int[numbers.Length];

                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (!int.TryParse(numbers[i], out parsedNumbers[i]))
                                {
                                    throw new FormatException($"Số {numbers[i]} bị sai format (không phải kiểu Int32)");
                                }
                            }

                            Array.Sort(parsedNumbers, (a, b) => b.CompareTo(a));

                            foreach (int num in parsedNumbers)
                            {
                                if (num > int.MaxValue || num < int.MinValue)
                                {
                                    throw new OverflowException($"Số {num} vượt giới hạn kiểu Int32");
                                }
                                writer.Write($"{num:D4} ");
                            }
                            writer.WriteLine();
                        }
                        catch (Exception ex)
                        {
                            writer.WriteLine($"Dòng {lineNumber}: {ex.Message}");
                        }
                    }
                }
            }
        }

        static string[] SplitByMultipleSpaces(string input)
        {
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
