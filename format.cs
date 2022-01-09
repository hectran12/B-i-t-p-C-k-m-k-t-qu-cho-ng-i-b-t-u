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
            if (num == 1)
            {
                Console.Write("Nhap van ban: ");
                int text = Convert.ToInt32(Console.ReadLine());
                string result;
                result = String.Format("Chi so {0:N} ", text);
                Console.WriteLine(result);
            }
            else if (num == 2)
            {
                Console.Write("Nhap van ban: ");
                int text = Convert.ToInt32(Console.ReadLine());
                string result;
                result = String.Format("Chi so {0:C} ", text);
                Console.WriteLine(result);
            }
            else if(num == 3)
            {
                string date = string.Format("hom nay la {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                Console.WriteLine(date);
            }
            else
            {
                Console.Write("Khong co gi duoc thuc thi");
            }
            Console.ReadLine();
        }

        static void Menu()
        {
            string menu;
            menu = "Nhap [1] format math\n";
            menu += "Nhap [2] format dolla\n";
            menu += "Nhap [3] format date";
            Console.WriteLine(menu);
        }
      
    }

}
