using System;
using System.Text;

namespace trimketthuc
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Nhap mot chuoi: ");
            string chuoi = Convert.ToString(Console.ReadLine());
            string kq = chuoi.TrimEnd();
            Console.WriteLine(kq);


        }
    } 
    
}
