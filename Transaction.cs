namespace MySuperBank
{
    public class Transaction : ITransaction
    {
        public float Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(float amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }

}
