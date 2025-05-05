namespace ПЗ_03
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Bank.CreateCustomer("Ivanov Ivan");
            Bank.CreateCustomer("Petrov Petr");

            Bank.CreateAccount("Ivanov Ivan", AccountType.Debit, 1500);
            Bank.CreateAccount("Ivanov Ivan", AccountType.Credit, 2000);
            Bank.CreateAccount("Petrov Petr", AccountType.Debit, 3000);

            Bank.DisplayAllCustomers();

            Console.WriteLine($"Total balance for Ivanov Ivan: {Bank.GetTotalBalanceForCustomer("Ivanov Ivan")}");
            Console.WriteLine($"Total balance for all customers: {Bank.GetTotalBalanceForAllCustomers()}");

            var creditAccounts = Bank.GetCreditAccounts();
            Console.WriteLine($"Credit accounts:");
            foreach (var account in creditAccounts)
            {
                Console.WriteLine($"  Account Type: {account.Type}, Balance: {account.Balance}");
            }

            var debitAccounts = Bank.GetDebitAccounts();
            Console.WriteLine($"Debit accounts:");
            foreach (var account in debitAccounts)
            {
                Console.WriteLine($"  Account Type: {account.Type}, Balance: {account.Balance}");
            }
        }
    }




}
