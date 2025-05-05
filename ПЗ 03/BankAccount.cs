namespace ПЗ_03
{
    using System;

    public class BankAccount
    {
        public AccountType Type { get;  set; }
        public decimal Balance { get; private privateset; }

        public BankAccount(AccountType type, decimal initialBalance)
        {
            Type = type;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Type == AccountType.Credit && amount <= Balance)
            {
                Balance -= amount;
            }
            else if (Type == AccountType.Debit && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }




}
