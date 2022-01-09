using System;
using System.Text;
namespace substring
{
    class Program 
    { 
        static void Main (string[] args)
        {
            Console.Write("Nhap mot doan van ban: ");
            string txt = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap vi tri dau: ");
            int vitridau = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri ket thuc: ");
            int vitriketthuc = Convert.ToInt32(Console.ReadLine());
            string x = txt.Substring(vitridau, vitriketthuc);
            Console.Write(x);
        }
    }

}
