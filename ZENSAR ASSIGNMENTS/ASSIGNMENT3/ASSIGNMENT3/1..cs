using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class BookingException : ApplicationException
    {
        public BookingException(string msg) : base(msg)
        {
        }
    }

    class Booking
    {
        int tickets;

        public void TicketBooking()
        {
            Console.Write("Enter no of tickets: ");
            tickets = Convert.ToInt32(Console.ReadLine());
            if (tickets > 2)
            {
                throw (new BookingException("Cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets Booked Successfully");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Booking bkng = new Booking();
            try
            {
                bkng.TicketBooking();
            }
            catch (BookingException be)
            {
                Console.WriteLine(be.Message);
            }
        }
    }
}