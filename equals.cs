using System;
using System.Text;
namespace squa
{
    class Program
    {
        static void Main (string[] args)
        {
            char A, B, C;
            A = 'A';
            B = 'b';
            C = (char)65;
            Console.WriteLine(A.Equals(C));
            Console.WriteLine(A.Equals(B));

        }
    }
}
