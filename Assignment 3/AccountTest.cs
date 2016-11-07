// Brian Bowles, Assignment 3, January 27, 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            // Objects and Variables.
            CheckingAccount checking;
            SavingsAccount savings;
            decimal interest_, fee = 1.06M;
            bool successful = false;

            // Set the values for the two accounts.
            savings = new SavingsAccount(55.06M, 0.01M);
            checking = new CheckingAccount(151.12M, fee);
            interest_ = savings.calcInterest();
            savings.Credit(interest_);

            // Print out the initial balances of the accounts and the interest on the savings.
            Console.WriteLine("The initial amount in your checking account is: {0:C2}", checking.Balance);
            Console.WriteLine("The fee connected with your checking account is: {0:C2}", fee);
            Console.WriteLine("The initial amount in your savings account, with interest, is: {0:C2}", savings.Balance);
            Console.WriteLine("The initial earned interest on your savings account is: {0:C2}", interest_);

            // Change the balance of the accounts and calculate interest on the savings.
            checking.Credit(150.00M);
            savings.Credit(50.00M);
            successful = checking.Debit(15.00M);
            if (successful == true)
                Console.WriteLine("Success withdrawing.");
            else
                Console.WriteLine("Cannot withdraw money from your account at this time.");
            interest_ = savings.calcInterest();
            savings.Credit(interest_);

            // Print out final account balances and the interest on the savings.
            Console.WriteLine("The amount in your checking account is now: {0:C2}", checking.Balance);
            Console.WriteLine("The amount in your savings account, with interest, is now: {0:C2}", savings.Balance);
            Console.WriteLine("The amount of interest earned on your savings account was: {0:C2}", interest_);
        }
    }
}
