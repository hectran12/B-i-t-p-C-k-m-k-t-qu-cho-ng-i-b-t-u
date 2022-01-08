using System;
using System.Text;
namespace compare
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Input A: ");
            string a, b;int result;
            a = Convert.ToString(Console.ReadLine());
            Console.Write("Input B: ");
            b = Convert.ToString(Console.ReadLine());
            result = a.CompareTo(b);
            if (result == 0)
            {
                Console.Write("there is a similarity");
            }
            else
            {
                Console.Write("there is no similarity");
            }
            Console.ReadLine();
        }
    
    }

}

