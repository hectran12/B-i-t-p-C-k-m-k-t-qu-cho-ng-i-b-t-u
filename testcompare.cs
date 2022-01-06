using System;
using System.Text;

namespace nonam
{

    class Program
    {
        static void tinh(char a, char b)
        {
            char ketqua;
            ketqua = (char)a.CompareTo(b);
            Console.WriteLine(ketqua);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhập chữ thứ nhất: ");
                char ch1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Nhập chữ thứ hai: ");
                char ch2 = Convert.ToChar(Console.ReadLine());
                tinh(ch1, ch2);
                Console.ReadLine();
                Console.Clear();
            }

        }


    }

}
