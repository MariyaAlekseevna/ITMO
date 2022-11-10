﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpLab02.BankAccount
{
    internal class Enum
    {
        public enum AccountType {Checking, Deposit}
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
