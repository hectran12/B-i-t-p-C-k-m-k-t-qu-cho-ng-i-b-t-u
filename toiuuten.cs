using System;
using System.Text;
namespace toiuuten
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một tên: ");
            string ten = Convert.ToString(Console.ReadLine());
            ToUU(ten);
        }
        static void ToUU (string ten)
        {
            string newt1 = ten.Trim();
            string[] newt2 = newt1.Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries);
            string newten = "";
            foreach (string pt in newt2)
            {
                string ptz = Convert.ToString(pt);
                ptz = ptz.ToLower();
                char[] giaikitu = ptz.ToCharArray();
                giaikitu[0] = char.ToUpper(giaikitu[0]);
                string newchar = new string(giaikitu);
                newten += newchar + " ";
            }
            Console.Write(newten);
        }
    }
}
