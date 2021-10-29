using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string[] stringArray = str1.Split();
            string resultStr = "";
            int strLen = 0;
            int i = 0;
            int j = 0;
            foreach (string s in stringArray)
            {
                i++;
                if ( strLen < s.Length)
                {
                    strLen = s.Length;
                    resultStr = s;
                    j = i;
                }
            }    
            Console.WriteLine("самое длинное слово {0}  по счету {1}",resultStr,j);
            Console.ReadKey();
        }
    }
}
