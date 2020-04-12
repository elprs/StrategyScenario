namespace StrategyPatternSample
{
    // Payments subsystem
    class Payments
    {
        public bool PayBasket(EShopBasket basket, int paymentMethod)
        {
            switch (paymentMethod)
            {
                case 1:
                    basket.SelectPaymentMethod(new CreditDebitCard());
                    break;

                case 2:
                    basket.SelectPaymentMethod(new BankTransfer());
                    break;

                case 3:
                    basket.SelectPaymentMethod(new Cash());
                    break;

                default:
                    basket.SelectPaymentMethod(new Cash());
                    break;

            }
            var success = basket.Pay();
            return success;
        }
    }
}

