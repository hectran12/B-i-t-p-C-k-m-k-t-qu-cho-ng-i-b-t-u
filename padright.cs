using System;
using System.Text;
namespace padright
{
    class Program
    { 

        static void Main (string[] args)
        {
            echo("Nhập văn bản: ");
            string txt = Convert.ToString(Console.ReadLine());
            string kq;
            echo("Nhập độ dài: ");
            int dodai = Convert.ToInt32(Console.ReadLine());
           
            echo("Nhâp kí tự: ");
            string kitu = Convert.ToString (Console.ReadLine());
         
            kq = txt.PadRight(dodai, Convert.ToChar(kitu));
            echo(kq);
        }

        static void echo (string text)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(text);
        }
    }

}
