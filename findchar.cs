using System;
using System.Text;
namespace conta
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input your text: ");
            string text;
            text = Convert.ToString(Console.ReadLine());
            findstring(text);
        }


        static void findstring(string text)
        {
            Console.Write("String can find: ");
            string find = Convert.ToString(Console.ReadLine());
            string output = "";
            string output2 = "";
            bool result;
            int ab=0;
            result = text.Contains(find);
            if (result)
            {
                for (int i = 0; i < text.Length + 1; i++)
                {
                    i = i + 1;

                    if (i < text.Length + 1)
                    {
                        int a = i - 1;
                        // convert
                        string str1, str2;
                        try
                        {
                            str1 = Convert.ToString(text[i]);
                        } catch
                        {
                            str1=Convert.ToString(text[i]);
                        }
                        
                        str2 = Convert.ToString(text[a]);

                        if (str2.Contains(find))
                        {
                            output += "[Local: " + a + " String: " + str2 + "]\n";
                            output2 += "["+str2 + "]";
                            ab = 1;
                        }
                        if (str1.Contains(find))
                        {
                            output += "[Local: " + i + " String: " + str1 + "]\n";
                            output2 += "[" + str1+ "]";
                            ab = 2;
                        }
                        if (ab== 0)
                        {
                            output2 += str2 + str1;
                        } else if(ab == 1)
                        {
                            output2 += str1;
                        } else if(ab == 2)
                        {
                            output2 += str2;
                        }
                        ab= 0;


                    }
                }
                Console.Write(output);
                Console.WriteLine(output2);
            }
        }
    }

}
