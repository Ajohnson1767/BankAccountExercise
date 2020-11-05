using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        private double balance = 0;
        public double Balance;
        
            public void Deposit(double amount)
            {
            balance = amount;
            }
            public double GetBalance()
            {
            return balance;
             }
     }
    
}
