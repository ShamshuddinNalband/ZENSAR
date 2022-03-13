using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class StringReverse
    {
        static void Main()
        {
            string str, rev = " ";

            Console.WriteLine("Enter the String to reverse:");
            str = Console.ReadLine();
            int len = str.Length - 1;
            while (len >= 0)
            {
                rev = rev + str[len];
                len--;
            }
            Console.WriteLine("String after reversing:{0}", rev);
        }

    }
}