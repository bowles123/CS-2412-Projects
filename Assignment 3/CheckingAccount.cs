// Brian Bowles, Checking Account class, 01/27/15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Derived class from Account class to represent a checking account.
    public class CheckingAccount: Account
    {
        // Attributes.
        private decimal transactionFee;

        // Properties.
        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }

            set
            {
                if (value >= 0)
                    transactionFee = value;
                else
                {
                    transactionFee = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Explicit Value constructor that also call the base class constructor.
        public CheckingAccount(decimal initialBalance, decimal fee)
            : base(initialBalance)
        {
            TransactionFee = fee;
        }

        // Withdraws money from account in the form of a fee.
        private void chargeFee()
        {
            Balance -= TransactionFee;
        }

        // Overriden method that represents deposting into a checking account, applying a fee where neccassary.
        public override void Credit(decimal amount)
        {
            if (amount > TransactionFee)
                chargeFee();
            base.Credit(amount);
        }

        // Overriden method that represents withdrawing from a checking account, applying a fee where neccassary.
        public override bool Debit(decimal amount)
        {
            if (amount + TransactionFee <= Balance && base.Debit(amount) == true)
            {
                chargeFee();
                return true;
            }
                return false;
        }
    }
}
