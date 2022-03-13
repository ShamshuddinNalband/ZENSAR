//Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections
{
    class Products
    {
        int Pid;
        string PName;
        public double Price;

        public Products(int id, string name, double price)
        {
            Pid = id;
            PName = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product Id: {Pid} Name: {PName} costs: {Price}";
        }
    }

    class Collection2
    {
        static void Main()
        {
            List<Products> plist = new List<Products>();
            plist.Add(new Products(24, "Laptop", 49999.00));
            plist.Add(new Products(12, " TV", 34999.00));
            plist.Add(new Products(36, "Washing Machine", 45999.00));
            plist.Add(new Products(55, "mobile Phone", 16999.00));
            plist.Add(new Products(25, "hometheatre", 42999.00));


            plist.Sort(delegate (Products a, Products b)
            {
                return a.Price.CompareTo(b.Price);
            });

            Console.WriteLine("List after Sorting------");

            Console.WriteLine(String.Join(Environment.NewLine, plist));
        }
    }

}