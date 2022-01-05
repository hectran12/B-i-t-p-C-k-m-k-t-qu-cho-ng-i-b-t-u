using System;
using System.Text;

namespace xulyngoaile
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập ngày tháng năm sinh của bạn: ");
                string ngaythangnamsinh = Console.ReadLine();
                DateTime change = DateTime.Parse(ngaythangnamsinh);
                Console.WriteLine(change.ToString("dd/MM/yyyy"));
                Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Bạn đang xem dưới dạng dd/MM/yyyy");
            }
            Console.ReadLine();
        }
    }
}
