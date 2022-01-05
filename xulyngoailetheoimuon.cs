using System;
using System.Text;

namespace xulyngoaile
{
    class Program
    {
        static void TimLOI()
        {
            Console.WriteLine("Nhập 0 sẽ xuất ra lỗi: ");
            int nhapso = Convert.ToInt32(Console.ReadLine());
            if (nhapso == 0)
                throw new ArithmeticException("Xuấ lỗi rồi nè");
        }
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                TimLOI();
            } catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
