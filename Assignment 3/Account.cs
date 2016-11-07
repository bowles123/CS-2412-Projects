// Brian Bowles, Account class, 01/27/15.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Base class to represent a generic account.
    public class Account
    {
        // Attributes.
        private decimal balance;

        // Properties.
        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value >= 0)
                    balance = value;
                else
                {
                    balance = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Explicit Value constructor.
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        // Virtual function for depositing into an account.
        public virtual void Credit(decimal amount)
        {
            Balance += amount;
        }

        // Virtual function for withdrawing from an account.
        public virtual bool Debit(decimal amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                return true;
            }
            else
                return false;
        }
    }
}
