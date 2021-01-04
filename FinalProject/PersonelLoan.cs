using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PersonelLoan : ILoan
    {
        private readonly String type = "Personel Loan";
        LoanDal loanDal = new LoanDal();
        private int creditPeriod;
        private double salary;
        private int loanAmount;
        public PersonelLoan(float salary, int creditPeriod, int loanAmount)
        {
            this.creditPeriod = creditPeriod;
            this.salary = salary;
            this.loanAmount = loanAmount;
        }
        public PersonelLoan()
        {

        }
        public double calculateMonthlyPayment()
        {
            double interest = loanDal.getInterest(type);
            //interest= (Math.Round(interest, 3));
            double debt = ((interest * creditPeriod * loanAmount) / 100) + loanAmount;
            debt = (Math.Round(debt, 3));

            return debt;
        }

        public int getMaxMonth()
        {
            int month = loanDal.getMaxMonth(type);

            
            return month;
        }

        public bool isCustomerAvailableForLoan()
        {
            int maxMonth = getMaxMonth();
            double maxLimit = (salary * creditPeriod * 80) / 100;
            Console.WriteLine("max limit" + maxLimit);
            if (creditPeriod <= maxMonth && maxLimit >= loanAmount)
            {


                return true;

            }

            return false;
        }
    }
}
