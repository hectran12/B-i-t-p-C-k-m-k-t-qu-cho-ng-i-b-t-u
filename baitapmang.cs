using System;

namespace baitapmang
{
    class Program
    {
        static void Main(string[] args)
        {
            Xuly();
            Console.ReadLine();
        }
        static void Xuly()
        {
            Console.Write("Nhap so luong: ");
            int soluong = Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[soluong];
            Random rd = new Random();
            for (int i = 0; i < soluong; i++)
            {
                mang[i] = rd.Next(100);
            }
            Console.Write("Cac gia tri ngau nhien: ");
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }Console.WriteLine();
            Console.Write("Dao nguoc: ");
            Array.Reverse(mang);
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sap xep mang: ");
            Array.Sort(mang);
            foreach(int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int tong = 0;
            foreach (int i in mang)
            {
                tong = tong + i;
            }
            Console.Write("Tong gia tri trong mang la: " + tong +" do dai la: "+mang.Length);
          
        }
    }
}
