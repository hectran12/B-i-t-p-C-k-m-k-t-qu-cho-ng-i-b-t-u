using System;
using System.Text;

namespace Copyto
{
    class Program
    {

        static void Main (string[] args)
        {
           // Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhap doan ki tu muon copy: ");
            string mytext;
            mytext = Convert.ToString(Console.ReadLine());
            Console.Write("Bat dau copy tu vi tri: ");
            int vitridau;
            vitridau = Convert.ToInt32(Console.ReadLine());
            int tinhtoan = Convert.ToInt32(mytext.Length) - vitridau;
            string kqtt = Convert.ToString(tinhtoan);
            Console.Write("Muon copy bao nhieu ki tu?\n");
            Console.WriteLine("Doan van ban hien tai co do dai khoang " + kqtt + " ki tu");
            Console.Write("Moi ban nhap: ");
            int dodaimuoncopy;
            dodaimuoncopy = Convert.ToInt32(Console.ReadLine());
            if (dodaimuoncopy <= mytext.Length - vitridau)
            {
                Console.Write("Nhap doan van ban ban muon gan vao: ");
                string paste = Convert.ToString(Console.ReadLine());
                char[] mang = new char[vitridau];
                mang = paste.ToCharArray();
                mytext.CopyTo(vitridau, mang, 2, 3);
                Console.Write(mang);
            }
         
        }
    
    }

}
