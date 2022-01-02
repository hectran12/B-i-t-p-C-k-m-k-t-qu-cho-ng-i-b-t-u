using System;
using System.Text;
namespace thuvienmath
{
    class Program
    {
        /// <summary>
        /// Hàm tính căn bậc 2 , trong đây mình sử dụng thư viện math có sắn của c#
        /// </summary>
        static void canbachai()
        {
            Console.WriteLine("Nhập số cần tính căn bậc 2: ");
            int cb2;
            cb2 = Convert.ToInt32(Console.ReadLine());
            int tinhtoan;
            Console.WriteLine("Căn bậc 2 của {0} là {1}", cb2, Math.Sqrt(cb2));
        }
        /// <summary>
        /// Hàm tính lũy thừa
        /// </summary>
        static void LuyThua()
        {
            Console.WriteLine("Nhập số thứ 1: ");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số thứ 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lũy thừa của 2 số {0} và {1} là {2} ", a, b, Math.Pow(a, b));
        }
        /// <summary>
        /// Hàm tính lưỡng giác
        /// </summary>
        static void LuongGiac()
        {
            Console.WriteLine("Nhập vào một gốc: ");
            int goc;
            goc = Convert.ToInt32(Console.ReadLine());
            double tinhchia;
            tinhchia = Math.PI * goc / 180;
            bar(30);
            string menucossin = "Nhập [1] tính sin\nNhập [2] tính sin\nNhập [3] tính cotan\n";
            Console.WriteLine(menucossin);
            bar(30);
            Console.WriteLine("Nhập số vào: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            bar(30);
            if (num == 1)
            {
                Console.WriteLine("Sin của gốc {0} là {1} ", goc, Math.Sin(tinhchia));
            }
            else if (num == 2)
            {
                Console.WriteLine("Cos của gốc {0} là {1} ", goc, Math.Cos(tinhchia));
            }
            else if (num == 3)
            {
                Console.WriteLine("Costan của gốc {0} là {1} ", goc, 1 / Math.Cos(tinhchia));
            }
            else
            {
                Console.WriteLine("Kết quar của sin lẫn cos do bạn không chịu nhập gì");
                Console.WriteLine("Sin của gốc {0} là {1} ", goc, Math.Sin(tinhchia));
                Console.WriteLine("Cos của gốc {0} là {1} ", goc, Math.Cos(tinhchia));
                Console.WriteLine("Costan của gốc {0} là {1} ", goc, 1 / Math.Cos(tinhchia));
            }

        }
        /// <summary>
        /// Hàm làm tròn 
        /// </summary>
        static void LamTron()
        {
            Console.WriteLine("Nhập 1 sô muốn làm tròn: ");
            double so;
            so = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập giới hạn số làm tròn: ");
            int gioihan;
            gioihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số ban đầu {0}, sau khi làm tròn {1}", so, Math.Round(so, gioihan));
        }
        static void menu()
        {
            string menu = "hập [1] Tính Căn Bặc 2\nNhập [2] Tính Lũy Thừa\nNhập [3] để tính lượng giác (cos/sin/costan)\nNhập [4] để làm tròn số\n";
            Console.WriteLine(menu);

        }
        static void bar(int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                menu();
                Console.WriteLine("Nhập số bạn muốn: ");
                int choose;
                choose = Convert.ToInt32(Console.ReadLine());
                bar(30);
                if (choose == 1)
                {
                    canbachai();
                }
                else if (choose == 2)
                {
                    LuyThua();
                }
                else if (choose == 3)
                {
                    LuongGiac();
                }
                else if (choose == 4)
                {
                    LamTron();
                } else {
                    Console.WriteLine("Vui lòng nhập lại");
                }
                Console.WriteLine("Enter để tiếp tục tính toán");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
