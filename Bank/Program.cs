using System;
using Bank.Entities;
using Bank.Entities.Exceptions;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();

            try
            {
                account.Withdraw();

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}