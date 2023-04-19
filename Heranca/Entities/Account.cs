using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
            
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposito (double amount)
        {
            Balance += amount;
        }
        


    }
}