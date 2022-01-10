using System;
using System.Text;

namespace diachi
{
    class Program
    {

        static void Main (string[] args)
        {
            Console.Write("Nhap dia chi bai hat: ");
            string music = Convert.ToString(Console.ReadLine());
            // XU LY
            int find = music.IndexOf('/');
            string cut = music.Substring(find + 1);
            int findcham = music.LastIndexOf('.');
            string kq = cut.Substring (0,findcham-1);
     

            Console.WriteLine(kq);
        }

    
    }
    
}
