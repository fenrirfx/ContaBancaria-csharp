using System;
using ContaBancaria.Entities;
using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc1 = new Account(number, name, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter the amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                acc1.Withdraw(amount);
                Console.Write("New Balance: " + acc1.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
            }

        }
    }
}
