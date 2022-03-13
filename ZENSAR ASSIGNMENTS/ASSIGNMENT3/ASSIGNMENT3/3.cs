using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails(int id, string name);
    }

    class Dayscholar : IStudent
    {
        private int StuId;

        public string Name { get; set; }

        public int StudentId
        {
            get { return StuId; }
            set { StuId = value; }
        }

        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("The details of dayscholar student is:");
            Console.WriteLine($"ID: {id} and Name: {name}");
        }
    }

    class Resident : IStudent
    {
        private int StuId;
        public string Name { get; set; }

        public int StudentId
        {
            get { return StuId; }
            set { StuId = value; }
        }

        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("The details of residential student is:");
            Console.WriteLine($"ID: {id} and Name: {name}");
        }
    }

    class InterfaceEg
    {
        static void Main()
        {
            IStudent ds = new Dayscholar();
            ds.StudentId = 531;
            ds.Name = "ram";
            ds.ShowDetails(ds.StudentId, ds.Name);
            IStudent rs = new Resident();
            rs.StudentId = 558;
            rs.Name = "Kishore";
            rs.ShowDetails(rs.StudentId, rs.Name);
        }
    }
}