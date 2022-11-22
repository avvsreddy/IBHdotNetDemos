namespace ExDemo2
{
    class AccoutManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromAcc"></param>
        /// <param name="amount"></param>
        /// <param name="pin"></param>
        /// <exception cref="AccountNotActiveException"></exception>
        /// <exception cref="InsufficcientBalanceException"></exception>
        /// <exception cref="InvalidPinException"></exception>
        /// <exception cref="AmountLimitExceededException"></exception>
        public void Withdraw(Account fromAcc, int amount, int pin)
        {
            // Account should be active
            if (!fromAcc.IsActive)
                throw new AccountNotActiveException("Account is not active");
            // should have min of 1K balance
            if (fromAcc.Balance - amount < 1000)
                throw new InsufficcientBalanceException("Must have min of 1K");
            // pin must match
            if (fromAcc.Pin != pin)
                throw new InvalidPinException("Invalid pin");
            if (amount > 10000)
                throw new AmountLimitExceededException();
            fromAcc.Balance -= amount;

        }
    }
}