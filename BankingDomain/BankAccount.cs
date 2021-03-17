using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _balance = 5000; // Class Variable "Field"
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            _balance -= amountToWithdraw;
        }
    }
}