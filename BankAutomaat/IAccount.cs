namespace BankAutomaat
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithDrawFunds(decimal amount);
        decimal GetBalance();
        void RudeLettersString();
    }
}
