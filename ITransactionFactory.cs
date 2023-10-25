namespace MySuperBank
{
    public interface ITransactionFactory
    {
        Transaction CreateTransaction(float amount, DateTime date, string note);
    }
}