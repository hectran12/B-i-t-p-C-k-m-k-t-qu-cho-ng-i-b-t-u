using System;
using System.Text;

namespace ptrinhb1
{
    class Program
    {
        /// <summary>
        /// hàm tính phương trình bậc 1
        /// </summary>
        /// <param name="a">Tham số thứ 1</param>
        /// <param name="b">Tham số thứ 2</param>
        /// <returns>In ra kết quả nha</returns>
        static string PhuongTrinhBac1 (double a, double b)
        {
            if (a == 0 && b == 0) { return "Phương trình vô số nghiệm";  }
            else if (a == 0 && b != 0) { return "Phương trình vô nghiệm";  };
            return "Kết quả của x là: " + (-b / a);

        }
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b;
            Console.WriteLine("Nhập số thứ 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập sô thứ 2: ");
            b = int.Parse(Console.ReadLine());
            string ketqua;
            ketqua = PhuongTrinhBac1(a, b);
            Console.WriteLine(ketqua);
        }
    }
}
