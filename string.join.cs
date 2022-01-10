using System;
using System.Text;

namespace joinarray
{
    class Program
    {
        static void Main (string[] args)
        {
            string[] mang = new string[3];
            mang[0] = "Tran";
            mang[1] = "Trong";
            mang[2] = "Hoa";
            string kq = string.Join('*', mang);
            Console.Write(kq);
        }
    }
}
