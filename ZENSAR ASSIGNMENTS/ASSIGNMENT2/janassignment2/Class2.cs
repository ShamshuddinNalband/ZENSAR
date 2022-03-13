using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentclass
{
    class Student
    {

        int RollNo;
        string Name;
        string Class;
        int Semister;
        string Branch;
        int sum = 0;
        int avg;
        int[] marks = new int[5];
        public Student(int rollno, string name, string StudClass, int sem, string branch)
        {
            RollNo = rollno;
            Name = name;
            Class = StudClass;
            Semister = sem;
            Branch = branch;

        }
        public void DisplayResults()
        {
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Enter the sub{0} marks of Student :", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / 5;
            Console.WriteLine("The Average is:{0}", avg);

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {

                    Console.WriteLine("Student FAILED");
                }
                else if ((marks[i] > 35) && (avg < 50))
                {
                    Console.WriteLine("Student FAILED");
                }
                else
                {
                    Console.WriteLine("Student PASSED");
                }
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("The Student details are:");
            Console.WriteLine($"RollNo:{RollNo} Name: {Name}");
            Console.WriteLine($"Class:{Class}  Semister:{Semister}  Branch:{Branch}");
            DisplayResults();
        }


        static void Main()
        {
            Student Stud = new Student(535, "ash", "B.Tech", 6, "CSE");
            Stud.DisplayData();
            Console.ReadLine();
        }
    }
}