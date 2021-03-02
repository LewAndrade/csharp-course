using System;
using Bank.Entities.Exceptions;

namespace Bank.Entities
{
    public class Account
    {
        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }
        private double WithdrawLimit { get; set; }

        public Account()
        {
            Console.WriteLine("Enter Account Data");
            
            Console.Write("Number: ");
            int accNumber;
            while (!int.TryParse(Console.ReadLine(), out accNumber))
                Console.Write("Please insert a valid Account Number...\nNumber: ");

            Console.Write("Holder: ");
            var accHolder = Console.ReadLine();
            
            Console.Write("Initial balance: ");
            double accBalance;
            while (!double.TryParse(Console.ReadLine(), out accBalance))
                Console.Write("Please insert a valid Initial Balance... \nInitial balance: ");
                
            Console.Write("Withdraw limit: ");
            double accWithdrawLimit;
            while (!double.TryParse(Console.ReadLine(), out accWithdrawLimit))
                Console.Write("Please insert a valid Withdraw Limit... \nWithdraw Limit: "); 
            
            Number = accNumber;
            Holder = accHolder;
            Balance = accBalance;
            WithdrawLimit = accWithdrawLimit;
        }

        
        public void Deposit()
        {
            Console.Write("Enter de amount to Deposit: ");
            double amount;

            while (!double.TryParse(Console.ReadLine(), out amount))
                Console.Write("Please enter a valid amount for deposit: ");

            Balance += amount;
            Console.WriteLine($"New balance: {Balance}");
        }

        public void Withdraw()
        {
            Console.Write("Enter de amount to Withdraw: ");
            double amount;
            
            while (!double.TryParse(Console.ReadLine(), out amount))
                Console.Write("Please enter a valid amount for withdraw: ");
            
            
            if (amount > WithdrawLimit)
                throw new DomainException("The amount exceeds withdraw limit");

            if (amount > Balance)
                throw new DomainException("Not enough balance");
            
            Balance -= amount;
            Console.WriteLine($"New balance: {Balance}");

        }

        public override string ToString()
        {
            return "Account Data:\n" +
                   $"Number: {Number}\n" +
                   $"Holder: {Holder}\n" +
                   $"Balance: {Balance} \n" +
                   $"Limit: {WithdrawLimit}";
        }
    }
    
}