using System;

namespace StrategyPatternSample
{
    //Abstract class
    abstract class PaymentMethod
    {
        public abstract bool Pay(decimal amount);
    }

    //Payment method 1 : Credit/debit card class
    class CreditDebitCard : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            //Adding requirements' logic
            if (amount <= 0m || amount > 100000)
            {
                Console.WriteLine("Paying {0:c} using Credit Card declined", amount);
                return false;
            }
            else
            {
                Console.WriteLine("Paying {0:c} using Credit Card", amount);
                return true;
            }
        }
    }

    //Payment method 2 : BankTransfer class
    class BankTransfer : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m || amount > 1000)
            {
                Console.WriteLine("Paying {0:c} using Bank Transfer declined", amount);
                return false;
            }
            else
            {
                Console.WriteLine("Paying {0:c} using BankTransfer", amount);
                return true;
            }
        }
    }

    //Payment method 3 : Cash class
    class Cash : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount <= 0m )
            {
                Console.WriteLine("Paying {0:c} using Cash declined", amount);
                return false;
            }
            else
            {
                Console.WriteLine("Paying {0:c} using Cash", amount);
                return true;
            }
        }
    }

    //The 'PaymentMethodProceeds' class


    class PaymentMethodPay

    {
        private PaymentMethod _paymentMethod;

        // Constructor

        public PaymentMethodPay(PaymentMethod paymentMethod)
        {
            this._paymentMethod = paymentMethod;
        }

        public void PaymentProceeds(decimal amount)
        {
            _paymentMethod.Pay(amount);
        }
    }

}
