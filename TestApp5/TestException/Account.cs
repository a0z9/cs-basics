using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    class AccountException : Exception {
    //Logging,.....
    //Extra Account data,.... 
    public AccountException(string message) : base(message) { }
        public AccountException(string message, Account acc) : base(message) {
        // todo acc data
        }
    }

    internal class Account
    {
        public const uint MIN_DEPOSIT = 10;
        public const uint MIN_TRANSACTION = 10;

        public const uint MAX_DEPOSIT_MIN = 100_000;
        public const uint MAX_DEPOSIT_MAX = 100_000_000;

        public const uint MAX_TRANSACTION_MIN = 1_000;
        public const uint MAX_TRANSACTION_MAX = 50_000;

        private readonly uint MAX_DEPOSIT;
        private readonly uint MAX_TRANSACTION;

        private decimal _deposit;

        private static bool IsMaxLimitsValid(uint max_deposit, uint max_transaction) =>
        max_deposit <= MAX_DEPOSIT_MAX && 
        max_deposit >= MAX_DEPOSIT_MIN && 
        max_transaction <= MAX_TRANSACTION_MAX &&  
        max_transaction >= MAX_TRANSACTION_MIN; 
      

        public Account( decimal deposit, uint MAX_DEPOSIT=10_000_000, uint MAX_TRANSACTION=10_000)
        {
            if (IsMaxLimitsValid(MAX_DEPOSIT, MAX_TRANSACTION))
            {
                this.MAX_DEPOSIT = MAX_DEPOSIT;
                this.MAX_TRANSACTION = MAX_TRANSACTION;
            }
            else throw 
            new AccountException($"MAX/MIN failed.. TRAN:{MAX_TRANSACTION}, DEP:{MAX_DEPOSIT}");
            Deposit = deposit;
        }   

        private bool IsDepositValid(decimal value) =>
         value >= MIN_DEPOSIT && value <= MAX_DEPOSIT;

        private bool IsTransactionValid(decimal value) =>
         value >= MIN_TRANSACTION && value <= MAX_TRANSACTION;

        public void Withdraw(decimal value) {
            if (IsTransactionValid(value)) Deposit -= value;
            else throw new AccountException($"Transaction failed.. {value}");
        }

        public void Put(decimal value)
        {
            if (IsTransactionValid(value)) Deposit += value;
            else throw new AccountException($"Transaction failed.. {value}");
        }

        public decimal Deposit { 
            get { return _deposit; } 
            set {
                if (IsDepositValid(value))
                    _deposit = value;
                else throw new AccountException($"Deposit set failed.. {value}"); 
            } }


    }
}
