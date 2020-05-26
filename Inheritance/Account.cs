using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Account
    {
        //  Properties of our Account class
        private int accountNumber;
        private string accountName;
        private decimal balance;
        private List<Transaction> transactions;
        private float interestRate;

        private static int nextAccountNumber = 1000;


        //      Getters and Setters
        public string AccountName { get => accountName; set => accountName = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public float InterestRate { get => interestRate; set => interestRate = value; }
        public List<Transaction> Transactions { get => transactions; set => transactions = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }

        //      Constructor             Account checking = new Account("Checking", 100.0f, 0.02f);
        public Account(string accountName, decimal balance, float interestRate)
        {
            nextAccountNumber++;
            this.AccountNumber = nextAccountNumber;

            this.accountName = accountName;
            this.balance = balance;
            this.interestRate = interestRate;

            transactions = new List<Transaction>();
            Transaction newAccount = new Transaction(balance, "New Account Opened: " + accountName, true);
            transactions.Add(newAccount);
        }

        //  Deposit we can add money to the account
        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            Transaction deposit = new Transaction(amount, "Deposit", true);
            transactions.Add(deposit);
            return Balance;
        }


        //  this method works for some subclasses maybe not all
        //  so in other subclasses it will be overridden 
        public virtual decimal Withdrawal(decimal amount)
        {
            balance -= amount;
            return balance;
        }

        //  ShowTransactions - list to the console the transactions performed since day 1 
        public void ShowTransactions()
        {
            foreach (Transaction trans in transactions)
            {
                Console.WriteLine(trans);
            }
        }

        public override string ToString()
        {
            return accountName + " : Balance = " + balance;
        }
    }
}
