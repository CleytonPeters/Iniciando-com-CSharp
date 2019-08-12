﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula125_Conta_Herança.Entities
{
    class BusinessAccount : Account
    {

        public double LoanLimit { get; private set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
