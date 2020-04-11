using System;

namespace StrategyPatternSample
{
    abstract class PaymentMethod
    {
        public abstract bool Pay(decimal amount);
    }

    class CreditCard : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 100000)
            {
                Console.WriteLine($"Paying {amount} using Credit Card declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using Credit Card");
                return true;
            }
        }
    }

    class PayPal : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 1000)
            {
                Console.WriteLine($"Paying {amount} using PayPal declined");
                return false;
            }
            else
            {
                Console.WriteLine($"Paying {amount} using PayPal");
                return true;
            }
        }
    }

    class ApplePay : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            Console.WriteLine("COVID19, ApplePay payment declined");
            return false;
        }
    }

}
