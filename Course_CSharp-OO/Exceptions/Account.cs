﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Balance insufficient!");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw limit insufficient!");
            }
            Balance -= amount;
        }
    }
}
