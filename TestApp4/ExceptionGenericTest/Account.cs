using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ExceptionGenericTest
{
    class AccountException : Exception { 
    public AccountException(string message):base(message) { }

    }

    internal class Account
    {
        public const decimal MAX_DEPOSIT = 100_000_000;
        public const decimal MIN_DEPOSIT = 10;
        public const decimal MIN_TRANS = 10;
        public const decimal MAX_TRANS = 100_000;

        public Account(decimal value = MIN_DEPOSIT) {
            Deposit = value;
        }

        private static bool IsDepositValid(decimal value)
        {
            if (value >= MIN_DEPOSIT && value <= MAX_DEPOSIT) return true;
            return false;
        }

        private static bool IsTransactionValid(decimal value)
        {
            if (value >= MIN_TRANS && value <= MAX_TRANS) return true;
            return false;
        }

        public uint Id { get; set; }
        private decimal _deposit;

        public void Withdraw(decimal value) { 
         if(IsTransactionValid(value)) Deposit -= value;
         else throw new AccountException("Invalid transaction: " + value);
        }

        public void Put(decimal value)
        {
            if (IsTransactionValid(value)) Deposit += value;
            else throw new AccountException("Invalid transaction: " + value);
        }

        public decimal Deposit { get => _deposit;
            private set {
                if (IsDepositValid(value)) _deposit = value;
                else throw new AccountException("Invalid deposit: " + value);
            }
        
        }




         



    }
}
