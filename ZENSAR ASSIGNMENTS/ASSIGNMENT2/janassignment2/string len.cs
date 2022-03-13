using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string str;
            int length;
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            length = str.Length;
            Console.WriteLine("The given string length is :{0}", length);

        }
    }
}
