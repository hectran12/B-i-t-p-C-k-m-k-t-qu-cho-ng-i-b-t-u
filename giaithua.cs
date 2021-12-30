using System;
using System.Text;

namespace giaithua
{
    class Program { 
        /// <summary>
        /// Tính giai thừa của một số
        /// </summary>
        /// <param name="a">Đưa rham số cần tính giai thưa vào</param>
        /// <returns>kết quả giai thừa</returns>
        static int TinhGiaiThua(int a)
        {
            int gt = 1;
            for(int i = 1; i <= a; i++)
            {
                gt *= i;
            }
            return gt;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số cân tính giai thừa: ");
            int num;
            num = int.Parse(Console.ReadLine());
            int kq;
            kq = TinhGiaiThua(num);
            Console.WriteLine("Kết quả giai thừa của số {0} : {1}", num, kq);
            Console.ReadLine();
        }
        
    }
}
