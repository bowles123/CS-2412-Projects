// Brian Bowles, Savings Account class, 01/27/15.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Derived class from Account class to represent a Savings Account.
    public class SavingsAccount: Account
    {
        // Attributes.
        private decimal interestRate;

        // Properties.
        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                if (value >= 0)
                    interestRate = value;
                else
                {
                    interestRate = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Explicit Value constructor that also envokes the base class constructor.
        public SavingsAccount(decimal initialBalance, decimal interestRate)
            : base(initialBalance)
        {
            InterestRate = interestRate;
        }

        // Calculate the interest based on current balance and interest rate.
        public decimal calcInterest()
        {
            return Balance * InterestRate;
        }
    }
}
