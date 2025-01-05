using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException("Withdrawal amount exceeds available balance.");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }
        

    }
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
