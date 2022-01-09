using System;
using System.Text;
namespace format
{
    class Program 
    {

        static void Main (string[] args)
        {
            Menu();
            Console.Write("Nhap so: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 1)
            {
                Console.Write("Nhap chuoi thu nhat: ");
                string c1 = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap chuoi thu hai: ");
                string c2 = Convert.ToString (Console.ReadLine());
                string kq;
                kq = c1.Insert(c1.Length, c2);
                Console.WriteLine(kq);
            }else if(num == 2)
            {
                Console.Write("Nhap van ban: ");
                string vb = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap ki tu muon tim: ");
                string find = Convert.ToString(Console.ReadLine());
                int kqfind = vb.IndexOf(find);
                Console.Write("Nam o vi tri {0} ", kqfind);
            }else if(num == 3)
            {
                Console.Write("Nhap van ban: ");
                string vb = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap ki tu muon tim: ");
                string find = Convert.ToString(Console.ReadLine());
                int kqfind = vb.LastIndexOf(find);
                Console.Write("Nam o vi tri {0} ", kqfind);
            }
            else
            {
                Console.Write("Khong ro i cua ban");
            }
            Console.ReadLine();
        }

        static void Menu()
        {
            string menu;
            menu = "Nhap [1] Insert (noi chuoi)\n";
            menu += "Nhap [2] indexof ( tim vi tri dau )\n";
            menu += "Nhap [3] lastindexof ( tim vi tri cuoi )\n";
            Console.WriteLine(menu);
        }
      
    }

}
