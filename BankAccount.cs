using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount : IBankAccount
    {
        private static int s_accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }

        // private readonly List<Transaction> _allTransactions;
        // private readonly TransactionFactory _transactionFactory;
        private List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string name, float initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Inital Balance");
            this.Number = s_accountNumberSeed.ToString();
            // List<Transaction> allTransactions = new List<Transaction>
            // this._transactionFactory = transactionFactory;
            // this._allTransactions = allTransactions;
            s_accountNumberSeed++;

        }

        public float Balance
        {
            get
            {
                float balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        public void MakeDeposit(float amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);

            // Transaction deposit = _transactionFactory.CreateTransaction(amount, date, note);
            // _allTransactions.Add(deposit);

        }


        public void MakeWithdrawal(float amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
            // Transaction withdrawal = _transactionFactory.CreateTransaction(-amount, date, note);
            // _allTransactions.Add(withdrawal);

        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\t\tRunning Balance\t\tNote");
            float runningBalance = 0;
            foreach (var transaction in _allTransactions)
            {
                runningBalance += transaction.Amount;
                //ROWS
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t£{transaction.Amount}\t\t£{runningBalance}\t\t\t{transaction.Notes}");
            }
            return report.ToString();
        }
    }
}
