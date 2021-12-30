using System;
using System.Text;

namespace refsss
{
    class Program
    {
        static void FN1 (ref int b)
        {
            b = b + 5;
        }
        static void Main (string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int b = 2;
            Console.WriteLine("Biến b ban đầu {0} ", b);
            FN1(ref b);
            Console.WriteLine("Biến b lúc sau {0} ", b);
        }
    }
