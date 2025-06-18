using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class BankAccount
    {
        private double balance;
        private string accountHolderName;
        
        public BankAccount(double cash, string name)
        {
            balance = cash;
            accountHolderName = name;
            Console.WriteLine($"Account created for {accountHolderName} with balance: {balance}");
        }
        
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited cash: {amount}, New Balance: {balance}");
        }
        
        public void Deposit(double amount, string chequeNumber)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} via cheque #{chequeNumber}, New Balance: {balance}");
        }
        
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew cash: {amount}, Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        
        public void Withdraw(double amount, string cardType)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount} using {cardType} card, Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
