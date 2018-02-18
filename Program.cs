using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kassa
{
    class Program
    {
        static void Main(string[] args)
        {
            //card
            PaidWithCard paidWithCard = new PaidWithCard();
            paidWithCard.ShowTransaction(78.95f);
            paidWithCard.ShowTransaction(45.65f);
            paidWithCard.GetAmount();

            //cash
            PaidWithCash paidWithCash = new PaidWithCash();
            paidWithCash.ShowTransaction(100);
            paidWithCash.ShowTransaction(50);
            paidWithCash.GetAmount();

            //sum
            float card = paidWithCard.Money;
            float cash = paidWithCash.Money;
            float sum = card + cash;
            DateTime date = DateTime.Now;
            Console.WriteLine("Total sales {0} is {1}", date, sum);
        }
    }
}
