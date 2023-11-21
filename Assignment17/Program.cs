using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string accountHolderName = "Sahithi";


            // Creating a new bank account with zero initial balance
            BankAccount sahithisAccount = new BankAccount(accountHolderName);

            //display initial account details
            DisplayAccountDetails(sahithisAccount);

            // Depositing and displaying account details
            sahithisAccount.Deposit(500);
            DisplayAccountDetails(sahithisAccount);

            // Withdrawing and displaying account details
            sahithisAccount.Withdraw(200);
            DisplayAccountDetails(sahithisAccount);
        }

        // Helper method to display account details
        static void DisplayAccountDetails(BankAccount account)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Account Holder: {account.AccountHolder}");
            Console.WriteLine($"Current Balance: ${account.Balance}");
            Console.WriteLine();
            Console.ReadKey();

        }
    }


}

