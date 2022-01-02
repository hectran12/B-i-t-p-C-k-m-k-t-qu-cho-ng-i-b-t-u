using System;
using System.Text;

namespace random
{
    class Program
    {
        /// <summary>
        /// Random một số bất kì từ 1-1000
        /// </summary>
        /// <returns>kết quả random được</returns>
        static int randomde()
        {
            Random varan = new Random();
            int numberand = varan.Next(1001);
            return numberand;
        }
        /// <summary>
        /// Random theo tùy chỉnh
        /// </summary>
        /// <param name="a">Điều kiện số 1 ( bắt đầu ran từ số ? )</param>
        /// <param name="b">Điều kiện số 2 ( kết thúc ở số , lưu ý hãy +1 để chuẩn sát )</param>
        /// <returns>kết quả random được</returns>
        static int randomtuythich (int a, int b)
        {
            Random varan = new Random();
            int numberand = varan.Next(a,b);
            return numberand;
        }
        /// <summary>
        /// Random một double bất kì nhỏ hơn 1
        /// </summary>
        /// <returns>kết quả random</returns>
        static double randomdouble()
        {
            Random varan = new Random();
            double numberdo = varan.NextDouble();
            return numberdo;
        }
        static void menu()
        {
            string menu = "Nhập [1] random bất kì 1-1000\nNhập [2] rand theo tùy chọn\nNhập [3] random double bất kì nhỏ hơn 1\n";
            Console.Write(menu);
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
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
                bar(30);
                Console.Write("Nhập số bạn muốn vào đây: ");
                int choose;
                choose = Convert.ToInt32(Console.ReadLine());
                bar(30);
                if (choose == 1)
                {
                    int ketqua = randomde();
                    Console.WriteLine("Kết quả random là " + ketqua);
                }
                else if (choose == 2)
                {
                    Console.Write("Nhập số thứ 1: ");
                    int a, b;
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhập số thứ 2: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    int ketqua = randomtuythich(a, b);
                    Console.WriteLine("Số random giữa 2 số " + a + " và " + b + " có kết quả là " + ketqua);
                }
                else if (choose == 3)
                {
                    Console.WriteLine("Số random bất kì là " + randomdouble());
                }
                else
                {
                    Console.WriteLine("Bạn chưa nhập bất cứ thứ gì cả");
                }
                bar(30);
                Console.WriteLine("Enter để tiếp tục random");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
