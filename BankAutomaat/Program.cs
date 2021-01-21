using System;

namespace BankAutomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount customer = new CustomerAccount();
            customer.PayInFunds(500.00M);

            Console.WriteLine(customer.GetBalance());
            Console.WriteLine(customer.WithDrawFunds(80M));
            Console.WriteLine(customer.GetBalance());
            Console.WriteLine(customer.WithDrawFunds(600M));
            Console.WriteLine(customer.GetBalance());

            Console.WriteLine("=========================================");


            YouthAccount YouthAccount = new YouthAccount();
            YouthAccount.PayInFunds(170.00M);

            Console.WriteLine(YouthAccount.GetBalance());
            Console.WriteLine(YouthAccount.WithDrawFunds(15M));
            Console.WriteLine(YouthAccount.GetBalance());
            Console.WriteLine(YouthAccount.WithDrawFunds(8M));
            Console.WriteLine(YouthAccount.GetBalance());

            Console.ReadLine();
        }
    }
}
