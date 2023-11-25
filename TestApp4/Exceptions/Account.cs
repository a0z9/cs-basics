using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class AccounException : Exception { 
    // spec
      public AccounException(string message) : base("Account:" + message) {
        
        }
    }

    internal class Account
    {
        private int _deposit;
        private const int MAX_OP = 1000, MAX = 10_000_000, MIN_OP = 10, MIN = 10;
        public int Id { get; private set; }
        private static Random r = new Random((int)DateTime.Now.Ticks);
        // Person, Name, Bla-bla-bla
        private int Deposit {
            get => _deposit; 
            set {
                if (value >= MIN && value <= MAX) _deposit = value;
                else {
                    throw new AccounException($"Deposite is out of bounds: {value}");
                }
            } 
        }

        public void Withdraw(int amount)
        { 
        if(amount < MIN_OP || amount > MAX_OP) throw new AccounException($"Withdraw amount is too small: {amount}");
            Deposit -= amount;
        }

        public void Put(int amount)
        {
            if (amount < MIN_OP || amount > MAX_OP) throw new AccounException($"Deposit PUT amount is too small: {amount}");
            Deposit += amount;
        }


        public Account(int Deposit) {
        Id = r.Next(10001,10_000_000);
        this.Deposit = Deposit;
        }




    }
}
