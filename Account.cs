using System;
namespace Lab23Account
{
    public class Account
    {
        public int ID { get; private set; }

        public string Name { get; set; }
        private decimal balance;
        public static int Count { get; private set; }

        public Account(string name, decimal bal)
        {
            Name = name;
            Balance = bal;
            ID = ++Count;
            Console.WriteLine($"Account created - ID: {ID}, Name: {Name}, Balance: {Balance:C}");
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;

            Console.WriteLine($"adding {amount} to {Name}'s balance");
            Console.WriteLine();

        }

        public void Withdraw(decimal amount) {
            if (balance >= amount)
            {
                Balance = Balance - amount;

                Console.WriteLine($"Withdrawing {amount:C} from {Name}'s account");
                Console.WriteLine();
            } else
            {
                Console.WriteLine($"Failed, balance is: {Balance:C}");
            }
        }

        public override string ToString()
        {
            return string.Format($"Account: ID={ID}, Name={Name}, Balance={Balance:C}");
        }
    }
}
