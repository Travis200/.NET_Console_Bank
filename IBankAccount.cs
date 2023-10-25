namespace MySuperBank
{
    public interface IBankAccount
    {
        float Balance { get; }
        string Number { get; }
        string Owner { get; set; }

        string GetAccountHistory();
        void MakeDeposit(float amount, DateTime date, string note);
        void MakeWithdrawal(float amount, DateTime date, string note);
    }
}