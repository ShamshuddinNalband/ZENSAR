using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        public struct Books
        {
            private int Book_id;

            public int ID
            {
                get { return Book_id; }
                set { Book_id = value; }
            }

            public void DisplayID(int id)
            {
                Console.WriteLine("Id of the book: " + id);
            }
        }

        static void Main(string[] args)
        {
            Books bk = new Books();
            bk.ID = 43;
            bk.DisplayID(bk.ID);
        }
    }
}