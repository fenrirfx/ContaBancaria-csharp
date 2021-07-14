using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Deposit(double amount)
        {
            return amount + Balance;
        }

        public double Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw Error: The amout exceeds the Withdraw Limit!!");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw Error: Insuficient Funds!!");
            }
            return Balance -= amount;
        }
    }
}
