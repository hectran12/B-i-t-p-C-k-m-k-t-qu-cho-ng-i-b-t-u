using System;
using System.Collections.Generic;
using System.Text;

namespace listINT
{
    class Program
    {
        static void Main (string[] args)
        {
            List<int> v = new List<int>();
            Random rd = new Random();
            Console.Write("Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                v.Add(rd.Next(100));
            }
            Console.WriteLine("Non sort:");
            foreach (int i in v)
            {
                Console.Write(i + "\t");
            }Console.WriteLine();
            v.Sort();
            Console.WriteLine("Sort:");
            foreach (int i in v)
            {
                Console.Write(i + "\t");
            }
        }
    }
}
