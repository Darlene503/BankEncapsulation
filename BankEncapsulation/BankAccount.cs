namespace BankEncapsulation
{
    internal class BankAccount
    {

        public BankAccount()
        {

        }

        private double _balance = 0;


        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}