//Create a class library CalculateConcession ()  that takes age as an input and calculates concession for travel as below:
//If age<=5 then “Little Champs- Free Ticket” should be displayed
//If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500 / -) and Display “ Senior Citizen” + Calculated Fare
//Else “Print Ticket Booked” + Fare. 
//Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.  Accept Name, Age from the user and call the CalculateConcession() function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConcession;

namespace Assignment4
{
    class Program
    {
        static void Main()
        {
            int TotalFare = 500;
            string Name;
            int Age;
            Console.WriteLine("Enter Citizen Name: ");
            Name = Console.ReadLine();
            Concession cc = new Concession();
            cc.CalculateConcession1();
            Console.Read();


        }
    }

}



     