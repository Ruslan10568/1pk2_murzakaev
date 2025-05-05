namespace ПЗ_03
{
    using System;
    using System.Collections.Generic;

    public static class Bank
    {
        private static Dictionary<string, List<BankAccount>> customers = new Dictionary<string, List<BankAccount>>();

        public static void CreateCustomer(string name)
        {
            if (!customers.ContainsKey(name))
            {
                customers[name] = new List<BankAccount>();
                Console.WriteLine($"Customer {name} created.");
            }
            else
            {
                Console.WriteLine($"Customer {name} already exists.");
            }
        }

        public static void CreateAccount(string customerName, AccountType type, decimal initialBalance)
        {
            if (customers.ContainsKey(customerName))
            {
                BankAccount account = new BankAccount(type, initialBalance);
                customers[customerName].Add(account);
                Console.WriteLine($"Account created for {customerName}: {type} with balance {initialBalance}.");
            }
            else
            {
                Console.WriteLine($"Customer {customerName} does not exist.");
            }
        }

        public static void DisplayAllCustomers()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer: {customer.Key}");
                foreach (var account in customer.Value)
                {
                    Console.WriteLine($"  Account Type: {account.Type}, Balance: {account.Balance}");
                }
            }
        }

        public static void DisplayAccountsForCustomer(string customerName)
        {
            if (customers.ContainsKey(customerName))
            {
                Console.WriteLine($"Accounts for {customerName}:");
                foreach (var account in customers[customerName])
                {
                    Console.WriteLine($"  Account Type: {account.Type}, Balance: {account.Balance}");
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerName} does not exist.");
            }
        }

        public static decimal GetTotalBalanceForCustomer(string customerName)
        {
            if (customers.ContainsKey(customerName))
            {
                decimal totalBalance = 0;
                foreach (var account in customers[customerName])
                {
                    totalBalance += account.Balance;
                }
                return totalBalance;
            }
            return 0;
        }

        public static decimal GetTotalBalanceForAllCustomers()
        {
            decimal totalBalance = 0;
            foreach (var customer in customers)
            {
                foreach (var account in customer.Value)
                {
                    totalBalance += account.Balance;
                }
            }
            return totalBalance;
        }

        public static List<BankAccount> GetCreditAccounts()
        {
            List<BankAccount> creditAccounts = new List<BankAccount>();
            foreach (var customer in customers)
            {
                creditAccounts.AddRange(customer.Value.FindAll(account => account.Type == AccountType.Credit));
            }
            return creditAccounts;
     
        }

        public static List<BankAccount> GetDebitAccounts()
        {
            List<BankAccount> debitAccounts = new List<BankAccount>();
            foreach (var customer in customers)
            {
                debitAccounts.AddRange(customer.Value.FindAll(account => account.Type == AccountType.Debit));
            }
            return debitAccounts;
        }
    }




}
