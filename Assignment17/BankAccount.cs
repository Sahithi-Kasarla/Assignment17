using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class BankAccount
    {
        private readonly int accountNumber;
        private string accountHolder;
        private decimal balance;

        // Constructor to initialize the account with the account holder's name and zero initial balance
        public BankAccount(string accountHolder, decimal initialBalance = 0)
        {
            this.accountNumber = GenerateAccountNumber();
            this.accountHolder = accountHolder;
            this.balance = 0;
        }

        // Read-only property for account number
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        // property for account holder
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        // Property for balance
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        // Method to generate a random 8-digit account number
        private int GenerateAccountNumber()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999);
        }


        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit of ${amount} successful. New balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal of ${amount} successful. New balance: ${balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
            }
        }

        
    }

}

