using System;
using System.Text;
namespace tinhcb2 { 
    class Program
    {
        /// <summary>
        /// Hàm tính căn bậc 2 , trong đây mình sử dụng thư viện math có sắn của c#
        /// </summary>
        static void canbachai()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số cần tính căn bậc 2: ");
            int cb2;
            cb2 = Convert.ToInt32(Console.ReadLine());
            int tinhtoan;
            Console.WriteLine("Căn bậc 2 của {0} là {1}", cb2, Math.Sqrt(cb2));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            canbachai();
        }
    }
}
