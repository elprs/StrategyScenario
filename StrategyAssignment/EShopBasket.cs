using StrategyAssignment;
using System;

namespace StrategyPatternSample
{
    class EShopBasket
    {
        private PaymentMethod _paymentMethod;
        private decimal _dueAmount;

        public void SelectPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void SetDueAmount(decimal amount)
        {
            _dueAmount = amount;
        }

        public bool Pay()
        {
            return _paymentMethod.Pay(_dueAmount);
        }


        
    }

}