using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class StringCompr
    {
        static void Main()
        {
            string str, str1;
            Console.WriteLine("Enter the first String:");
            str = Console.ReadLine();

            Console.WriteLine("Enter the Second String:");
            str1 = Console.ReadLine();

            if (str == str1)
            {
                Console.WriteLine("Strings are Same");
            }
            else
            {
                Console.WriteLine("Strings are not same");
            }
            Console.Read();

        }
    }
}