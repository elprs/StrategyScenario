
using StrategyAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternSample
{

    class Eshop
    {
        private PaymentMethod _paymentMethod;

        private IEnumerable<Variation> _variations;

            public void PayTShirt(TShirt tshirt)
            {
                foreach (var variation in _variations)
                {
                    Console.WriteLine($"Applying {variation.GetType().Name}");
                    variation.Cost(tshirt);
                    Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}");
                }

            _paymentMethod.Pay(tshirt.Price);
        }

        


        public static void EShopDemo()
        {
            var basket = new EShopBasket();
            var amount = 32.32m;
            basket.SetDueAmount(amount);

            Console.Write("How would you like to pay? 1) CC, 2) BankTransfer, 3) Cash : ");
            var input = int.Parse(Console.ReadLine().Trim());
            bool success = PayBasket(basket, input);

            if (success)
            {
                Console.Write("Please select the shipment method 1=PostOffice, 2=Courier, 3=Own, 4=Pickup:");
                var carrierType = (CarrierType)int.Parse(Console.ReadLine().Trim());
                if (carrierType != CarrierType.Pickup)
                {
                    Console.Write("Please give your address:");
                    var address = Console.ReadLine().Trim();
                    var shipment = new Shipment();
                    if (shipment.CanShipTo(address, carrierType))
                    {
                        shipment.DeliverOrder(address, basket);
                    }
                }
            }


            Console.Write("Is the address correct: ");
            Console.WriteLine(success);
            Console.WriteLine("Please press enter");
            Console.Read();
        }



        private static bool PayBasket(EShopBasket basket, int input)
        {
            switch (input)
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

    // Order shipment subsystem
    class Shipment
    {
        public bool CanShipTo(string address, CarrierType carrier)
        {
            return false;
        }

        public void DeliverOrder(string address, EShopBasket basket)
        {
            //complete this ++
        }
    }

    enum CarrierType
    {
        PostOffice = 1,
        Courier = 2,
        OwnDelivery = 3,
        Pickup = 4
    }
}

