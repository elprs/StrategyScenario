using StrategyAssignment;
using System;

namespace StrategyPatternSample
{
    public static class Eshop
    {
        //Find rhe cost, communicate all the tshirt and process details to the user
        public static decimal CostAndCommunication()
        {
            decimal amount = TotalTshirtCost.CommunicateWithCustomerAboutTshirt();
            ProceedToPaymentUserMessage(amount);
            return amount;
        }

        public static void EShopDemo(decimal amount)
        {
            var basket = new EShopBasket();
            
            basket.SetDueAmount(amount);

            Console.Write("How would you like to pay? 1) Credit/Debit card, 2) Bank Transfer, 3) Cash : ");
            var paymentType = int.Parse(Console.ReadLine().Trim());

            Console.Write("Please select the shipment method : 1=PostOffice, 2=Courier, 3=Own, 4=Pickup:");
            var carrierType = (CarrierType)int.Parse(Console.ReadLine().Trim());

            Console.Write("Please give your address:");
            var address = Console.ReadLine().Trim();

            var simpleEshop = new SimpleEshop();
            var success = simpleEshop.PayAndSendOrder(basket, paymentType, address, carrierType);

            Console.Write("Is the address correct?  ");
            Console.WriteLine(success);
            Console.WriteLine("Our next feature: Wou will soon receive a comfirmation email! Thank you for shopping with us!");
            Console.WriteLine("Please press enter");
         
            Console.Read();
        }

        private static void ProceedToPaymentUserMessage(decimal amount)
        {
            //Proceed to payment

            Console.WriteLine($"The total cost is {amount} Euro. Would you like to buy it now?");
            Console.WriteLine("------------");
            Console.WriteLine("| SHOP NOW |");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("We are proceeding to payment. ");
            Console.WriteLine();
            Console.WriteLine("Choose your prefered payment method.");
            Console.WriteLine();
        }
    }

    // Facade
    class SimpleEshop
    {
        public bool PayAndSendOrder(EShopBasket basket, int paymentMethod, string address, CarrierType carrierType)
        {
            var payments = new Payments();
            bool success = payments.PayBasket(basket, paymentMethod);

            if (success)
            {
                if (carrierType != CarrierType.Pickup)
                {
                    var shipment = new Shipment();
                    if (shipment.CanShipTo(address, carrierType))
                    {
                        shipment.DeliverOrder(address, basket);
                    }
                    else
                    {
                        success = false;
                    }
                }
            }

            return success;
        }
    }
}



