using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class LoanException : ApplicationException
    {
        public LoanException(string msg) : base(msg)
        {
        }
    }

    class LoanProcess
    {
        int Lno;
        string CustName;
        double LoanAmount, EmiAmount, Balance;

        public LoanProcess(int lno, string name, double lamount, double bal)
        {
            Lno = lno;
            CustName = name;
            LoanAmount = lamount;
            Balance = bal;
        }

        public void CaluculateEMI()
        {
            int rate = 13, n = 36;
            double r = ((double)rate / (double)n) / 100;

            EmiAmount = (LoanAmount) + (LoanAmount * r * (Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1)));

        }

        public void CheckBalance()
        {
            if (Balance < EmiAmount)
            {
                throw (new LoanException("Not Sufficient Balance to repay Loan"));
            }
            else
            {
                Console.WriteLine("Loan Repayed");
            }
        }

    }

    class Loan
    {
        static void Main()
        {
            LoanProcess loan = new LoanProcess(1234, "Akhil", 50000, 40000);
            loan.CaluculateEMI();
            try
            {
                loan.CheckBalance();
            }
            catch (LoanException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}