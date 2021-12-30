using System;
using System.Text;

namespace MinMax
{
    class Program
    {
        /// <summary>
        /// Hàm lấy số nhỏ nhất của 2 số
        /// </summary>
        /// <param name="a">Tham số 1</param>
        /// <param name="b">Tham số 2</param>
        /// <returns>Kết quả nhỏ nhất của 2 số </returns>
        static int Min (int a, int b)
        {
            return Math.Min (a,b);
        }

        /// <summary>
        /// Hàm lấy số lớn nhất của 2 số
        /// </summary>
        /// <param name="a">Tham số 1</param>
        /// <param name="b">Tham số 2</param>
        /// <returns>Kết quả lớn nhất giữa 2 số</returns>
        static int Max (int a, int b)
        {
            return Math.Max(a,b);
        }

        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b; // khai báo 2 biến a b dưới kiểu dữ liệu interger
            Console.WriteLine("Nhập số thứ 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Bạn muốn max hay min ?: ");
            string maxormin;
            maxormin = Console.ReadLine();
            int ketqua;
            string textoutput;
            if (maxormin == "min")
            {
                ketqua = Min(a,b);
                textoutput = "Số nhỏ nhất của 2 số " + a + " và " + b + " kết quả là " + ketqua;
                Console.WriteLine(textoutput);
            } else if (maxormin == "max")
            {
                ketqua = Max(a,b);
                textoutput = "Số lớn nhất của 2 số " + a + " và " + b + " kết quả là " + ketqua;
                Console.WriteLine(textoutput);
            } else
            {
                Console.WriteLine("Chỉ nhập min hoặc max không nhập gì khác ngoài 2 cái này");
                System.Environment.Exit(1);
            }
            Console.ReadLine();
        }
    }
}
