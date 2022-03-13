using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection3
{
    class items
    {
        static void Main()
        {
            List<string> Stat = new List<string>();
            Stat.Add("bag");
            Stat.Add("compass");
            Stat.Add("pens");
            Stat.Add("pencils");
            Stat.Add("Books");
            Console.WriteLine("The Added Items are:");
            foreach (var item in Stat)
            {
              Console.WriteLine(item);
            }
              Console.Read();
        }
    }
}