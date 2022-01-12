using System;
using System.Text;

namespace locmang
{
    class Program
    {
        static void Main (string[] args)
        {
            int sorand = 15;
            int[] mang = new int[sorand];
            Random random = new Random();
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] = random.Next(100);
            }
            Console.WriteLine("So random:");
            foreach (int i in mang)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Nhap so muon tim: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rs = -1;
            for (int i = 0;i < mang.Length; i++)
            {
                if(mang[i] == num)
                {
                    rs = i;
                    break;
                }
            }
            if (rs < 0)
            {
                Console.Write("Null");
            } else
            {
                Console.Write("Vi tri tim thay {0}: ", rs);
            }
        }
    }
}
