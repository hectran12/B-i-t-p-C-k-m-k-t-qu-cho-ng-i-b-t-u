using System;
using System.Text;
namespace endswith
{
    class Program { 
    
    
        static void Main(string[] args)
        {
            Console.Write("Nhap mot ki tu bat ki: ");
            string nhap = Convert.ToString(Console.ReadLine());
            Console.Write("Kiem tra no ket thuc bang: ");
            string end = Convert.ToString(Console.ReadLine());
            bool kiemtra;
            kiemtra = nhap.EndsWith(end);
            string result = kiemtra == true?"Co ket thuc bang":"khong ket thuc bang";
            Console.Write(result + " " + end);
            Console.ReadLine();
        }

    }


}
