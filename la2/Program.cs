﻿namespace la2
{
    class Program
    {
        static void Main(string[] args)
        {

            CreditCard.CreditCard creditCard = new CreditCard.CreditCard();
            System.Console.WriteLine(creditCard.getMoney());

            BusinessCard.BusinessCard businessCard = new BusinessCard.BusinessCard();
            businessCard.useBusinessCard();

        }
    }
}
