using System;
using System.Text;
namespace replace
{

    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Nhap mot chuoi can thay doi: ");
            string txt = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ki tu muon thay doi: ");
            string rep = Convert.ToString (Console.ReadLine());
            Console.Write("Thay doi thanh: ");
            string rep1 = Convert.ToString (Console.ReadLine());
            string kq = txt.Replace(rep, rep1);
            Console.Write(kq);
        }
    }
}

