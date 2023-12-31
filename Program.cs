﻿//using MySuperBank;

//var account = new BankAccount("Travis", 1000);
//Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} intial balance.");

using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // TransactionFactory transactionFactory = new TransactionFactory();
            // List<Transaction> allTransactions = new List<Transaction>();
            var account = new BankAccount("Travis", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} intial balance.");

            account.MakeWithdrawal(120, DateTime.Now, "Pencil");
            account.MakeDeposit(140, DateTime.Now, "Birthday present");
            account.MakeWithdrawal(50, DateTime.Now, "Hogwarts Legacy");

            Console.WriteLine(account.GetAccountHistory());

            Console.WriteLine($"Current Balance: £{account.Balance}");

            // Test that the initial balances must be positive.
            // BankAccount invalidAccount;

            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}

            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}







        }
    }
}

