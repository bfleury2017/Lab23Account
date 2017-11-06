using System;

namespace Lab23Account
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal deposit;
            decimal withdraw;

            Account account1 = new Account("John Smith", 50);
            Account account2 = new Account("Jackie Blue", 0);

            Console.WriteLine();

            Console.Write($"Enter deposit amount for {account1.Name}:");
            deposit = decimal.Parse(Console.ReadLine());
            account1.Deposit(deposit);

            Console.Write($"Enter deposit amount for {account2.Name}:");
            deposit = decimal.Parse(Console.ReadLine());
            account2.Deposit(deposit);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            Console.WriteLine();

            Console.Write($"Enter withdrawal amount for {account1.Name}:");
            withdraw = decimal.Parse(Console.ReadLine());
            account1.Withdraw(withdraw);

            Console.Write($"Enter withdrawal amount for {account2.Name}:");
            withdraw = decimal.Parse(Console.ReadLine());
            account2.Withdraw(withdraw);


            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString());

            Console.WriteLine();

            Console.WriteLine($"Number of accounts: {Account.Count}");
        }
    }
}
