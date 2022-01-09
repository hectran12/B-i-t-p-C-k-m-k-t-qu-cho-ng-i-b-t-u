using System;
using System.Text;
namespace remove
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.Write("Nhap mot van ban can xoa: ");
            string txt = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Co " + txt.Length + " trong doan van ban");
            Console.Write("Nhap vi tri bat dau: ");
            int vitridau = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri xoa ket thuc: ");
            int ketthuc = Convert.ToInt32(Console.ReadLine());
            string kq = txt.Remove(vitridau, ketthuc);
            Console.Write(kq);
        }
    
    }

}
