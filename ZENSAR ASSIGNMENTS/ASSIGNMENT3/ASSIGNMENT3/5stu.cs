using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
    public struct Dob
    {
        public int Day;
        public int Month;
        public int Year;
    }

    struct Employee
    {
        public string Name;
        public Dob Date;
    }

    class NestedStructure
    {
        static void Main()
        {

            Employee[] emp = new Employee[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter The name of the employee{i + 1}: ");
                string name = Console.ReadLine();
                emp[i].Name = name;
                Console.WriteLine();

                Console.WriteLine("Enter the Dob---");
                Console.Write("The day of birth: ");
                int day = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = day;

                Console.Write("The month of birth: ");
                int month = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = month;

                Console.Write("The year of birth: ");
                int year = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Year = year;
                Console.WriteLine();
            }
        }
    }
}