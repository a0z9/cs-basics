using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class AccoutException : Exception { 
        //
        public AccoutException(string message):base(message) { }
    }


    internal class Account
    {
        public const decimal MIN_DEPOSIT = 10m;
        public const decimal MIN_TRANS = 10m;

        private readonly decimal MAX_DEPOSIT;
        private readonly decimal MAX_TRANS;

        private decimal _deposit;

        private bool isDepositValid(decimal value) { 
         return value >= MIN_DEPOSIT && value <= MAX_DEPOSIT;
        }

        private bool isTransValid(decimal value)
        {
            return value >= MIN_TRANS && value <= MAX_TRANS;
        }

        public Account(uint Deposit =10, uint max_deposit=1000_000, uint max_trans=1000)
        {
            MAX_DEPOSIT = max_deposit; MAX_TRANS = max_trans;
            this.Deposit = Deposit;
        }

        public decimal Deposit {
            get => _deposit;
            private set {
                if (isDepositValid(value)) _deposit = value;
                else throw new AccoutException($"Failed deposit: {value}");
            } } 
    
        public void Withdraw(decimal value) {
            if (isTransValid(value)) Deposit -= value;
            else throw new AccoutException($"Failed WITHDRAWAL transaction: {value}");
        }

        public void Put(decimal value)
        {
            if (isTransValid(value)) Deposit += value;
            else throw new AccoutException($"Failed PUT transaction: {value}");
        }

   }
     
    
}

