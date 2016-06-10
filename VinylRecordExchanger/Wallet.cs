using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordExchanger
{
    class Wallet
    {
        decimal balance;

        public Wallet()
        {
            this.balance = 0;
        }

        public void depositCredits(decimal credits)
        {
            this.balance += credits;
        }

        public void withdrawCredits(decimal credits)
        {
            if (this.balance - credits < 0)
            {
                Console.WriteLine("Insufficient Funds!");
            }
            else
            {
                this.balance -= credits;
            }
        }

        public decimal getBalance()
        {
            return this.balance;
        }
    }
}
