using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class TransactionFactory : ITransactionFactory
    {
        public Transaction CreateTransaction(float amount, DateTime date, string note)
        {
            return new Transaction(amount, date, note);
        }
    }

}
