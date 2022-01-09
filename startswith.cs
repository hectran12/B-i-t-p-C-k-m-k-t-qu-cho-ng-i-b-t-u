
using System;
using System.Text;
namespace StartsWith
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Nhap mot ki tu bat ki: ");
            string nhap = Convert.ToString(Console.ReadLine());
            Console.Write("Kiem tra no bat dau bang: ");
            string end = Convert.ToString(Console.ReadLine());
            bool kiemtra;
            kiemtra = nhap.StartsWith(end);
            string result = kiemtra == true ? "Co bat dau bang" : "khong bat dau bang";
            Console.Write(result + " " + end);
            Console.ReadLine();
        }

    }


}
