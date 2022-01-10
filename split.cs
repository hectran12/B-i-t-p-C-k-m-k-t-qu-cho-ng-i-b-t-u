using System;
using System.Text;

namespace split
{ 
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Nhap mot doan van ban: ");
            string text = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ki tu ngan cach mot cat: ");
            string cat = Convert.ToString (Console.ReadLine());
            string[] mang = text.Split(Convert.ToChar(cat));
            string all = "";
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write("So {0} la gi: ", i);
                string name = Convert.ToString(Console.ReadLine());
                all += name + ": " + mang[i]+"\n";
            }
            Console.Write(all);
            Console.ReadLine();
        }
    }

}
