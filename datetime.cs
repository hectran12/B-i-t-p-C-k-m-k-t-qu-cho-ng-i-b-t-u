using System;
using System.Text;


namespace datetime
{



    class Program {


        static void compdate ()
        {
            int year,month,day;
            Console.WriteLine("Nhập năm: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tháng: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập ngày: ");
            day = Convert.ToInt32(Console.ReadLine());
            DateTime vardate = new DateTime(year,month,day);
            Console.WriteLine("Nhập dạng hiển thị ( ex: dd/MM/yyy ): ");
            string kieuhienthi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Kết quả là: " + vardate.ToString(kieuhienthi));
        }
        static void phanloaidate()
        {
            Console.WriteLine("Nhập ngày tháng năm sinh của bạn: ");
            //DateTime vardate = new DateTime();
            string nhap = Console.ReadLine();
            DateTime comp = DateTime.Parse(nhap);
            string text = "Ngày " + comp.Day + " tháng " + comp.Month + " Năm " + comp.Year + "\n";
            Console.Write(text);
        }
        static void bar(int amount)
        {
            for (int i = 1; i <= amount; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
        static void menu()
        {
            string menu = "Nhập [1] để nhập thời gian và xuất theo dạng yêu cầu\nNhập [2] xuất date theo comp\n";
            Console.Write(menu);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();
                bar(30);
                Console.Write("Nhập số mà bạn muốn thực hiện: ");
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                bar(30);
                if (num == 1)
                {
                    compdate();
                }else if(num == 2)
                {
                    phanloaidate();
                }
                else
                {
                    Console.WriteLine("Bạn chưa nhập gì hết");
                }
                bar(30);
                Console.WriteLine("Enter để tiếp tục");
                Console.ReadLine();
                Console.Clear();

            }
            
        }
    
    
    }


}
