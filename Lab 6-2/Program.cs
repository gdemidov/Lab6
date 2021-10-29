using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = Console.ReadLine();//
            string str1 = "А роза упала на лапу Азора";//что бы не вводить палиндром
            //string str1 = "1234567890";//что бы не вводить НЕ палиндром
            str1 = str1.ToLower();
            string[] stringArray1 = str1.Split();
            str1 = String.Join("",stringArray1);
            int strLen1 = str1.Length;
            int j = strLen1;
            string str2 = "";
            for (int i = 0; i < strLen1; i++)
            {
                j--;
                str2 += str1.Substring(j, 1);
            }
            if (str1==str2)
            {
            Console.WriteLine("{0} Палиндром {1}  ",str2,str1);
            }
            else
            {
            Console.WriteLine("{0} НЕ палиндром {1}",str2,str1);
            }
            Console.ReadKey();
        }
    }
}
