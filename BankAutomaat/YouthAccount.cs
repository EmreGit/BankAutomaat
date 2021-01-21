using System;

namespace BankAutomaat
{
    public class YouthAccount : Account
    {
        public override void RudeLettersString()
        {
            Console.WriteLine("Tell Daddy you are overdrawn");
        }
        public override bool WithDrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                RudeLettersString();
                return false;
            }
            return base.WithDrawFunds(amount);
        }
    }
}
