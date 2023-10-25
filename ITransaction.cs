namespace MySuperBank
{
    public interface ITransaction
    {
        float Amount { get; }
        DateTime Date { get; }
        string Notes { get; }
    }
}