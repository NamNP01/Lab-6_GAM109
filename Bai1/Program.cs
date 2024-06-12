using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_1
{
    class Program
    {
        static void Main()
        {
            List<int> listInt = new List<int> { 2, 4, 5, 6, 7, 8, 9 };
            List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
            List<string> listNull = new List<string>();

            int FirstEvenGreaterThan5 = listInt.FirstOrDefault(num => num > 5 && num % 2 == 0);
            var LastEven200 = listInt.LastOrDefault(num => num > 200);
            var FirstEle = listStr.FirstOrDefault(str => str != null && str.StartsWith("T", StringComparison.OrdinalIgnoreCase));

            if (FirstEvenGreaterThan5 != 0)
            {
                Console.WriteLine($"so chan dau tien lon hon 5 trong danh sach la: {FirstEvenGreaterThan5}");
            }
            else
            {
                Console.WriteLine("khong tim thay so chan nao lon hon 5 trong danh sach.");
            }




            if (LastEven200 != 0)
            {
                Console.WriteLine($"So chan cuoi co gia tri lon hon 200 la: {LastEven200}");
            }
            else
            {
                Console.WriteLine("Khong tim thay so chan nao co gia tri lon hon 200");
            }

            if (FirstEle != null)
            {
                Console.WriteLine($"phần tử đầu tiên bắt đầu bằng ký tự T là: {FirstEle} ");
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
            Console.ReadLine();
        }
    }
}