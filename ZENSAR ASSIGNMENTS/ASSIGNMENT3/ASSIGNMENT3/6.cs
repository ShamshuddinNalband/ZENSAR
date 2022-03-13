using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practice
{
    class Books
    {
        struct Authors
        {
            public string Title;
            public string Author;
        }

        static void Main()
        {

            Authors[] auth = new Authors[2];
            Console.WriteLine("Insert the information of two books");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Information of Book{0}", i + 1);
                Console.WriteLine("Name of the book: ");
                auth[i].Title = Console.ReadLine();
                Console.WriteLine("Author of the book: ");
                auth[i].Author = Console.ReadLine();
                Console.ReadLine();

            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Title = {0},\tAuthor = {1}\n", auth[i].Title, auth[i].Author);
            }
            Console.Read();


        }
    }
}