



using System;

namespace StrategyPatternSample
{
    // Order shipment subsystem
    class Shipment
    {
        public bool CanShipTo(string address, CarrierType carrier)
        {
            if (carrier == CarrierType.Pickup) return true;

            return !string.IsNullOrWhiteSpace(address);
        }

        public void DeliverOrder(string address, EShopBasket basket)
        {
            Console.WriteLine("Deliver order to address: " + address);
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








//using StrategyAssignment;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StrategyPatternSample
//{
//    class Eshop
//    {
//        public static void EShopDemo()
//        {
//            var basket = new EShopBasket();
//            var amount = 32.32m;
//            basket.SetDueAmount(amount);

//            Console.Write("How would you like to pay? 1) CC, 2) PayPal, 3) ApplePay : ");
//            var paymentType = int.Parse(Console.ReadLine().Trim());
//            Console.Write("Please select the shipment method (1=PostOffice, 2=Courier, 3=Own, 4=Pickup:");
//            var carrierType = (CarrierType)int.Parse(Console.ReadLine().Trim());
//            Console.Write("Please give your address:");
//            var address = Console.ReadLine().Trim();

//            var simpleEshop = new SimpleEshop();
//            var success = simpleEshop.PayAndSendOrder(basket, paymentType, address, carrierType);
//            Console.WriteLine(success);
//            Console.Read();
//        }

//        
//        }

//        public void PayTShirt(TShirt tshirt)
//        {
//            foreach (var variation in _variations)
//            {
//                Console.WriteLine($"Applying {variation.GetType().Name}");
//                variation.Cost(tshirt);
//                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}");
//            }

//            _paymentMethod.Pay(tshirt.Price);
//            Console.WriteLine(tshirt.Price);
//        }

//        //public void PayTShirt(TShirt tshirt)
//        //{

//        //    CalculatingCost(tshirt);

//        //    _paymentMethod.Pay(tshirt.Price);
//        //    Console.WriteLine("test       " +   tshirt.Price);
//        //}



//        public static void EShopDemo()
//        {
//            var basket = new EShopBasket();
//            var amount = 32.32m;
//            basket.SetDueAmount(amount);

//            Console.Write("How would you like to pay? 1) CC, 2) BankTransfer, 3) Cash : ");
//            var input = int.Parse(Console.ReadLine().Trim());
//            bool success = PayBasket(basket, input);

//            if (success)
//            {
//                Console.Write("Please select the shipment method 1=PostOffice, 2=Courier, 3=Own, 4=Pickup:");
//                var carrierType = (CarrierType)int.Parse(Console.ReadLine().Trim());
//                if (carrierType != CarrierType.Pickup)
//                {
//                    Console.Write("Please give your address:");
//                    var address = Console.ReadLine().Trim();
//                    var shipment = new Shipment();
//                    if (shipment.CanShipTo(address, carrierType))
//                    {
//                        shipment.DeliverOrder(address, basket);
//                    }
//                }
//            }


//            Console.Write("Is the address correct: ");
//            Console.WriteLine(success);
//            Console.WriteLine("Please press enter");
//            Console.Read();
//        }



//        private static bool PayBasket(EShopBasket basket, int input)
//        {
//            switch (input)
//            {
//                case 1:
//                    basket.SelectPaymentMethod(new CreditDebitCard());
//                    break;

//                case 2:
//                    basket.SelectPaymentMethod(new BankTransfer());
//                    break;

//                case 3:
//                    basket.SelectPaymentMethod(new Cash());
//                    break;

//                default:
//                    basket.SelectPaymentMethod(new Cash());
//                    break;

//            }
//            var success = basket.Pay();
//            return success;
//        }
//    }

//    // Order shipment subsystem
//    class Shipment
//    {
//        public bool CanShipTo(string address, CarrierType carrier)
//        {
//            if (carrier == CarrierType.Pickup) return true;

//            return !string.IsNullOrWhiteSpace(address);
//        }

//        public void DeliverOrder(string address, EShopBasket basket)
//        {
//            Console.WriteLine("Deliver order to address: " + address);
//        }
//    }


//    enum CarrierType
//    {
//        PostOffice = 1,
//        Courier = 2,
//        OwnDelivery = 3,
//        Pickup = 4
//    }




//    // Facade
//    class SimpleEshop
//    {
//        public bool PayAndSendOrder(EShopBasket basket, int paymentMethod, string address, CarrierType carrierType)
//        {
//            var payments = new Payments();
//            bool success = payments.PayBasket(basket, paymentMethod);

//            if (success)
//            {
//                if (carrierType != CarrierType.Pickup)
//                {
//                    var shipment = new Shipment();
//                    if (shipment.CanShipTo(address, carrierType))
//                    {
//                        shipment.DeliverOrder(address, basket);
//                    }
//                    else
//                    {
//                        success = false;
//                    }
//                }
//            }

//            return success;
//        }
//    }















//}


