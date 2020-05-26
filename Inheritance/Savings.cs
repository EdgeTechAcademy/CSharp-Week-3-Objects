using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Savings : Account
    {
        public Savings(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
        {
            //      gift of a $100 for opening an new account
            this.Deposit(100);
        }

        //  we don't like the parent version of the Withdraw method
        //  we want our own version. It is much safer.
        //  let those idiots in the Checking department worry about theft!!! LOSERS!
        public override decimal Withdrawal(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine($"Whoa there buddy you have {Balance:C} in your account\n" +
                                  $"Which too little for a withdrawal of {amount:C}");
            }
            return Balance;
        }
    }
}
